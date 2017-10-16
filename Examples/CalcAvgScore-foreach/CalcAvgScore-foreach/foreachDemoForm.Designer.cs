namespace CalcAvgScore_foreach
{
    partial class foreachDemoForm
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
            this.valuesListBox = new System.Windows.Forms.ListBox();
            this.averageLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoresListBox
            // 
            this.valuesListBox.FormattingEnabled = true;
            this.valuesListBox.Location = new System.Drawing.Point(70, 38);
            this.valuesListBox.Name = "scoresListBox";
            this.valuesListBox.Size = new System.Drawing.Size(120, 147);
            this.valuesListBox.TabIndex = 0;
            // 
            // averageLabel
            // 
            this.averageLabel.AutoSize = true;
            this.averageLabel.Location = new System.Drawing.Point(84, 216);
            this.averageLabel.Name = "averageLabel";
            this.averageLabel.Size = new System.Drawing.Size(76, 13);
            this.averageLabel.TabIndex = 1;
            this.averageLabel.Text = "Average score";
            // 
            // foreachDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.averageLabel);
            this.Controls.Add(this.valuesListBox);
            this.Name = "foreachDemoForm";
            this.Text = "foreach demo";
            this.Load += new System.EventHandler(this.foreachDemoForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox valuesListBox;
        private System.Windows.Forms.Label averageLabel;
    }
}

