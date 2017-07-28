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
    public class RotateClockWise : ITransition
    {
        public event EventHandler Changed;
        public event EventHandler Finished;
        private Timer timer;
        private TimeSpan speed = TimeSpan.FromSeconds(3);
        private DateTime startTime = DateTime.MinValue;
        private float angle = 0;
        private float size = 1;
        public RotateClockWise()
        {
            
            timer = new Timer();
            timer.Elapsed += timer_Elapsed;
        }
        public void Draw(Graphics graphics, Rectangle clientRectangle, Image backgroundImage, Image foregroudnImage)
        {
            Matrix m = new Matrix();
            var height =  (foregroudnImage.Height / 10) * size;
            var width = (foregroudnImage.Width / 10) * size;
            size += 0.05f;
            
            var rec = new Rectangle((clientRectangle.Width / 2) - (int)(width/2),(clientRectangle.Height / 2) -(int)(height/2), (int) width, (int)height);
            m.RotateAt(angle, new PointF(clientRectangle.Left + (clientRectangle.Width / 2), clientRectangle.Top + (clientRectangle.Height / 2) ));
            graphics.DrawImage(backgroundImage, clientRectangle);
            graphics.Transform = m;
          
            graphics.DrawImage(foregroudnImage, rec);
            if (rec.Height > foregroudnImage.Height && rec.Width > foregroudnImage.Width)
            {
                if (Finished != null)
                {
                    Finished.Invoke(this, EventArgs.Empty);
                }
            }
        }
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {

            angle++;
            if (Changed != null)
            {
                Changed.Invoke(this, EventArgs.Empty);
            }

        }

        public void Start()
        {
            startTime = DateTime.Now;
            timer.Interval = 2;
            timer.Start();
        }
    }
}
