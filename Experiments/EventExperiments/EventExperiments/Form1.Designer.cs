namespace EventExperiments
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
            this.exptLabel = new System.Windows.Forms.Label();
            this.exptButton = new System.Windows.Forms.Button();
            this.exptTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // exptLabel
            // 
            this.exptLabel.AutoSize = true;
            this.exptLabel.Location = new System.Drawing.Point(111, 44);
            this.exptLabel.Name = "exptLabel";
            this.exptLabel.Size = new System.Drawing.Size(101, 13);
            this.exptLabel.TabIndex = 0;
            this.exptLabel.Text = "Experimental Button";
            // 
            // exptButton
            // 
            this.exptButton.Location = new System.Drawing.Point(114, 79);
            this.exptButton.Name = "exptButton";
            this.exptButton.Size = new System.Drawing.Size(75, 23);
            this.exptButton.TabIndex = 1;
            this.exptButton.Text = "Click me!";
            this.exptButton.UseVisualStyleBackColor = true;
            this.exptButton.Click += new System.EventHandler(this.exptButton_Click);
            // 
            // exptTextBox
            // 
            this.exptTextBox.Location = new System.Drawing.Point(84, 141);
            this.exptTextBox.Name = "exptTextBox";
            this.exptTextBox.Size = new System.Drawing.Size(146, 20);
            this.exptTextBox.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.exptTextBox);
            this.Controls.Add(this.exptButton);
            this.Controls.Add(this.exptLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exptLabel;
        private System.Windows.Forms.Button exptButton;
        private System.Windows.Forms.TextBox exptTextBox;
    }
}

