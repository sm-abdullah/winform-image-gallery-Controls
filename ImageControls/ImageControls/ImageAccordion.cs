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
        #region Privates

        private int indexCurrent = 0;
        private List<ThumbnailBox> ThumbnailsBox;
        #endregion
        #region Public Properties
        //create a delegate for event to change Index 
        public delegate void ThumbnailChangedDelegate(int OldIndex, int NewIndex, Image currentImage,string Text);
        [Browsable(true)]
        [Category("Accordiong")]
        [Description("Event will be Raised User change the Thumbnail")]
        public event ThumbnailChangedDelegate ThumbnailChanged;

        #endregion
       
        #region Utility Functions
        private void thumbnailBox_Select(ThumbnailBox thumbnailBox)
        {
            var newIndex = this.ThumbnailsBox.IndexOf(thumbnailBox);
            SelectThumnail(newIndex);
        }
        protected override void OnLoad(EventArgs e)
        {


            base.OnLoad(e);
            ResizePanel();

            if (ThumbnailsBox != null && ThumbnailsBox.Count > 0)
            {
                this.flowLayoutPanel1.Controls.AddRange(ThumbnailsBox.ToArray());
                ThumbnailsBox.First().IsSelected = true;
            }
        }

        private void ResizePanel()
        {
            this.flowLayoutPanel1.Left = leftButton.Left + leftButton.Width;
            this.flowLayoutPanel1.Top = 0;
            this.flowLayoutPanel1.Width = rightButton.Left - leftButton.Width;
            this.flowLayoutPanel1.SendToBack();
            this.flowLayoutPanel1.Height = this.Height + 15;
        }
        private void rightButton_Click(object sender, EventArgs e)
        {
            if (ThumbnailsBox.Count > 0 && indexCurrent < ThumbnailsBox.Count - 1)
            {
                SelectThumnail(indexCurrent + 1);
            }
        }

        private void validateButtonState()
        {
            if (indexCurrent == ThumbnailsBox.Count - 1)
            {
                rightButton.IsEnable = false;
            }
            else
            {
                rightButton.IsEnable = true;
            }
            if (indexCurrent == 0)
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
            if (ThumbnailsBox.Count > 1 && indexCurrent > 0)
            {
                SelectThumnail(indexCurrent - 1);
            }

        }
        private void ImageAccordion_Resize(object sender, EventArgs e)
        {
            ResizePanel();
        }
        
        #endregion

        public ImageAccordion()
        {
            InitializeComponent();
            ThumbnailsBox = new List<ThumbnailBox>();
        }
        #region Public Methods

        public void Add(ThumbnailBox thumbnailBox) 
        {
            thumbnailBox.Width = this.Height;
            thumbnailBox.Height = this.Height - 10;
            this.ThumbnailsBox.Add(thumbnailBox);
            
            this.flowLayoutPanel1.Controls.Add(thumbnailBox);
            validateButtonState();
            thumbnailBox.Selected += thumbnailBox_Select;

        }

        public void Remove(ThumbnailBox thumbnailBox)
        {
            this.ThumbnailsBox.Remove(thumbnailBox);
            flowLayoutPanel1.Controls.Remove(thumbnailBox);
            thumbnailBox.Selected -= thumbnailBox_Select;
            validateButtonState();

            
        }
      
        public void RemoveAt(int index)
        {
            ThumbnailsBox[index].Selected -= thumbnailBox_Select;
            this.flowLayoutPanel1.Controls.Remove(ThumbnailsBox[index]);
            this.ThumbnailsBox.RemoveAt(index);
            
            validateButtonState();
        }
     
        public void SelectThumnail(int index)
        {
            
                if (ThumbnailChanged != null)
                {
                    ThumbnailChanged(indexCurrent, index, ThumbnailsBox[index].Thumb, ThumbnailsBox[index].Caption);
                }
                
            
            ThumbnailsBox.ForEach(item => item.IsSelected = false);
            ThumbnailsBox[index].IsSelected = true;
            this.flowLayoutPanel1.ScrollControlIntoView(ThumbnailsBox[index]);
            indexCurrent = index;
            validateButtonState();
           
        }

        #endregion
     

      
  
    }
}
