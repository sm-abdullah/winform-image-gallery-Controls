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
            this.rightButton = new ImageControls.AccordionButton();
            this.leftButton = new ImageControls.AccordionButton();
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
            // rightButton
            // 
            this.rightButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightButton.Face = ImageControls.AccodionButtonFace.Right;
            this.rightButton.IsEnable = true;
            this.rightButton.Location = new System.Drawing.Point(408, 0);
            this.rightButton.Name = "rightButton";
            this.rightButton.Size = new System.Drawing.Size(50, 121);
            this.rightButton.TabIndex = 1;
            this.rightButton.Text = "accordionButton2";
            this.rightButton.UseVisualStyleBackColor = true;
            this.rightButton.Click += new System.EventHandler(this.rightButton_Click);
            // 
            // leftButton
            // 
            this.leftButton.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftButton.Face = ImageControls.AccodionButtonFace.Left;
            this.leftButton.IsEnable = true;
            this.leftButton.Location = new System.Drawing.Point(0, 0);
            this.leftButton.Name = "leftButton";
            this.leftButton.Size = new System.Drawing.Size(50, 121);
            this.leftButton.TabIndex = 0;
            this.leftButton.Text = "leftButton";
            this.leftButton.UseVisualStyleBackColor = true;
            this.leftButton.Click += new System.EventHandler(this.leftButton_Click);
            // 
            // ImageAccordion
            // 
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.flowLayoutPanel1);
            this.Controls.Add(this.rightButton);
            this.Controls.Add(this.leftButton);
            this.Name = "ImageAccordion";
            this.Size = new System.Drawing.Size(458, 121);
            this.Resize += new System.EventHandler(this.ImageAccordion_Resize);
            this.ResumeLayout(false);

        }

        #endregion

        private AccordionButton leftButton;
        private AccordionButton rightButton;
        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanel1;

       
    }
}
