using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;

namespace ImageControls
{
    [Serializable]
    public class ThumbNail
    {
        
        public Image Thumb { get; set; }
        public string Text { get; set; }
    }
}
