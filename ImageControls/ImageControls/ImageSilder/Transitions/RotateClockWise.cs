using System;
using System.Collections.Generic;
using System.Diagnostics;
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
            size += 0.1f;

            var percentage = (size / 10) * 100;
            float angle = (720 / 100) * percentage;
            if (angle > 720)
            {
                angle = 720;
            }
            
            var rec = new Rectangle((clientRectangle.Width / 2) - (int)(width/2),(clientRectangle.Height / 2) -(int)(height/2), (int) width, (int)height);
            m.RotateAt(angle, new PointF(clientRectangle.Left + (clientRectangle.Width / 2), clientRectangle.Top + (clientRectangle.Height / 2) ));
            graphics.DrawImage(backgroundImage, clientRectangle);
            graphics.Transform = m;

            var v = angle % 180;
            Debug.WriteLine(angle + "-----------" + v);
            graphics.DrawImage(foregroudnImage, rec);
            if (size >= 10 &&  angle >= 720)
            {
                if (Finished != null)
                {
                    
                    timer.Stop();
                    Finished.Invoke(this, EventArgs.Empty);
                }
            }
        }
        void timer_Elapsed(object sender, ElapsedEventArgs e)
        {

          
            if (Changed != null)
            {
                Changed.Invoke(this, EventArgs.Empty);
            }

        }

        public void Start()
        {
            startTime = DateTime.Now;
            timer.Interval = 0.1;
            timer.Start();
        }
    }
}
