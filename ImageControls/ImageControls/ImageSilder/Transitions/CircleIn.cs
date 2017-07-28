using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
using System.Drawing.Drawing2D;
namespace ImageControls.ImageSilder.Transitions
{
    public class CircleIn : ITransition
    {
        #region Private
        private int radius;
        private Timer timer;
        private TimeSpan speed;

        #endregion


        public void Start()
        {
            timer.Interval = 1;
            speed = TimeSpan.FromSeconds(1);

            timer.Start();
        }

        public CircleIn()
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
                int left = (clientRectangle.Width / 2);
                int top = (clientRectangle.Height / 2);
                using (var brush = new TextureBrush(foregroudnImage, clientRectangle))
                {
                    var rect = new Rectangle(left - radius, top - radius, 0 + radius * 2, 0 + radius * 2);
                    var points = new Point[]{ new Point(clientRectangle.X,clientRectangle.Y), new Point(clientRectangle.Width,clientRectangle.Y), new Point(clientRectangle.X,100) };
                    graphics.Transform = new Matrix(clientRectangle, points);
                    graphics.FillEllipse(brush, rect);
                    if (rect.Width > clientRectangle.Width + 200 && rect.Height > clientRectangle.Height + 200)
                    {

                        if (Finished != null)
                        {
                            Finished.Invoke(this, EventArgs.Empty);
                            timer.Enabled = false;
                            timer.Dispose();

                        }
                    }
                }
            



        }
    }
}
