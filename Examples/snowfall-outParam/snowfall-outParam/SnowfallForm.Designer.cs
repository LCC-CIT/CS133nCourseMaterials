namespace snowfall_outParam
{
    partial class SnowfallForm
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
            this.snowListBox = new System.Windows.Forms.ListBox();
            this.showSnowButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // snowListBox
            // 
            this.snowListBox.FormattingEnabled = true;
            this.snowListBox.Location = new System.Drawing.Point(12, 12);
            this.snowListBox.Name = "snowListBox";
            this.snowListBox.Size = new System.Drawing.Size(260, 160);
            this.snowListBox.TabIndex = 0;
            // 
            // showSnowButton
            // 
            this.showSnowButton.Location = new System.Drawing.Point(76, 201);
            this.showSnowButton.Name = "showSnowButton";
            this.showSnowButton.Size = new System.Drawing.Size(104, 23);
            this.showSnowButton.TabIndex = 1;
            this.showSnowButton.Text = "Show Snowfall";
            this.showSnowButton.UseVisualStyleBackColor = true;
            this.showSnowButton.Click += new System.EventHandler(this.showSnowButton_Click);
            // 
            // SnowfallForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.showSnowButton);
            this.Controls.Add(this.snowListBox);
            this.Name = "SnowfallForm";
            this.Text = "Snowfall Calculator";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox snowListBox;
        private System.Windows.Forms.Button showSnowButton;
    }
}

