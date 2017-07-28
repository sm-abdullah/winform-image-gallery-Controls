using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ImageControls.ImageSilder
{
   

    [TypeConverter(typeof(ImageEntryConverter))]
    [Serializable]
    public class ImageFrame
    {
        public Image TransitionImage { get; set; }
        public TransitionEffect Effect { get; set; }
        
    }
    public class ImageEntryConverter : TypeConverter
    {
        public override bool GetPropertiesSupported(ITypeDescriptorContext context)
        {
            return true;
        }
        public override PropertyDescriptorCollection GetProperties(ITypeDescriptorContext context, object value, Attribute[] attributes)
        {
            return TypeDescriptor.GetProperties(typeof(ImageFrame));
        }
    }
}
