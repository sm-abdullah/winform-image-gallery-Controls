using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace ImageControls.ImageSilder.Transitions
{
    public class BarsDown2 : ITransition
    {
        #region Private
        private int barHeight;
        private const int barCount = 25;
        private Timer timer;
        Rectangle[] rects = new Rectangle[barCount];
        #endregion


        public void Start()
        {
            timer.Interval = 40;
            timer.Start();
           
            Random r = new Random();
            for (int i = 0; i < barCount; i++)
            {
                rects[i] = new Rectangle(0, r.Next(-50, 0), 0, barHeight);
            }
        }

        public BarsDown2()
        {
            barHeight = 0;
            timer = new Timer();
            timer.Elapsed += timer_Elapsed;

        }

        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {
            barHeight++;
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
                    var width = clientRectangle.Width % barCount == 0 ? clientRectangle.Width / barCount : (clientRectangle.Width / barCount) + 1;

                    
                    for (int i = 0; i < barCount; i++)
                    {
                        rects[i].Width = width ;
                        rects[i].X = i * width;
                        rects[i].Height = barHeight;
                        graphics.FillRectangle(brush, rects[i]);
                    
                    }
                    
                    
                    if (rects.ToList().All(item => item.Height+item.Y  > clientRectangle.Height))
                    {
                        graphics.DrawImage(foregroudnImage, clientRectangle);
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
