using ImageControls.ImageSilder;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImageControls
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            this.Paint += Form2_Paint;
        }

        void Form2_Paint(object sender, PaintEventArgs e)
        {
            
            //Graphics g = e.Graphics;
            //int offset = 20;
            //// Invert matrix: 
            //Matrix m = new Matrix(1, 2, 3, 4, 0, 0);
            //g.DrawString("Original Matrix:", this.Font,
            //Brushes.Black, 10, 10);
            //DrawMatrix(m, g, 10, 10 + offset);
            //g.DrawString("Inverted Matrix:", this.Font,
            //Brushes.Black, 10, 10 + 2 * offset);
            //m.Invert();
            //DrawMatrix(m, g, 10, 10 + 3 * offset);
            //// Matrix multiplication - MatrixOrder.Append: 
            //Matrix m1 = new Matrix(1, 2, 3, 4, 0, 1);
            //Matrix m2 = new Matrix(0, 1, 2, 1, 0, 1);
            //g.DrawString("Original Matrices:", this.Font,
            //Brushes.Black, 10, 10 + 4 * offset);
            //DrawMatrix(m1, g, 10, 10 + 5 * offset);
            //DrawMatrix(m2, g, 10 + 100, 10 + 5 * offset);
            //m1.Multiply(m2, MatrixOrder.Append);
            //g.DrawString("Resultant Matrix - Append:", this.Font,
            //Brushes.Black, 10, 10 + 6 * offset);
            //DrawMatrix(m1, g, 10, 10 + 7 * offset);
            //// Matrix multiplication - MatrixOrder.Prepend: 
            //m1 = new Matrix(1, 2, 3, 4, 0, 1);
            //m1.Multiply(m2, MatrixOrder.Prepend);
            //g.DrawString("Resultant Matrix - Prepend:", this.Font,
            //Brushes.Black, 10, 10 + 8 * offset);
            //DrawMatrix(m1, g, 10, 10 + 9 * offset); 
        }
        private void DrawMatrix(Matrix m, Graphics g, int x, int y)
        {
            string str = null;
            for (int i = 0; i < m.Elements.Length; i++)
            {
                str += m.Elements[i].ToString();
                str += ", ";
            }
            g.DrawString(str, this.Font, Brushes.Black, x, y);
        } 
        private void DrawRectangle(Graphics g)
        {
            Pen drawingPen = new Pen(Color.Red, 30);
           
            // Draw a rectangle at a fixed position.
            g.DrawRectangle(drawingPen, new Rectangle(20, 20, 20, 20));
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            imageSliderBox3.Frames.Clear();
            this.imageSliderBox3.Frames.Add(new ImageFrame() { Effect = TransitionEffect.CircleOut, TransitionImage = Image.FromFile("img\\img3.jpg") });
            this.imageSliderBox3.Frames.Add(new ImageFrame() { Effect = TransitionEffect.RotateClockWise, TransitionImage = Image.FromFile("img\\img2.jpg") });
            this.imageSliderBox3.Frames.Add(new ImageFrame() { Effect = TransitionEffect.ScrollDown, TransitionImage = Image.FromFile("img\\img1.jpg") });
            this.imageSliderBox3.Frames.Add(new ImageFrame() { Effect = TransitionEffect.BarsDown, TransitionImage = Image.FromFile("img\\img4.jpg") });
            this.imageSliderBox3.Frames.Add(new ImageFrame() { Effect = TransitionEffect.Star, TransitionImage = Image.FromFile("img\\img5.jpg") });
            this.imageSliderBox3.Frames.Add(new ImageFrame() { Effect = TransitionEffect.BarsDown2, TransitionImage = Image.FromFile("img\\img6.jpg") });
            imageSliderBox3.Start();
        }
       
    }
}
