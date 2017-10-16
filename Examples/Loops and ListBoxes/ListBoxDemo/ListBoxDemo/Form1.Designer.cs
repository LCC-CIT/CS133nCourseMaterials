namespace ListBoxDemo
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
            this.outputListBox = new System.Windows.Forms.ListBox();
            this.doButton = new System.Windows.Forms.Button();
            this.inputTextBox = new System.Windows.Forms.TextBox();
            this.outputLabel = new System.Windows.Forms.Label();
            this.randomChoiceButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // outputListBox
            // 
            this.outputListBox.FormattingEnabled = true;
            this.outputListBox.Items.AddRange(new object[] {
            "000",
            "010",
            "029",
            "031",
            "102",
            "200"});
            this.outputListBox.Location = new System.Drawing.Point(73, 137);
            this.outputListBox.Name = "outputListBox";
            this.outputListBox.Size = new System.Drawing.Size(120, 95);
            this.outputListBox.TabIndex = 0;
            this.outputListBox.SelectedIndexChanged += new System.EventHandler(this.outputListBox_SelectedIndexChanged);
            // 
            // doButton
            // 
            this.doButton.Location = new System.Drawing.Point(33, 34);
            this.doButton.Name = "doButton";
            this.doButton.Size = new System.Drawing.Size(60, 23);
            this.doButton.TabIndex = 1;
            this.doButton.Text = "Do!";
            this.doButton.UseVisualStyleBackColor = true;
            this.doButton.Click += new System.EventHandler(this.doButton_Click);
            // 
            // inputTextBox
            // 
            this.inputTextBox.Location = new System.Drawing.Point(73, 92);
            this.inputTextBox.Name = "inputTextBox";
            this.inputTextBox.Size = new System.Drawing.Size(120, 20);
            this.inputTextBox.TabIndex = 2;
            // 
            // outputLabel
            // 
            this.outputLabel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.outputLabel.Location = new System.Drawing.Point(70, 258);
            this.outputLabel.Name = "outputLabel";
            this.outputLabel.Size = new System.Drawing.Size(123, 23);
            this.outputLabel.TabIndex = 3;
            // 
            // randomChoiceButton
            // 
            this.randomChoiceButton.Location = new System.Drawing.Point(127, 34);
            this.randomChoiceButton.Name = "randomChoiceButton";
            this.randomChoiceButton.Size = new System.Drawing.Size(101, 23);
            this.randomChoiceButton.TabIndex = 4;
            this.randomChoiceButton.Text = "Random Choice";
            this.randomChoiceButton.UseVisualStyleBackColor = true;
            this.randomChoiceButton.Click += new System.EventHandler(this.randomChoiceButton_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 306);
            this.Controls.Add(this.randomChoiceButton);
            this.Controls.Add(this.outputLabel);
            this.Controls.Add(this.inputTextBox);
            this.Controls.Add(this.doButton);
            this.Controls.Add(this.outputListBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox outputListBox;
        private System.Windows.Forms.Button doButton;
        private System.Windows.Forms.TextBox inputTextBox;
        private System.Windows.Forms.Label outputLabel;
        private System.Windows.Forms.Button randomChoiceButton;
    }
}

