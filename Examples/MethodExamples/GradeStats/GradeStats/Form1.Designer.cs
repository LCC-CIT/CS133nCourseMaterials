namespace GradeStats
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
            this.scoreTextBox = new System.Windows.Forms.TextBox();
            this.calcStatsButton = new System.Windows.Forms.Button();
            this.averageLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.minLabel = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.maxLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(65, 50);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoreTextBox.TabIndex = 0;
            // 
            // calcStatsButton
            // 
            this.calcStatsButton.Location = new System.Drawing.Point(65, 102);
            this.calcStatsButton.Name = "calcStatsButton";
            this.calcStatsButton.Size = new System.Drawing.Size(100, 23);
            this.calcStatsButton.TabIndex = 1;
            this.calcStatsButton.Text = "Calc Stats";
            this.calcStatsButton.UseVisualStyleBackColor = true;
            this.calcStatsButton.Click += new System.EventHandler(this.calcStatsButton_Click);
            // 
            // averageLabel
            // 
            this.averageLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.averageLabel.CausesValidation = false;
            this.averageLabel.Location = new System.Drawing.Point(90, 155);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(100, 23);
            this.averageLabel.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 156);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(47, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Average";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 193);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Min";
            // 
            // minLabel
            // 
            this.minLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.minLabel.CausesValidation = false;
            this.minLabel.Location = new System.Drawing.Point(90, 192);
            this.minLabel.Name = "minLabel";
            this.minLabel.Size = new System.Drawing.Size(100, 23);
            this.minLabel.TabIndex = 4;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 231);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(27, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Max";
            // 
            // maxLabel
            // 
            this.maxLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.maxLabel.CausesValidation = false;
            this.maxLabel.Location = new System.Drawing.Point(90, 230);
            this.maxLabel.Name = "maxLabel";
            this.maxLabel.Size = new System.Drawing.Size(100, 23);
            this.maxLabel.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(72, 20);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Enter Score:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.maxLabel);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.minLabel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.calcStatsButton);
            this.Controls.Add(this.scoreTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button calcStatsButton;
        private System.Windows.Forms.Label averageLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label minLabel;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label maxLabel;
        private System.Windows.Forms.Label label3;
    }
}

