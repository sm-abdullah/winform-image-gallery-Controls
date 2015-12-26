using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace ImageControls
{
  
        partial class AccordionButton : Button
        {

            bool isHover = false;
            private bool _isEnable = true;
            public bool IsEnable
            {
                get
                {
                    return _isEnable;
                }
                set
                {
                    _isEnable = value;
                }
            }
            //public Image SelectedImage
            //{


            //}
            private bool isButtonDown = false;
            [Browsable(true)]
            public bool IsLeft { get; set; }

            public AccordionButton()
            {
                IsLeft = false;
                InitializeComponent();

            }
            protected override void OnMouseUp(MouseEventArgs e)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    isButtonDown = false;
                }
                base.OnMouseUp(e);
            }
            protected override void OnMouseDown(MouseEventArgs e)
            {
                if (e.Button == System.Windows.Forms.MouseButtons.Left)
                {
                    isButtonDown = true;
                }
                base.OnMouseDown(e);
            }



            protected override void OnMouseEnter(EventArgs e)
            {
                isHover = true;
                base.OnMouseEnter(e);

            }
            protected override void OnMouseLeave(EventArgs e)
            {
                base.OnMouseLeave(e);
                isHover = false;
            }
            protected override void OnPaint(PaintEventArgs e)
            {

                //   e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;

                var height = (this.Height - 30) / 2;
                var width = (this.Width - 30) / 2;
                Point[] Left = new Point[] { new Point(width, height), new Point(width, height + 30), new Point(width + 30, height + 15) };
                Point[] LeftOuter = new Point[] { new Point(width - 1, height - 1), new Point(width - 1, height + 31), new Point(width + 31, height + 15) };
                Point[] RightOuter = new Point[] { new Point(width + 31, height - 1), new Point(width + 31, height + 31), new Point(width - 1, height + 15) };

                Point[] Right = new Point[] { new Point(width + 30, height), new Point(width + 30, height + 30), new Point(width, height + 15) };
                Point[] Active = Left;
                Point[] ActiveOuter = LeftOuter;
                if (!IsLeft)
                {
                    Active = Right;
                    ActiveOuter = RightOuter;
                }

                Color color = Color.Purple;
                if (isHover && _isEnable)
                {

                    if (isButtonDown)
                    {
                        color = Color.Red;
                    }
                    else
                    {
                        color = Color.Orange;
                    }

                }
                else
                {
                    color = Color.Gray;
                }


                LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                if (!IsLeft)
                {
                    linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);
                }
                else
                {
                    linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
                }
                e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
                e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1));
                linearGradientBrush.Dispose();

                // if(!isHover)
                {
                    using (LinearGradientBrush brush = new LinearGradientBrush(new Point(width, height), new Point(width + 30, height + 30), Color.FromArgb(255, 90, 90, 90), color))
                    {
                        e.Graphics.DrawPolygon(new Pen(Brushes.White, 1f), ActiveOuter);
                        e.Graphics.FillPolygon(brush, Active);
                    }
                }


                //  e.Graphics.FillPolygon(brush, UP);

            }
        }
    
}
