using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.ObjectModel;
namespace ImageControls
{
    public partial class ImageAccordion : UserControl
    {
        private int index = 0;
        
        public ImageAccordion()
        {
            InitializeComponent();
            ThumbnailsBox = new List<ThumbnailBox>();
        }

        public void Add(ThumbnailBox thumbnailBox) 
        {
            thumbnailBox.Width = this.Height;
            thumbnailBox.Height = this.Height - 10;
            this.ThumbnailsBox.Add(thumbnailBox);
            this.flowLayoutPanel1.Controls.Add(thumbnailBox);

        }
        public void Remove(ThumbnailBox thumbnailBox)
        {
            this.ThumbnailsBox.Remove(thumbnailBox);
            flowLayoutPanel1.Controls.Remove(thumbnailBox);
            
        }
        public void RemoveAll(Predicate<ThumbnailBox> match)
        {
            this.ThumbnailsBox.RemoveAll(match);
        }
        public void RemoveAt(int index)
        {
            this.flowLayoutPanel1.Controls.Remove(ThumbnailsBox[index]);
            this.ThumbnailsBox.RemoveAt(index);
        }
        protected override void OnLoad(EventArgs e)
        {
         
            
            base.OnLoad(e);

            this.flowLayoutPanel1.Left = accordionButton1.Left + accordionButton1.Width;
            this.flowLayoutPanel1.Top = 0;
            this.flowLayoutPanel1.Width = accordionButton2.Left - accordionButton1.Width;
            this.flowLayoutPanel1.SendToBack();
            this.flowLayoutPanel1.Height = this.Height + 15;
            if (ThumbnailsBox != null && ThumbnailsBox.Count > 0)
            {
                ThumbnailsBox.ForEach(item =>
                {
                   

                });
                this.flowLayoutPanel1.Controls.AddRange(ThumbnailsBox.ToArray());
                ThumbnailsBox.First().IsSelected = true;
            }
        }

        void Thumbnails_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            validateButtonState();
        }
     
      
       

        private void accordionButton2_Click_1(object sender, EventArgs e)
        {
            if (ThumbnailsBox.Count > 0)
            {
                if (index < ThumbnailsBox.Count - 1) index++;
                ThumbnailsBox.ForEach(item => item.IsSelected = false);
                ThumbnailsBox[index].IsSelected = true;
                this.flowLayoutPanel1.ScrollControlIntoView(ThumbnailsBox[index]);
                validateButtonState();
            }
           
        }
        private void validateButtonState() 
        {
            if (index == ThumbnailsBox.Count - 1)
            {
                accordionButton2.IsEnable = false;
            }
            else
            {
                accordionButton2.IsEnable = true;
            }
            if (index == 0)
            {
                accordionButton1.IsEnable = false;
            }
            else
            {
                accordionButton1.IsEnable = true;
            }
        }
        private void accordionButton1_Click(object sender, EventArgs e)
        {
            if (ThumbnailsBox.Count > 0)
            {
                if (index > 0) index--;
                ThumbnailsBox.ForEach(item => item.IsSelected = false);
                ThumbnailsBox[index].IsSelected = true;
                this.flowLayoutPanel1.ScrollControlIntoView(ThumbnailsBox[index]);
                validateButtonState();
            }
        }

        private List<ThumbnailBox> ThumbnailsBox;
  
    }
}
