namespace CarSeat
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
            this.ageTextBox = new System.Windows.Forms.TextBox();
            this.adviceLabel = new System.Windows.Forms.Label();
            this.weightTextBox = new System.Windows.Forms.TextBox();
            this.adviceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ageTextBox
            // 
            this.ageTextBox.Location = new System.Drawing.Point(35, 30);
            this.ageTextBox.Name = "ageTextBox";
            this.ageTextBox.Size = new System.Drawing.Size(100, 20);
            this.ageTextBox.TabIndex = 0;
            // 
            // adviceLabel
            // 
            this.adviceLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.adviceLabel.Location = new System.Drawing.Point(35, 150);
            this.adviceLabel.Name = "adviceLabel";
            this.adviceLabel.Size = new System.Drawing.Size(100, 23);
            this.adviceLabel.TabIndex = 1;
            // 
            // weightTextBox
            // 
            this.weightTextBox.Location = new System.Drawing.Point(35, 71);
            this.weightTextBox.Name = "weightTextBox";
            this.weightTextBox.Size = new System.Drawing.Size(100, 20);
            this.weightTextBox.TabIndex = 2;
            // 
            // adviceButton
            // 
            this.adviceButton.Location = new System.Drawing.Point(35, 112);
            this.adviceButton.Name = "adviceButton";
            this.adviceButton.Size = new System.Drawing.Size(100, 23);
            this.adviceButton.TabIndex = 3;
            this.adviceButton.Text = "Get Advice";
            this.adviceButton.UseVisualStyleBackColor = true;
            this.adviceButton.Click += new System.EventHandler(this.adviceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(230, 262);
            this.Controls.Add(this.adviceButton);
            this.Controls.Add(this.weightTextBox);
            this.Controls.Add(this.adviceLabel);
            this.Controls.Add(this.ageTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox ageTextBox;
        private System.Windows.Forms.Label adviceLabel;
        private System.Windows.Forms.TextBox weightTextBox;
        private System.Windows.Forms.Button adviceButton;
    }
}

