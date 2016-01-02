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
        private Color _HoverColor;
        private Color _SelectedColor;

        #endregion
        #region Public Properties
        //create a delegate for event to change Index 
        public delegate void ThumbnailChangedDelegate(int OldIndex, int NewIndex, Thumbnail thumbnail);
        [Browsable(true)]
        [Category("Accordion")]
        [Description("Event will be Raised User change the Thumbnail")]
        public event ThumbnailChangedDelegate ThumbnailChanged;

        [Browsable(true)]
        [Category("Accordion")]
        [Description("Set the Hover Color of Thumbnail or Button")]
        public Color HoverColor
        {
            get{return _HoverColor;}
            set 
            {
                _HoverColor = value;
                 colorChanged(); 
            }
        }
        [Browsable(true)]
        [Category("Accordion")]
        [Description("Set the Selectd Color of Thumbnail Or When mouse Clicked over a button")]
        public Color SelectedColor
        {
            get{return _SelectedColor;}
            set
            {
                _SelectedColor = value;
                colorChanged();
            }
        }

        #endregion
       
        #region Utility Functions
        private void colorChanged() 
        {
            leftButton.DownColor = this.SelectedColor;
            leftButton.HoverColor = this.HoverColor;
            rightButton.DownColor = this.SelectedColor;
            rightButton.HoverColor = this.HoverColor;
            if (this.ThumbnailsBox != null)
            {
                this.ThumbnailsBox.ForEach(item =>
                {
                    item.HoverColor = this.HoverColor;
                    item.SelectedColor = this.SelectedColor;
                });
            }
        }
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

        public List<Thumbnail> Thumbnails
        {
            get
            {
                return ThumbnailsBox.Select(item => item.Thumbnail).ToList();
            }
        }

        public ImageAccordion()
        {
            InitializeComponent();
            HoverColor = Color.Purple;
            SelectedColor = Color.DarkBlue;
            ThumbnailsBox = new List<ThumbnailBox>();
           
        }
        #region Public Methods

        public void Add(Thumbnail thumbnail) 
        {
            var thumbnailBox = new ThumbnailBox();
            thumbnailBox.Width = this.Height;
            thumbnailBox.Height = this.Height - 10;
            this.ThumbnailsBox.Add(thumbnailBox);
            thumbnailBox.Thumbnail = thumbnail;
            this.flowLayoutPanel1.Controls.Add(thumbnailBox);
            validateButtonState();
            thumbnailBox.Selected += thumbnailBox_Select;

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
                    ThumbnailChanged(indexCurrent, index, ThumbnailsBox[index].Thumbnail);
                }
            ThumbnailsBox.ForEach(item => item.IsSelected = false);
            ThumbnailsBox[index].IsSelected = true;
            this.flowLayoutPanel1.ScrollControlIntoView(ThumbnailsBox[index]);
            indexCurrent = index;
            validateButtonState();
           
        }
        /// <summary>
        /// It will Select the Next Thumbnail or Move Next
        /// </summary>
        public void MoveNext() 
        { 
          var index = indexCurrent + 1;
          if (index > 0 && index < ThumbnailsBox.Count - 1) 
          {
              SelectThumnail(index);
          }
        }
        /// <summary>
        /// it will Select the Previous Thumbnail or Move Back
        /// </summary>
        public void MoveBack() 
        {
            var index = indexCurrent - 1;
            if (index > 0 && index < ThumbnailsBox.Count - 1)
            {
                SelectThumnail(index);
            }
        }

        #endregion
     

      
  
    }
}
