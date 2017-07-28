using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ImageControls.ImageSilder.Transitions
{
    public class Star : ITransition
    {
        #region Private
        private int radius;
        private Timer timer;
        #endregion


        public void Start()
        {
            timer.Interval = 2;
            timer.Start();
        }

        public Star()
        {
            radius = 0;
            timer = new Timer();
            timer.Elapsed += timer_Elapsed;

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            radius++;
            if (Changed != null)
            {
                Changed.Invoke(this, EventArgs.Empty);
            }
        }
        #region Properties
        public event EventHandler Finished;
        public event EventHandler Changed;
        #endregion




        private void DrawStar(Graphics g, Brush brush,  float r, float xc, float yc)
        {
            // r: determines the size of the star. 
            // xc, yc: determine the location of the star. 
            float sin36 = (float)Math.Sin(36.0 * Math.PI / 180.0);
            float sin72 = (float)Math.Sin(72.0 * Math.PI / 180.0);
            float cos36 = (float)Math.Cos(36.0 * Math.PI / 180.0);
            float cos72 = (float)Math.Cos(72.0 * Math.PI / 180.0);
            float r1 = r * cos72 / cos36;
            // Fill the star: 
            PointF[] pts = new PointF[10];
            pts[0] = new PointF(xc, yc - r);
            pts[1] = new PointF(xc + r1 * sin36, yc - r1 * cos36);
            pts[2] = new PointF(xc + r * sin72, yc - r * cos72);
            pts[3] = new PointF(xc + r1 * sin72, yc + r1 * cos72);
            pts[4] = new PointF(xc + r * sin36, yc + r * cos36);
            pts[5] = new PointF(xc, yc + r1);
            pts[6] = new PointF(xc - r * sin36, yc + r * cos36);
            pts[7] = new PointF(xc - r1 * sin72, yc + r1 * cos72);
            pts[8] = new PointF(xc - r * sin72, yc - r * cos72);
            pts[9] = new PointF(xc - r1 * sin36, yc - r1 * cos36);
            g.FillPolygon(brush, pts);
        } 


        public void Draw(Graphics graphics, Rectangle clientRectangle, Image backgroundImage, Image foregroudnImage)
        {
                graphics.DrawImage(backgroundImage, clientRectangle);
                TextureBrush brush = new TextureBrush(foregroudnImage, clientRectangle);
                DrawStar(graphics, brush, radius, clientRectangle.Width / 2, clientRectangle.Height / 2);
                if (radius > clientRectangle.Width + 100 && radius > clientRectangle.Height + 100)
                {
                    if (Finished != null)
                    {
                        Finished.Invoke(this, EventArgs.Empty);
                    }
                }
            
        }
    }
}
