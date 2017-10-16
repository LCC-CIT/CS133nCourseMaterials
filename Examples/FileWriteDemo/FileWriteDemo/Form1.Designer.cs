namespace FileWriteDemo
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
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.inputNumericUpDown = new System.Windows.Forms.NumericUpDown();
            this.numericWriteButton = new System.Windows.Forms.Button();
            this.textWriteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.inputNumericUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(70, 32);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(106, 20);
            this.inputTextBox.TabIndex = 0;
            // 
            // inputNumericUpDown
            // 
            this.inputNumericUpDown.Location = new System.Drawing.Point(70, 143);
            this.inputNumericUpDown.Name = "inputNumericUpDown";
            this.inputNumericUpDown.Size = new System.Drawing.Size(120, 20);
            this.inputNumericUpDown.TabIndex = 1;
            // 
            // numericWriteButton
            // 
            this.numericWriteButton.Location = new System.Drawing.Point(70, 186);
            this.numericWriteButton.Name = "numericWriteButton";
            this.numericWriteButton.Size = new System.Drawing.Size(106, 23);
            this.numericWriteButton.TabIndex = 2;
            this.numericWriteButton.Text = "Number => Disk";
            this.numericWriteButton.UseVisualStyleBackColor = true;
            this.numericWriteButton.Click += new System.EventHandler(this.numericWriteButton_Click);
            // 
            // textWriteButton
            // 
            this.textWriteButton.Location = new System.Drawing.Point(70, 75);
            this.textWriteButton.Name = "textWriteButton";
            this.textWriteButton.Size = new System.Drawing.Size(106, 23);
            this.textWriteButton.TabIndex = 3;
            this.textWriteButton.Text = "Write Text to Disk";
            this.textWriteButton.UseVisualStyleBackColor = true;
            this.textWriteButton.Click += new System.EventHandler(this.textWriteButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.textWriteButton);
            this.Controls.Add(this.numericWriteButton);
            this.Controls.Add(this.inputNumericUpDown);
            this.Controls.Add(this.inputTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.inputNumericUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.NumericUpDown inputNumericUpDown;
        private System.Windows.Forms.Button numericWriteButton;
        private System.Windows.Forms.Button textWriteButton;
    }
}

