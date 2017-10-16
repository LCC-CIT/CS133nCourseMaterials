namespace Checkers
{
    partial class CheckerBoardForm
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
            this.rowTextBox = new System.Windows.Forms.TextBox();
            this.columnTextBox = new System.Windows.Forms.TextBox();
            this.fromButton = new System.Windows.Forms.Button();
            this.toButton = new System.Windows.Forms.Button();
            this.boardTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rowTextBox
            // 
            this.rowTextBox.Location = new System.Drawing.Point(48, 34);
            this.rowTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rowTextBox.Name = "rowTextBox";
            this.rowTextBox.Size = new System.Drawing.Size(100, 22);
            this.rowTextBox.TabIndex = 0;
            // 
            // columnTextBox
            // 
            this.columnTextBox.Location = new System.Drawing.Point(174, 34);
            this.columnTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.columnTextBox.Name = "columnTextBox";
            this.columnTextBox.Size = new System.Drawing.Size(100, 22);
            this.columnTextBox.TabIndex = 1;
            // 
            // fromButton
            // 
            this.fromButton.Location = new System.Drawing.Point(48, 73);
            this.fromButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.fromButton.Name = "fromButton";
            this.fromButton.Size = new System.Drawing.Size(100, 28);
            this.fromButton.TabIndex = 2;
            this.fromButton.Text = "From";
            this.fromButton.UseVisualStyleBackColor = true;
            this.fromButton.Click += new System.EventHandler(this.fromButton_Click);
            // 
            // toButton
            // 
            this.toButton.Location = new System.Drawing.Point(177, 73);
            this.toButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.toButton.Name = "toButton";
            this.toButton.Size = new System.Drawing.Size(100, 28);
            this.toButton.TabIndex = 3;
            this.toButton.Text = "To";
            this.toButton.UseVisualStyleBackColor = true;
            this.toButton.Click += new System.EventHandler(this.toButton_Click);
            // 
            // boardTextBox
            // 
            this.boardTextBox.Location = new System.Drawing.Point(48, 133);
            this.boardTextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.boardTextBox.Multiline = true;
            this.boardTextBox.Name = "boardTextBox";
            this.boardTextBox.Size = new System.Drawing.Size(229, 137);
            this.boardTextBox.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Row";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(174, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Column";
            // 
            // CheckerBoardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(303, 302);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.boardTextBox);
            this.Controls.Add(this.toButton);
            this.Controls.Add(this.fromButton);
            this.Controls.Add(this.columnTextBox);
            this.Controls.Add(this.rowTextBox);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "CheckerBoardForm";
            this.Text = "Checker Board";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox rowTextBox;
        private System.Windows.Forms.TextBox columnTextBox;
        private System.Windows.Forms.Button fromButton;
        private System.Windows.Forms.Button toButton;
        private System.Windows.Forms.TextBox boardTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

