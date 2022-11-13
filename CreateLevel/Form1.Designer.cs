namespace CreateLevel
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.cancelButton = new System.Windows.Forms.Button();
            this.continueButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.levelsQuantityTextBox = new System.Windows.Forms.TextBox();
            this.feetQuantityTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // cancelButton
            // 
            this.cancelButton.Location = new System.Drawing.Point(332, 269);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(107, 33);
            this.cancelButton.TabIndex = 0;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = true;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // continueButton
            // 
            this.continueButton.Location = new System.Drawing.Point(158, 269);
            this.continueButton.Name = "continueButton";
            this.continueButton.Size = new System.Drawing.Size(107, 33);
            this.continueButton.TabIndex = 1;
            this.continueButton.Text = "Continue";
            this.continueButton.UseVisualStyleBackColor = true;
            this.continueButton.Click += new System.EventHandler(this.continueButton_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 96);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "How many Levels would you like to add?";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(297, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "What would you like the floor to floor height to be?";
            // 
            // levelsQuantityTextBox
            // 
            this.levelsQuantityTextBox.Location = new System.Drawing.Point(400, 96);
            this.levelsQuantityTextBox.Name = "levelsQuantityTextBox";
            this.levelsQuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.levelsQuantityTextBox.TabIndex = 4;
            this.levelsQuantityTextBox.TextChanged += new System.EventHandler(this.levelsQuantityTextBox_TextChanged);
            // 
            // feetQuantityTextBox
            // 
            this.feetQuantityTextBox.Location = new System.Drawing.Point(400, 155);
            this.feetQuantityTextBox.Name = "feetQuantityTextBox";
            this.feetQuantityTextBox.Size = new System.Drawing.Size(100, 22);
            this.feetQuantityTextBox.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 331);
            this.Controls.Add(this.feetQuantityTextBox);
            this.Controls.Add(this.levelsQuantityTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.continueButton);
            this.Controls.Add(this.cancelButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button continueButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox levelsQuantityTextBox;
        private System.Windows.Forms.TextBox feetQuantityTextBox;
    }
}