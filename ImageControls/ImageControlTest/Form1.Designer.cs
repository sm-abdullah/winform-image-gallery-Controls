namespace ImageControls
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
            this.imageAccordion2 = new ImageControls.ImageAccordion();
            this.thumbnailBox1 = new ImageControls.ThumbnailBox();
            this.SuspendLayout();
            // 
            // imageAccordion2
            // 
            this.imageAccordion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAccordion2.Location = new System.Drawing.Point(12, 287);
            this.imageAccordion2.Name = "imageAccordion2";
            this.imageAccordion2.Size = new System.Drawing.Size(462, 130);
            this.imageAccordion2.TabIndex = 2;
            this.imageAccordion2.ThumbnailChanged += new ImageControls.ImageAccordion.ThumbnailChangedDelegate(this.imageAccordion2_ThumbnailChanged);
            // 
            // thumbnailBox1
            // 
            this.thumbnailBox1.BackColor = System.Drawing.Color.Silver;
            this.thumbnailBox1.Caption = "label1";
            this.thumbnailBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.thumbnailBox1.HoverColor = System.Drawing.Color.Orange;
            this.thumbnailBox1.IsSelected = false;
            this.thumbnailBox1.Location = new System.Drawing.Point(86, 12);
            this.thumbnailBox1.Name = "thumbnailBox1";
            this.thumbnailBox1.SelectedColor = System.Drawing.Color.DarkBlue;
            this.thumbnailBox1.Size = new System.Drawing.Size(315, 254);
            this.thumbnailBox1.TabIndex = 1;
            this.thumbnailBox1.Thumb = null;
            this.thumbnailBox1.ThumbTextPosition = ImageControls.ThumbTextPosition.Top;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(486, 429);
            this.Controls.Add(this.thumbnailBox1);
            this.Controls.Add(this.imageAccordion2);
            this.Name = "Form1";
            this.Text = "Image Thumbnail According Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private ImageAccordion imageAccordion1;
        private ThumbnailBox thumbnailBox1;
        private ImageAccordion imageAccordion2;


    }
}