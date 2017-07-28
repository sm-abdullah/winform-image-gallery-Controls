namespace ImageControls
{
    partial class Form2
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
            this.imageSliderBox3 = new ImageControls.ImageSilder.ImageSliderBox();
            this.SuspendLayout();
            // 
            // imageSliderBox3
            // 
            this.imageSliderBox3.AutoStart = false;
            this.imageSliderBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageSliderBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.imageSliderBox3.Location = new System.Drawing.Point(0, 0);
            this.imageSliderBox3.Loop = true;
            this.imageSliderBox3.Name = "imageSliderBox3";
            this.imageSliderBox3.Size = new System.Drawing.Size(611, 449);
            this.imageSliderBox3.TabIndex = 0;
            this.imageSliderBox3.TabStop = false;
            // 
            // Form2
            // 
            this.ClientSize = new System.Drawing.Size(611, 449);
            this.Controls.Add(this.imageSliderBox3);
            this.Name = "Form2";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);

        }

        #endregion

      
        private ImageSilder.ImageSliderBox imageSliderBox1;
        private ImageSilder.ImageSliderBox imageSliderBox2;
        private ImageSilder.ImageSliderBox imageSliderBox3;

       
    }
}