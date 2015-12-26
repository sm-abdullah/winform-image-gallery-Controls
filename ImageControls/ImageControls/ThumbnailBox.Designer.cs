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
            this.OuterPanel = new System.Windows.Forms.Panel();
            this.ThumbPictureBox = new System.Windows.Forms.PictureBox();
            this.labelPanel = new System.Windows.Forms.Panel();
            this.thumbLabel = new System.Windows.Forms.Label();
            this.OuterPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ThumbPictureBox)).BeginInit();
            this.labelPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // OuterPanel
            // 
            this.OuterPanel.Controls.Add(this.ThumbPictureBox);
            this.OuterPanel.Controls.Add(this.labelPanel);
            this.OuterPanel.Location = new System.Drawing.Point(16, 16);
            this.OuterPanel.Name = "OuterPanel";
            this.OuterPanel.Size = new System.Drawing.Size(254, 139);
            this.OuterPanel.TabIndex = 3;
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
            // labelPanel
            // 
            this.labelPanel.Controls.Add(this.thumbLabel);
            this.labelPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.labelPanel.Location = new System.Drawing.Point(0, 0);
            this.labelPanel.Name = "labelPanel";
            this.labelPanel.Size = new System.Drawing.Size(254, 22);
            this.labelPanel.TabIndex = 3;
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
            this.Controls.Add(this.OuterPanel);
            this.Name = "ThumbnailBox";
            this.Size = new System.Drawing.Size(280, 165);
            this.OuterPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ThumbPictureBox)).EndInit();
            this.labelPanel.ResumeLayout(false);
            this.labelPanel.PerformLayout();
            this.ResumeLayout(false);

            }

            #endregion

            private System.Windows.Forms.Panel OuterPanel;
            private System.Windows.Forms.PictureBox ThumbPictureBox;
            private System.Windows.Forms.Panel labelPanel;
            private System.Windows.Forms.Label thumbLabel;

        }
    
}
