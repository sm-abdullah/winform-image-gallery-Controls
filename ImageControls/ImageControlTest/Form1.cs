using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageControls
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
      
        }

        private void Form1_Load(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load_1(object sender, EventArgs e)
        {
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "logo2", Thumb = Image.FromFile("D:\\logo.png") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "logo3", Thumb = Image.FromFile("D:\\img.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "logo4", Thumb = Image.FromFile("D:\\logo.png") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "logo5", Thumb = Image.FromFile("D:\\logo.png") });
        
        }
    }
}
