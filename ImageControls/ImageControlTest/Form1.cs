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
            this.imageAccordion2.Add(new Thumbnail("water",Image.FromFile("img\\img1.jpg")));
            this.imageAccordion2.Add(new Thumbnail("boat",Image.FromFile("img\\img2.jpg")));
            this.imageAccordion2.Add(new Thumbnail("flower",Image.FromFile("img\\img3.jpg")));
            this.imageAccordion2.Add(new Thumbnail("House",Image.FromFile("img\\img4.jpg")));
            this.imageAccordion2.Add(new Thumbnail("Sea", Image.FromFile("img\\img5.jpg")));
            this.imageAccordion2.Add(new Thumbnail("mountain",Image.FromFile("img\\img6.jpg")));
            this.imageAccordion2.Add(new Thumbnail("ligtes", Image.FromFile("img\\img7.jpg")));
            this.imageAccordion2.Add(new Thumbnail( "night View", Image.FromFile("img\\img8.jpg") ));
            this.imageAccordion2.SelectThumnail(0);
            imageAccordion2.HoverColor = Color.Orange;
            imageAccordion2.SelectedColor = Color.DarkBlue ;
            
        }

       


        private void imageAccordion2_ThumbnailChanged(int OldIndex, int NewIndex, Thumbnail thumbnail)
        {
            pictureBox1.BackgroundImage = thumbnail.Image;
            label1.Text = thumbnail.Text;
            label1.Left = (panel1.Width - label1.Width) / 2;
        }
    }
}
