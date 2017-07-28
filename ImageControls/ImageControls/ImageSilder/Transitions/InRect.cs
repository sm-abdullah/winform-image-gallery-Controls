using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Drawing.Drawing2D;
using System.Diagnostics;

namespace ImageControls.ImageSilder.Transitions
{
    public class InRect : ITransition
    {
        #region Private
        private int radius;
        private Timer timer;
        private TimeSpan speed;
        Stopwatch sp = new Stopwatch();
        #endregion


        public void Start()
        {
            timer.Interval = 1;
            speed = TimeSpan.FromSeconds(10);

            timer.Start();
            sp.Start();
        }

        public InRect()
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







        public void Draw(Graphics graphics, Rectangle clientRectangle, Image backgroundImage, Image foregroudnImage)
        {
           graphics.DrawImage(backgroundImage, clientRectangle);
           float maxSize = 1000;// (float)speed.TotalMilliseconds;
           float current = 500 ;//(float)sp.Elapsed.TotalMilliseconds;
            try
            {
               
                // Make a transformation to the PictureBox.
                RectangleF data_bounds = new RectangleF(0, 0, maxSize, maxSize);
                PointF[] points =
            {
                new PointF(0, 0),
                new PointF(clientRectangle.Width, 0),
                new PointF(0, clientRectangle.Height)
            };
                Matrix transformation = new Matrix(data_bounds, points);
                graphics.Transform = transformation;

                // Draw the histogram.
                using (Pen thin_pen = new Pen(Color.Black, 0))
                {
                    RectangleF rect = new RectangleF((maxSize-current)/2,(maxSize-current)/2, current, current);
                    using (Brush the_brush = new TextureBrush(foregroudnImage, data_bounds))
                    {
                        graphics.FillRectangle(the_brush, rect);
                       
                    }

                }

                if (sp.Elapsed.TotalMilliseconds > this.speed.TotalMilliseconds + 100)
                {
                    sp.Stop();
                }
            }
            
            
            catch (Exception ex)
            { 
            
            }
          
            //int left = (clientRectangle.Width / 2);
            //int top = (clientRectangle.Height / 2);
            //using (var brush = new TextureBrush(foregroudnImage, clientRectangle))
            //{
            //    var rect = new Rectangle(left - radius, top - radius, 0 + radius * 2, 0 + radius * 2);
            //    var points = new Point[] { new Point(clientRectangle.X, clientRectangle.Y), new Point(clientRectangle.Width, clientRectangle.Y), new Point(clientRectangle.X, 100) };
            //    graphics.Transform = new Matrix(clientRectangle, points);
            //    graphics.FillEllipse(brush, rect);
            //    if (rect.Width > clientRectangle.Width + 200 && rect.Height > clientRectangle.Height + 200)
            //    {

            //        if (Finished != null)
            //        {
            //            Finished.Invoke(this, EventArgs.Empty);
            //            timer.Enabled = false;
            //            timer.Dispose();

            //        }
            //    }
            //}




        }
    }
}
