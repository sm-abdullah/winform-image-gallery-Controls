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

        

        public delegate void ThumbnailChangedDelegate(int OldIndex, int NewIndex, Image currentImage,string Text);
        public event ThumbnailChangedDelegate ThumbnailChanged;

        public Image Image { get { return this.ThumbnailsBox[index].BackgroundImage; } }

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
            validateButtonState();
            thumbnailBox.Select += thumbnailBox_Select;

        }

        void thumbnailBox_Select(ThumbnailBox thumbnailBox)
        {
            var newIndex  = this.ThumbnailsBox.IndexOf(thumbnailBox);
            ThumbnailsBox.ForEach(item => item.IsSelected = false);
            thumbnailBox.IsSelected = true;
            this.flowLayoutPanel1.ScrollControlIntoView(ThumbnailsBox[newIndex]);
            validateButtonState();
            if (ThumbnailChanged != null)
            {
                ThumbnailChanged(index, newIndex, thumbnailBox.Thumb, thumbnailBox.Caption);
            }
        }

       
        public void Remove(ThumbnailBox thumbnailBox)
        {
            this.ThumbnailsBox.Remove(thumbnailBox);
            flowLayoutPanel1.Controls.Remove(thumbnailBox);
            thumbnailBox.Select -= thumbnailBox_Select;
            validateButtonState();

            
        }
      
        public void RemoveAt(int index)
        {
            ThumbnailsBox[index].Select -= thumbnailBox_Select;
            this.flowLayoutPanel1.Controls.Remove(ThumbnailsBox[index]);
            this.ThumbnailsBox.RemoveAt(index);
            
            validateButtonState();
        }
        protected override void OnLoad(EventArgs e)
        {
         
            
            base.OnLoad(e);

            this.flowLayoutPanel1.Left = leftButton.Left + leftButton.Width;
            this.flowLayoutPanel1.Top = 0;
            this.flowLayoutPanel1.Width = rightButton.Left - leftButton.Width;
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

      
     
      
       

        private void rightButton_Click(object sender, EventArgs e)
        {

          
            
            if (ThumbnailsBox.Count > 0)
            {
                if (index < ThumbnailsBox.Count - 1)
                {
                    if (ThumbnailChanged != null)
                    {
                        ThumbnailChanged(index, index + 1, ThumbnailsBox[index + 1].Thumb,ThumbnailsBox[index+1].Caption);
                    }
                    index++;
                }
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
                rightButton.IsEnable = false;
            }
            else
            {
                rightButton.IsEnable = true;
            }
            if (index == 0)
            {
                leftButton.IsEnable = false;
            }
            else
            {
                leftButton.IsEnable = true;
            }
        }
        private void leftButton_Click(object sender, EventArgs e)
        {
            if (ThumbnailsBox.Count > 1)
            {
                if (index > 0)
                {
                    if (ThumbnailChanged != null)
                    {
                        ThumbnailChanged(index, index - 1, ThumbnailsBox[index - 1].Thumb, ThumbnailsBox[index - 1].Caption);
                    }
                    index--;
                }
                ThumbnailsBox.ForEach(item => item.IsSelected = false);
                ThumbnailsBox[index].IsSelected = true;
                this.flowLayoutPanel1.ScrollControlIntoView(ThumbnailsBox[index]);
                validateButtonState();
            }
           
        }

        private List<ThumbnailBox> ThumbnailsBox;
  
    }
}
