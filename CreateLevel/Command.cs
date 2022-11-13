#region Namespaces
using Autodesk.Revit.ApplicationServices;
using Autodesk.Revit.Attributes;
using Autodesk.Revit.DB;
using Autodesk.Revit.UI;
using Autodesk.Revit.UI.Selection;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;

#endregion

namespace CreateLevel
{
    [Transaction(TransactionMode.Manual)]
    public class Command : IExternalCommand
    {
        public Result Execute(
          ExternalCommandData commandData,
          ref string message,
          ElementSet elements)
        {
            UIApplication uiapp = commandData.Application;
            UIDocument uidoc = uiapp.ActiveUIDocument;
            Application app = uiapp.Application;
            Document doc = uidoc.Document;

            // set up form and ask for user information
            Form1 form1 = new Form1(commandData);
            form1.ShowDialog();

            // grab string values and convert to respective types
            string levelsValueString = form1.levelsValue.ToString();
            int intLevelsValue = int.Parse(levelsValueString);

            string feetValueString = form1.feetValue.ToString();
            double feetValueDouble = double.Parse(feetValueString);

            // grab levels in project for placement
            FilteredElementCollector colLevels 
                = new FilteredElementCollector(doc)
                .WhereElementIsNotElementType()
                .OfCategory(BuiltInCategory.INVALID)
                .OfClass(typeof(Level));

            // declare empty list and array
            double[] elevArray = { };
            List<double> levelElevList = new List<double>();

            // grab the highest elevation in project
            foreach (Level level in colLevels)
            {
                double elevations = level.Elevation;
                levelElevList.Add(elevations);
                elevArray = levelElevList.ToArray();
            }

            double highestElevation = elevArray.Max();

            // grab floor type
            FilteredElementCollector collector = new FilteredElementCollector(doc);
            collector.OfClass(typeof(FloorType));
            FloorType floorType = collector.FirstElement() as FloorType;

            // set elevation
            //var elevation = 10.0;
            double elevation = highestElevation;


            using (Transaction tx = new Transaction(doc))
            {
                try
                {
                    tx.Start("ButtonName");

                    // Code goes here.

                    // Create for loop to add floor height to existing max height
                    for (int i = 0; i < intLevelsValue; i++)
                    {
                        // add floors to floor height to max level
                        elevation += feetValueDouble;

                        // Create Level
                        Level level = Level.Create(doc, elevation);

                        // change level Name
                        // level.Name = "my new level";

                        // layout coordinates for profile lines
                        XYZ first = new XYZ(0, 0, elevation);
                        XYZ second = new XYZ(20, 0, elevation);
                        XYZ third = new XYZ(20, 15, elevation);
                        XYZ fourth = new XYZ(0, 15, elevation);

                        // add lines to profile
                        CurveArray profile = new CurveArray();
                        profile.Append(Line.CreateBound(first, second));
                        profile.Append(Line.CreateBound(second, third));
                        profile.Append(Line.CreateBound(third, fourth));
                        profile.Append(Line.CreateBound(fourth, first));

                        // set normal vector

                        // the normal vector (0,0,1) must be perpendicular to the profile
                        XYZ normal = XYZ.BasisZ;

                        // Create floor
                        doc.Create.NewFloor(profile, floorType, level, true, normal);

                    }

                    tx.Commit();
                }
                catch (Exception e)
                {
                    Debug.Print(e.Message);
                    tx.RollBack();
                }
            }

            return Result.Succeeded;
        }
    }
}
