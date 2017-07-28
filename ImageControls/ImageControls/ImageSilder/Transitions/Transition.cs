using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageControls.ImageSilder.Transitions
{
    public interface ITransition
    {
        event EventHandler Finished;
        event EventHandler Changed;
        void Start();
        void Draw(Graphics graphics,Rectangle clientRectangle, Image backgroundImage, Image foregroudnImage);
        
    }
}
