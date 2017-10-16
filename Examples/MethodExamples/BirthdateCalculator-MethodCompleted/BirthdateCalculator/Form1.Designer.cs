namespace BirthdateCalculator
{
    partial class BirthDateCalcForm
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
            this.currentYearTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.hadBirthdayCheckBox = new System.Windows.Forms.CheckBox();
            this.calcYearButton = new System.Windows.Forms.Button();
            this.birthYearLabel = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // currentYearTextBox
            // 
            this.currentYearTextBox.Location = new System.Drawing.Point(49, 41);
            this.currentYearTextBox.Name = "currentYearTextBox";
            this.currentYearTextBox.Size = new System.Drawing.Size(77, 20);
            this.currentYearTextBox.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(57, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(80, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Enter the current year";
            // 
            // hadBirthdayCheckBox
            // 
            this.hadBirthdayCheckBox.AutoSize = true;
            this.hadBirthdayCheckBox.Location = new System.Drawing.Point(49, 84);
            this.hadBirthdayCheckBox.Name = "hadBirthdayCheckBox";
            this.hadBirthdayCheckBox.Size = new System.Drawing.Size(180, 17);
            this.hadBirthdayCheckBox.TabIndex = 2;
            this.hadBirthdayCheckBox.Text = "Had a birthday already this year?";
            this.hadBirthdayCheckBox.UseVisualStyleBackColor = true;
            // 
            // calcYearButton
            // 
            this.calcYearButton.Location = new System.Drawing.Point(49, 128);
            this.calcYearButton.Name = "calcYearButton";
            this.calcYearButton.Size = new System.Drawing.Size(180, 23);
            this.calcYearButton.TabIndex = 3;
            this.calcYearButton.Text = "Calculate Birth Year";
            this.calcYearButton.UseVisualStyleBackColor = true;
            this.calcYearButton.Click += new System.EventHandler(this.calcYearButton_Click);
            // 
            // birthYearLabel
            // 
            this.birthYearLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.birthYearLabel.Location = new System.Drawing.Point(49, 185);
            this.birthYearLabel.Name = "birthYearLabel";
            this.birthYearLabel.Size = new System.Drawing.Size(180, 23);
            this.birthYearLabel.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(160, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Enter   your age";
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(152, 41);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(77, 20);
            this.ageTextBox.TabIndex = 5;
            // 
            // BirthDateCalcForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 239);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.ageTextBox);
            this.Controls.Add(this.birthYearLabel);
            this.Controls.Add(this.calcYearButton);
            this.Controls.Add(this.hadBirthdayCheckBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.currentYearTextBox);
            this.Name = "BirthDateCalcForm";
            this.Text = "Birth Date Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox currentYearTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.CheckBox hadBirthdayCheckBox;
        private System.Windows.Forms.Button calcYearButton;
        private System.Windows.Forms.Label birthYearLabel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox ageTextBox;

    }
}

