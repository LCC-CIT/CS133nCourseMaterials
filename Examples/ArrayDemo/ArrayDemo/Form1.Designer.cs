namespace ArrayDemo
{
    partial class ArrayDemoForm
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
            this.enterButton = new System.Windows.Forms.Button();
            this.displayTextBox = new System.Windows.Forms.TextBox();
            this.displayButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // scoreTextBox
            // 
            this.scoreTextBox.Location = new System.Drawing.Point(64, 30);
            this.scoreTextBox.Name = "scoreTextBox";
            this.scoreTextBox.Size = new System.Drawing.Size(100, 20);
            this.scoreTextBox.TabIndex = 0;
            // 
            // enterButton
            // 
            this.enterButton.Location = new System.Drawing.Point(67, 74);
            this.enterButton.Name = "enterButton";
            this.enterButton.Size = new System.Drawing.Size(75, 23);
            this.enterButton.TabIndex = 1;
            this.enterButton.Text = "Enter";
            this.enterButton.UseVisualStyleBackColor = true;
            this.enterButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // displayTextBox
            // 
            this.displayTextBox.Location = new System.Drawing.Point(64, 183);
            this.displayTextBox.Name = "displayTextBox";
            this.displayTextBox.Size = new System.Drawing.Size(184, 20);
            this.displayTextBox.TabIndex = 2;
            // 
            // displayButton
            // 
            this.displayButton.Location = new System.Drawing.Point(67, 135);
            this.displayButton.Name = "displayButton";
            this.displayButton.Size = new System.Drawing.Size(75, 23);
            this.displayButton.TabIndex = 3;
            this.displayButton.Text = "Display";
            this.displayButton.UseVisualStyleBackColor = true;
            this.displayButton.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(64, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Score";
            // 
            // ArrayDemoForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.displayButton);
            this.Controls.Add(this.displayTextBox);
            this.Controls.Add(this.enterButton);
            this.Controls.Add(this.scoreTextBox);
            this.Name = "ArrayDemoForm";
            this.Text = "Array Demo";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox scoreTextBox;
        private System.Windows.Forms.Button enterButton;
        private System.Windows.Forms.TextBox displayTextBox;
        private System.Windows.Forms.Button displayButton;
        private System.Windows.Forms.Label label1;
    }
}

