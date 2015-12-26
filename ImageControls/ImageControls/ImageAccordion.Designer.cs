namespace ImageControls
{
    partial class ImageAccordion
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
            this.flowLayoutPanel1 = new System.Windows.Forms.FlowLayoutPanel();
            this.accordionButton2 = new AccordionButton();
            this.accordionButton1 = new AccordionButton();
            this.SuspendLayout();
            // 
            // flowLayoutPanel1
            // 
            this.flowLayoutPanel1.AutoScroll = true;
            this.flowLayoutPanel1.Location = new System.Drawing.Point(65, 18);
            this.flowLayoutPanel1.Name = "flowLayoutPanel1";
            this.flowLayoutPanel1.Size = new System.Drawing.Size(200, 100);
            this.flowLayoutPanel1.TabIndex = 2;
            this.flowLayoutPanel1.WrapContents = false;
            // 
            // accordionButton2
            // 
            this.accordionButton2.Dock = System.Windows.Forms.DockStyle.Right;
            this.accordionButton2.IsEnable = true;
            this.accordionButton2.IsLeft = true;
            this.accordionButton2.Location = new System.Drawing.Point(408, 0);
            this.accordionButton2.Name = "accordionButton2";
            this.accordionButton2.Size = new System.Drawing.Size(50, 121);
            this.accordionButton2.TabIndex = 1;
            this.accordionButton2.Text = "accordionButton2";
            this.accordionButton2.UseVisualStyleBackColor = true;
            this.accordionButton2.Click += new System.EventHandler(this.accordionButton2_Click_1);
            // 
            // accordionButton1
            // 
            this.accordionButton1.Dock = System.Windows.Forms.DockStyle.Left;
            this.accordionButton1.IsEnable = true;
            this.accordionButton1.IsLeft = false;
            this.accordionButton1.Location = new System.Drawing.Point(0, 0);
            this.accordionButton1.Name = "accordionButton1";
            this.accordionButton1.Size = new System.Drawing.Size(50, 121);
            this.accordionButton1.TabIndex = 0;
            this.accordionButton1.Text = "leftButton";
            this.accordionButton1.UseVisualStyleBackColor = true;
            this.accordionButton1.Click += new System.EventHandler(this.accordionButton1_Click);
            // 
            // ImageAccordion
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.accordionButton2);
            this.Controls.Add(this.accordionButton1);
            this.Name = "ImageAccordion";
            this.Size = new System.Drawing.Size(458, 121);
            this.ResumeLayout(false);

        }

        #endregion

        private AccordionButton accordionButton1;
        private AccordionButton accordionButton2;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

       
    }
}
