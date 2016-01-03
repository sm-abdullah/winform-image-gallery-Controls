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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.imageAccordion2 = new ImageControls.ImageAccordion();
            this.accordionButton1 = new ImageControls.AccordionButton();
            this.accordionButton2 = new ImageControls.AccordionButton();
            this.accordionButton3 = new ImageControls.AccordionButton();
            this.accordionButton4 = new ImageControls.AccordionButton();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Location = new System.Drawing.Point(79, 26);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(324, 204);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(132, 10);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 24);
            this.label1.TabIndex = 4;
            this.label1.Text = "label1";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Silver;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(79, 234);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(324, 45);
            this.panel1.TabIndex = 5;
            // 
            // imageAccordion2
            // 
            this.imageAccordion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAccordion2.HoverColor = System.Drawing.Color.Purple;
            this.imageAccordion2.Location = new System.Drawing.Point(12, 287);
            this.imageAccordion2.Name = "imageAccordion2";
            this.imageAccordion2.SelectedColor = System.Drawing.Color.DarkBlue;
            this.imageAccordion2.Size = new System.Drawing.Size(462, 130);
            this.imageAccordion2.TabIndex = 2;
            this.imageAccordion2.ThumbnailChanged += new ImageControls.ImageAccordion.ThumbnailChangedDelegate(this.imageAccordion2_ThumbnailChanged);
            // 
            // accordionButton1
            // 
            this.accordionButton1.DownColor = System.Drawing.Color.DarkBlue;
            this.accordionButton1.Face = ImageControls.AccodionButtonFace.Left;
            this.accordionButton1.HoverColor = System.Drawing.Color.Orange;
            this.accordionButton1.IsEnable = true;
            this.accordionButton1.Location = new System.Drawing.Point(529, 39);
            this.accordionButton1.Name = "accordionButton1";
            this.accordionButton1.Size = new System.Drawing.Size(55, 108);
            this.accordionButton1.TabIndex = 6;
            this.accordionButton1.Text = "accordionButton1";
            this.accordionButton1.UseVisualStyleBackColor = true;
            // 
            // accordionButton2
            // 
            this.accordionButton2.DownColor = System.Drawing.Color.DarkBlue;
            this.accordionButton2.Face = ImageControls.AccodionButtonFace.Right;
            this.accordionButton2.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.accordionButton2.IsEnable = true;
            this.accordionButton2.Location = new System.Drawing.Point(726, 39);
            this.accordionButton2.Name = "accordionButton2";
            this.accordionButton2.Size = new System.Drawing.Size(54, 108);
            this.accordionButton2.TabIndex = 6;
            this.accordionButton2.Text = "accordionButton1";
            this.accordionButton2.UseVisualStyleBackColor = true;
            // 
            // accordionButton3
            // 
            this.accordionButton3.DownColor = System.Drawing.Color.DarkBlue;
            this.accordionButton3.Face = ImageControls.AccodionButtonFace.Down;
            this.accordionButton3.HoverColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.accordionButton3.IsEnable = true;
            this.accordionButton3.Location = new System.Drawing.Point(590, 93);
            this.accordionButton3.Name = "accordionButton3";
            this.accordionButton3.Size = new System.Drawing.Size(130, 51);
            this.accordionButton3.TabIndex = 6;
            this.accordionButton3.Text = "accordionButton1";
            this.accordionButton3.UseVisualStyleBackColor = true;
            // 
            // accordionButton4
            // 
            this.accordionButton4.DownColor = System.Drawing.Color.DarkBlue;
            this.accordionButton4.Face = ImageControls.AccodionButtonFace.Up;
            this.accordionButton4.HoverColor = System.Drawing.Color.Lime;
            this.accordionButton4.IsEnable = true;
            this.accordionButton4.Location = new System.Drawing.Point(590, 39);
            this.accordionButton4.Name = "accordionButton4";
            this.accordionButton4.Size = new System.Drawing.Size(130, 48);
            this.accordionButton4.TabIndex = 6;
            this.accordionButton4.Text = "accordionButton1";
            this.accordionButton4.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(944, 429);
            this.Controls.Add(this.accordionButton4);
            this.Controls.Add(this.accordionButton3);
            this.Controls.Add(this.accordionButton2);
            this.Controls.Add(this.accordionButton1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.imageAccordion2);
            this.Name = "Form1";
            this.Text = "Image Thumbnail According Test";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private ImageAccordion imageAccordion1;
        private ImageAccordion imageAccordion2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private AccordionButton accordionButton1;
        private AccordionButton accordionButton2;
        private AccordionButton accordionButton3;
        private AccordionButton accordionButton4;
     


    }
}