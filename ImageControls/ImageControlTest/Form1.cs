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
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "water", Thumb = Image.FromFile("img\\img1.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "boat", Thumb = Image.FromFile("img\\img2.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "flower", Thumb = Image.FromFile("img\\img3.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "House", Thumb = Image.FromFile("img\\img4.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "Sea", Thumb = Image.FromFile("img\\img5.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "mountain", Thumb = Image.FromFile("img\\img6.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "ligtes", Thumb = Image.FromFile("img\\img7.jpg") });
            this.imageAccordion2.Add(new ThumbnailBox() { Caption = "night View", Thumb = Image.FromFile("img\\img8.jpg") });
            this.imageAccordion2.SelectThumnail(0);
        }

       


        private void imageAccordion2_ThumbnailChanged(int OldIndex, int NewIndex, Image currentImage,string text)
        {
           thumbnailBox1.Thumb = currentImage;
           thumbnailBox1.Caption = text;
        }
    }
}
