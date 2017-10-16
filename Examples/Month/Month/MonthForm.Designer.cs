namespace Month
{
    partial class MonthForm
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
            this.monthListBox = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // monthListBox
            // 
            this.monthListBox.FormattingEnabled = true;
            this.monthListBox.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April",
            "May",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.monthListBox.Location = new System.Drawing.Point(13, 13);
            this.monthListBox.Name = "monthListBox";
            this.monthListBox.Size = new System.Drawing.Size(120, 82);
            this.monthListBox.TabIndex = 0;
            this.monthListBox.SelectedIndexChanged += new System.EventHandler(this.monthListBox_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(12, 123);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(393, 102);
            this.textBox1.TabIndex = 1;
            // 
            // MonthForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(417, 261);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.monthListBox);
            this.Name = "MonthForm";
            this.Text = "Month";
            this.Load += new System.EventHandler(this.MonthForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox monthListBox;
        private System.Windows.Forms.TextBox textBox1;
    }
}

