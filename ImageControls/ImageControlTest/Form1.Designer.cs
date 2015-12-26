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
            this.SuspendLayout();
            // 
            // imageAccordion2
            // 
            this.imageAccordion2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.imageAccordion2.Location = new System.Drawing.Point(12, 48);
            this.imageAccordion2.Name = "imageAccordion2";
            this.imageAccordion2.Size = new System.Drawing.Size(458, 186);
            this.imageAccordion2.TabIndex = 0;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(518, 246);
            this.Controls.Add(this.imageAccordion2);
            this.Name = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ImageList imageList1;
        private ImageAccordion imageAccordion1;
        private ImageAccordion imageAccordion2;


    }
}