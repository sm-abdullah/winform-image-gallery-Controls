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

    public partial class AccordionButton : Button
    {


        private bool isButtonDown = false;
        private AccodionButtonFace _face;
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
        


        [Browsable(true)]
        public AccodionButtonFace Face
        {
            get { return _face; }
            set { _face = value; this.Invalidate(); }
        }

        public AccordionButton()
        {
            Face = AccodionButtonFace.Left;
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

            var height = (this.Height - 30) / 2;
            var width = (this.Width - 30) / 2;
            Point[] Active = null;
            Point[] ActiveOuter = null;
            Color color = Color.Purple;
            if (isHover && _isEnable)
            {
                if (isButtonDown)
                {
                    color = Color.DarkBlue;
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

            if (Face == AccodionButtonFace.Left)
            {

                Active = new Point[] { new Point(width + 31, height - 1), new Point(width + 31, height + 31), new Point(width - 1, height + 15) };
                ActiveOuter = new Point[] { new Point(width + 30, height), new Point(width + 30, height + 30), new Point(width, height + 15) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);

            }
            else if (Face == AccodionButtonFace.Right)
            {


                Active = new Point[] { new Point(width, height), new Point(width, height + 30), new Point(width + 30, height + 15) };
                ActiveOuter = new Point[] { new Point(width - 1, height - 1), new Point(width - 1, height + 31), new Point(width + 31, height + 15) };
                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
            }
            else if (Face == AccodionButtonFace.Down)
            {

                Active = new Point[] { new Point(width, height), new Point(width + 15, height + 29), new Point(width + 30, height) };
                ActiveOuter = new Point[] { new Point(width - 1, height - 1), new Point(width + 15, height + 30), new Point(width + 31, height - 1) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 90f, true);
                linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);
            }
            else if (Face == AccodionButtonFace.Up)
            {

                Active = new Point[] { new Point(width + 2, height + 29), new Point(width + 15, height + 2), new Point(width + 29, height + 29) };
                ActiveOuter = new Point[] { new Point(width, height + 30), new Point(width + 15, height), new Point(width + 30, height + 30) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 90f, true);
                linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
            }

            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1));
            linearGradientBrush.Dispose();


            using (LinearGradientBrush brush = new LinearGradientBrush(new Point(width, height), new Point(width + 30, height + 30), Color.FromArgb(255, 90, 90, 90), color))
            {
                e.Graphics.DrawPolygon(new Pen(Brushes.White, 1f), ActiveOuter);
                e.Graphics.FillPolygon(brush, Active);
            }


        }
    }

}
