using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ImageControls
{
   
       public partial class ThumbnailBox : UserControl
        {
            private ThumbTextPosition _ThumbTextPosition;
            private bool isSet;

            public ThumbTextPosition ThumbTextPosition
            {
                get { return _ThumbTextPosition; }
                set
                {
                    _ThumbTextPosition = value;
                    if (_ThumbTextPosition == ImageControls.ThumbTextPosition.Top)
                    {
                        panel1.Dock = DockStyle.Top;
                    }
                    else
                    {
                        panel1.Dock = DockStyle.Bottom;
                    }
                }
            }

            public bool IsSelected
            {
                get { return isSet; }
                set
                {
                    isSet = value;
                    if (isSet)
                    {
                        thumbLabel.ForeColor = Color.White;
                        this.BackColor = Color.DarkBlue;
                    }
                    else
                    {
                        this.BackColor = Color.Gray;
                        thumbLabel.ForeColor = Color.Black;
                    }
                }
            }

            public string Caption
            {
                get { return thumbLabel.Text; }
                set { thumbLabel.Text = value; thumbLabel.Left = (this.Width - thumbLabel.Width) / 2; }
            }

            public Image Thumb
            {
                get { return ThumbPictureBox.BackgroundImage; }
                set
                {
                    ThumbPictureBox.BackgroundImage = value;
                }
            }

            public ThumbnailBox()
            {
                _ThumbTextPosition = ThumbTextPosition.Top;
                InitializeComponent();
                ThumbPictureBox.BackgroundImageLayout = ImageLayout.Stretch;
                this.Resize += ThumbnailBox_Resize;
                this.Load += ThumbnailBox_Load;
                thumbLabel.Left = (this.Width - thumbLabel.Width) / 2;

            }

            void ThumbnailBox_Load(object sender, EventArgs e)
            {

                adjust();
            }
            protected override void OnPaint(PaintEventArgs e)
            {
                base.OnPaint(e);
                //if (IsSelected)
                // e.Graphics.DrawRectangle(new Pen(Color.Blue, 2), new Rectangle(this.Left - 2, this.Top - 2, this.Width - 4, this.Height - 2));
            }



            void ThumbnailBox_Resize(object sender, EventArgs e)
            {
                adjust();
            }
            private void adjust()
            {
                thumbLabel.Left = (this.panel1.Width - thumbLabel.Width) / 2;
                panel2.Height = this.Height - 6;
                panel2.Width = this.Width - 6;
                panel2.Left = (this.Width - this.panel2.Width) / 2;
                panel2.Top = (this.Height - panel2.Height) / 2;
            }
        }
    
}
