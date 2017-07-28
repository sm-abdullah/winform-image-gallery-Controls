using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ImageControls.ImageSilder.Transitions
{
    public class CircleOut : ITransition
    {
        #region Private
        private int radius;
        private Timer timer;
        #endregion


        public void Start()
        {
            timer.Interval = 10;
            timer.Start();
        }

        public CircleOut()
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
            graphics.DrawImage(foregroudnImage,clientRectangle);
            int max =  getMax(clientRectangle.Height, clientRectangle.Width);

            int top = 0;
            int left = 0;
            if (clientRectangle.Width > clientRectangle.Height)
            {
                top = (clientRectangle.Width - clientRectangle.Height) / 2;
                left = 0;
            }
            else
            {
                left = (clientRectangle.Height - clientRectangle.Width)/ 2;
                top = 0;
            }
           
                using (var brush = new TextureBrush(backgroundImage, clientRectangle))
                {
                    var rect = new Rectangle(-left + radius, -top + radius, max - radius * 2, max - radius * 2);
                    graphics.FillEllipse(brush, rect);
                    if (radius >= (max / 2))
                    {
                        graphics.DrawImage(foregroudnImage, clientRectangle);
                        if (Finished != null)
                        {
                            Finished.Invoke(this, EventArgs.Empty);
                            timer.Enabled = false;
                            timer.Dispose();

                        }
                    }
                }


        }
        private int getMax(int i, int j) 
        {
            if (i > j)
            {
                return i;
            }
            else
            {
                return j;
            }
        }
       
    }
}
