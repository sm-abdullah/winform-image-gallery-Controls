using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageControls
{
  
    
    public class Thumbnail
    {
         public Image Image { get; set; }
         public string Text { get; set; }
         public Thumbnail(string text,Image image) 
         {
             this.Image = image;
             this.Text = text;
         }
         private Thumbnail() 
         { 
         
         }
    }
}
