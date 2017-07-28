using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ImageControls.ImageSilder.Transitions
{
    public class ScrollDown : ITransition
    {
        #region Private
        private int shutterPosition;
        
        private Timer timer;
        private TimeSpan speed = TimeSpan.FromSeconds(3);
        private DateTime startTime = DateTime.MinValue;
        #endregion


        public void Start()
        {
            startTime = DateTime.Now;
            timer.Interval = 1;
            timer.Start();
        }

        public ScrollDown()
        {
            shutterPosition = 0;
            timer = new Timer();
            timer.Elapsed += timer_Elapsed;

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            shutterPosition++;
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
            try
            {

                graphics.DrawImage(backgroundImage, clientRectangle);
                
                using (var brush = new TextureBrush(foregroudnImage, clientRectangle))
                {
                    var rect = new Rectangle(0, 0, clientRectangle.Width, shutterPosition);
                    graphics.FillRectangle(brush, rect);
                    if (shutterPosition > clientRectangle.Height)
                    {
                        if (this.Finished != null)
                        {
                            Finished.Invoke(this, EventArgs.Empty);
                        }
                    }
                }


            }
            catch (Exception exception)
            {

            }


        }
    }
}
