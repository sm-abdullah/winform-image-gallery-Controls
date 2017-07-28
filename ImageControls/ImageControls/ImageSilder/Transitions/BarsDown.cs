using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Timers;
namespace ImageControls.ImageSilder.Transitions
{
    public class BarsDown : ITransition
    {
        #region Private
        private int barHeight;
        private int barCount = 20;
        private Timer timer;
        #endregion


        public void Start()
        {
            timer.Interval = 40;
            timer.Start();
        }

        public BarsDown()
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
                int left = (clientRectangle.Width / 2);
                int top = (clientRectangle.Height / 2);
                using (var brush = new TextureBrush(foregroudnImage, clientRectangle))
                {
                    var height = clientRectangle.Height % barCount == 0 ? clientRectangle.Height / barCount : (clientRectangle.Height / barCount) + 1;
                    
                    int heightFactor= 0 ;
                    var rects = new Rectangle[barCount];
                    for (int i = 0; i < barCount; i++)
                    {
                        rects[i] = new Rectangle(0, heightFactor * height, clientRectangle.Width, barHeight);
                        heightFactor++;
                       
                    }
                    graphics.FillRectangles(brush, rects);
                    if (barHeight > height) 
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
