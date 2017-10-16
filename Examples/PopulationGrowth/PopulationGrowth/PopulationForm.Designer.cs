namespace PopulationGrowth
{
    partial class PopulationForm
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
            this.populationListBox = new System.Windows.Forms.ListBox();
            this.calcButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // populationListBox
            // 
            this.populationListBox.FormattingEnabled = true;
            this.populationListBox.Location = new System.Drawing.Point(13, 13);
            this.populationListBox.Name = "populationListBox";
            this.populationListBox.Size = new System.Drawing.Size(259, 199);
            this.populationListBox.TabIndex = 0;
            // 
            // calcButton
            // 
            this.calcButton.Location = new System.Drawing.Point(104, 226);
            this.calcButton.Name = "calcButton";
            this.calcButton.Size = new System.Drawing.Size(75, 23);
            this.calcButton.TabIndex = 1;
            this.calcButton.Text = "Calculate";
            this.calcButton.UseVisualStyleBackColor = true;
            this.calcButton.Click += new System.EventHandler(this.calcButton_Click);
            // 
            // PopulationForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.calcButton);
            this.Controls.Add(this.populationListBox);
            this.Name = "PopulationForm";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox populationListBox;
        private System.Windows.Forms.Button calcButton;
    }
}

