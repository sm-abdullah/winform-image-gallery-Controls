namespace ImageControls
{
  
        partial class ThumbnailBox
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

            #region Component Designer generated code

            /// <summary> 
            /// Required method for Designer support - do not modify 
            /// the contents of this method with the code editor.
            /// </summary>
            private void InitializeComponent()
            {
                this.panel2 = new System.Windows.Forms.Panel();
                this.ThumbPictureBox = new System.Windows.Forms.PictureBox();
                this.panel1 = new System.Windows.Forms.Panel();
                this.thumbLabel = new System.Windows.Forms.Label();
                this.panel2.SuspendLayout();
                ((System.ComponentModel.ISupportInitialize)(this.ThumbPictureBox)).BeginInit();
                this.panel1.SuspendLayout();
                this.SuspendLayout();
                // 
                // panel2
                // 
                this.panel2.Controls.Add(this.ThumbPictureBox);
                this.panel2.Controls.Add(this.panel1);
                this.panel2.Location = new System.Drawing.Point(16, 16);
                this.panel2.Name = "panel2";
                this.panel2.Size = new System.Drawing.Size(254, 139);
                this.panel2.TabIndex = 3;
                // 
                // ThumbPictureBox
                // 
                this.ThumbPictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
                this.ThumbPictureBox.Dock = System.Windows.Forms.DockStyle.Fill;
                this.ThumbPictureBox.Location = new System.Drawing.Point(0, 22);
                this.ThumbPictureBox.Name = "ThumbPictureBox";
                this.ThumbPictureBox.Size = new System.Drawing.Size(254, 117);
                this.ThumbPictureBox.TabIndex = 2;
                this.ThumbPictureBox.TabStop = false;
                // 
                // panel1
                // 
                this.panel1.Controls.Add(this.thumbLabel);
                this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
                this.panel1.Location = new System.Drawing.Point(0, 0);
                this.panel1.Name = "panel1";
                this.panel1.Size = new System.Drawing.Size(254, 22);
                this.panel1.TabIndex = 3;
                // 
                // thumbLabel
                // 
                this.thumbLabel.AutoSize = true;
                this.thumbLabel.Location = new System.Drawing.Point(123, 4);
                this.thumbLabel.Name = "thumbLabel";
                this.thumbLabel.Size = new System.Drawing.Size(35, 13);
                this.thumbLabel.TabIndex = 1;
                this.thumbLabel.Text = "label1";
                this.thumbLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
                // 
                // ThumbnailBox
                // 
                this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
                this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
                this.BackColor = System.Drawing.SystemColors.ActiveBorder;
                this.Controls.Add(this.panel2);
                this.Name = "ThumbnailBox";
                this.Size = new System.Drawing.Size(280, 165);
                this.panel2.ResumeLayout(false);
                ((System.ComponentModel.ISupportInitialize)(this.ThumbPictureBox)).EndInit();
                this.panel1.ResumeLayout(false);
                this.panel1.PerformLayout();
                this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel panel2;
            private System.Windows.Forms.PictureBox ThumbPictureBox;
            private System.Windows.Forms.Panel panel1;
            private System.Windows.Forms.Label thumbLabel;

        }
    
}
