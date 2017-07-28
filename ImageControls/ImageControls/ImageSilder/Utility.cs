using ImageControls.ImageSilder.Transitions;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageControls.ImageSilder
{
    public static class Utility
    {
        public static ITransition CreateTransition(TransitionEffect Effect) 
        {
            ITransition transition = new CircleIn();
            if (Effect == TransitionEffect.CircleIn)
            {
                transition = new CircleIn();
            }
            else if (Effect == TransitionEffect.CircleOut)
            {
                transition = new CircleOut();
            }
            else if (Effect == TransitionEffect.Star)
            {
                transition = new Star();
            }
            else if (Effect == TransitionEffect.BarsDown)
            {
                transition = new BarsDown();
            }
            else if (Effect == TransitionEffect.ScrollDown)
            {
                transition = new ScrollDown();
            }
            else if (Effect == TransitionEffect.BarsDown2)
            {
                transition = new BarsDown2();
            }
            else if (Effect == TransitionEffect.InRect)
            {
                transition = new InRect();
            }
            else if (Effect == TransitionEffect.RotateClockWise)
            {
                transition = new RotateClockWise();
            }
            return transition;
        }
        public static Image ResizeImage(Image img , Rectangle rectangle)
        {
            Bitmap resizedImage = new Bitmap(rectangle.Width, rectangle.Height, System.Drawing.Imaging.PixelFormat.Format32bppArgb);
            using (var newGraphics = Graphics.FromImage(resizedImage))
            {
                newGraphics.DrawImage(img, rectangle);
            }
            return resizedImage;
        }

        public static double ElapsedMiliseconds(DateTime time) 
        {
           return (DateTime.Now - time).TotalMilliseconds;
        }
    }
}
