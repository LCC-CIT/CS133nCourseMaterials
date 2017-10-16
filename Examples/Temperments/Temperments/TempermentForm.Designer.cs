namespace Temperments
{
    partial class TempermentForm
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
            this.reactiveTrackBar = new System.Windows.Forms.TrackBar();
            this.expressiveTrackBar = new System.Windows.Forms.TrackBar();
            this.phlegmaticLabel = new System.Windows.Forms.Label();
            this.cholericLabel = new System.Windows.Forms.Label();
            this.SanguineLabel = new System.Windows.Forms.Label();
            this.melancholicLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.reactiveLabel = new System.Windows.Forms.Label();
            this.expressiveLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.reactiveTrackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressiveTrackBar)).BeginInit();
            this.SuspendLayout();
            // 
            // reactiveTrackBar
            // 
            this.reactiveTrackBar.Location = new System.Drawing.Point(69, 30);
            this.reactiveTrackBar.Name = "reactiveTrackBar";
            this.reactiveTrackBar.Size = new System.Drawing.Size(261, 45);
            this.reactiveTrackBar.TabIndex = 0;
            this.reactiveTrackBar.Scroll += new System.EventHandler(this.reactiveTrackBar_Scroll);
            // 
            // expressiveTrackBar
            // 
            this.expressiveTrackBar.Location = new System.Drawing.Point(12, 78);
            this.expressiveTrackBar.Name = "expressiveTrackBar";
            this.expressiveTrackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.expressiveTrackBar.Size = new System.Drawing.Size(45, 117);
            this.expressiveTrackBar.TabIndex = 1;
            this.expressiveTrackBar.Value = 1;
            // 
            // phlegmaticLabel
            // 
            this.phlegmaticLabel.AutoSize = true;
            this.phlegmaticLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.phlegmaticLabel.Location = new System.Drawing.Point(69, 88);
            this.phlegmaticLabel.Name = "phlegmaticLabel";
            this.phlegmaticLabel.Size = new System.Drawing.Size(122, 24);
            this.phlegmaticLabel.TabIndex = 2;
            this.phlegmaticLabel.Text = "Phlegmatic";
            // 
            // cholericLabel
            // 
            this.cholericLabel.AutoSize = true;
            this.cholericLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cholericLabel.Location = new System.Drawing.Point(201, 162);
            this.cholericLabel.Name = "cholericLabel";
            this.cholericLabel.Size = new System.Drawing.Size(93, 24);
            this.cholericLabel.TabIndex = 3;
            this.cholericLabel.Text = "Choleric";
            // 
            // SanguineLabel
            // 
            this.SanguineLabel.AutoSize = true;
            this.SanguineLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SanguineLabel.Location = new System.Drawing.Point(69, 162);
            this.SanguineLabel.Name = "SanguineLabel";
            this.SanguineLabel.Size = new System.Drawing.Size(105, 24);
            this.SanguineLabel.TabIndex = 4;
            this.SanguineLabel.Text = "Sanguine";
            // 
            // melancholicLabel
            // 
            this.melancholicLabel.AutoSize = true;
            this.melancholicLabel.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.melancholicLabel.Location = new System.Drawing.Point(201, 88);
            this.melancholicLabel.Name = "melancholicLabel";
            this.melancholicLabel.Size = new System.Drawing.Size(129, 24);
            this.melancholicLabel.TabIndex = 5;
            this.melancholicLabel.Text = "Melancholic";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 198);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(19, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "10";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(13, 14);
            this.label2.TabIndex = 7;
            this.label2.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(50, 29);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(13, 14);
            this.label3.TabIndex = 8;
            this.label3.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 219);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(61, 14);
            this.label4.TabIndex = 9;
            this.label4.Text = "Experssive";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(142, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 14);
            this.label5.TabIndex = 10;
            this.label5.Text = "Reactive";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(337, 29);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(19, 14);
            this.label6.TabIndex = 11;
            this.label6.Text = "10";
            // 
            // reactiveLabel
            // 
            this.reactiveLabel.AutoSize = true;
            this.reactiveLabel.Location = new System.Drawing.Point(205, 9);
            this.reactiveLabel.Name = "reactiveLabel";
            this.reactiveLabel.Size = new System.Drawing.Size(0, 14);
            this.reactiveLabel.TabIndex = 12;
            // 
            // expressiveLabel
            // 
            this.expressiveLabel.AutoSize = true;
            this.expressiveLabel.Location = new System.Drawing.Point(94, 218);
            this.expressiveLabel.Name = "expressiveLabel";
            this.expressiveLabel.Size = new System.Drawing.Size(0, 14);
            this.expressiveLabel.TabIndex = 13;
            // 
            // TempermentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(373, 242);
            this.Controls.Add(this.expressiveLabel);
            this.Controls.Add(this.reactiveLabel);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.melancholicLabel);
            this.Controls.Add(this.SanguineLabel);
            this.Controls.Add(this.cholericLabel);
            this.Controls.Add(this.phlegmaticLabel);
            this.Controls.Add(this.expressiveTrackBar);
            this.Controls.Add(this.reactiveTrackBar);
            this.Name = "TempermentForm";
            this.Text = "Temperments";
            ((System.ComponentModel.ISupportInitialize)(this.reactiveTrackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.expressiveTrackBar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TrackBar reactiveTrackBar;
        private System.Windows.Forms.TrackBar expressiveTrackBar;
        private System.Windows.Forms.Label phlegmaticLabel;
        private System.Windows.Forms.Label cholericLabel;
        private System.Windows.Forms.Label SanguineLabel;
        private System.Windows.Forms.Label melancholicLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label reactiveLabel;
        private System.Windows.Forms.Label expressiveLabel;
    }
}

