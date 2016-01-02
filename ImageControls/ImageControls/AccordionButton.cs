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

    internal partial class AccordionButton : Button
    {

        #region  Private 
        private bool isButtonDown = false;
        private AccodionButtonFace _face;
        private bool isHover = false;
        private bool _isEnable = true;
        #endregion

        #region Public 
        [Browsable(true)]
        [Category("AccordionButton")]
        [Description("Enable or Disable the button")]
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
        [Category("AccordionButton")]
        [Description("Set the Hover Color of Button")]
        public Color HoverColor
        {
            get;
            set;
        }
        [Browsable(true)]
        [Category("AccordionButton")]
        [Description("Set the Color When clicked on mouse")]
        public Color DownColor
        {
            get;
            set;
        }

        [Browsable(true)]
        [Category("AccordionButton")]
        [Description("Set the Button Face Direction")]
        public AccodionButtonFace Face
        {
            get { return _face; }
            set { _face = value; this.Invalidate(); }
        }
        #endregion

        public AccordionButton()
        {
            Face = AccodionButtonFace.Left;
            InitializeComponent();
            HoverColor = Color.Orange;
            DownColor = Color.DarkBlue;

        }
        #region Overrides
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
                    color = DownColor;
                }
                else
                {
                    color = HoverColor;
                }
            }
            else
            {
                color = Color.Gray;
            }
            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);


            if (Face == AccodionButtonFace.Left)
            {
                //get polygone i.e triagnle with direction to Left
                Active = new Point[] { new Point(width + 31, height - 1), new Point(width + 31, height + 31), new Point(width - 1, height + 15) };
                //draw outer line
                ActiveOuter = new Point[] { new Point(width + 30, height), new Point(width + 30, height + 30), new Point(width, height + 15) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);

            }
            else if (Face == AccodionButtonFace.Right)
            {

                //get polygone i.e triagnle with direction to right
                Active = new Point[] { new Point(width, height), new Point(width, height + 30), new Point(width + 30, height + 15) };
                ActiveOuter = new Point[] { new Point(width - 1, height - 1), new Point(width - 1, height + 31), new Point(width + 31, height + 15) };
                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
            }
            else if (Face == AccodionButtonFace.Down)
            {
                //get polygone i.e triagnle with direction to  down
                Active = new Point[] { new Point(width, height), new Point(width + 15, height + 29), new Point(width + 30, height) };
                ActiveOuter = new Point[] { new Point(width - 1, height - 1), new Point(width + 15, height + 30), new Point(width + 31, height - 1) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 90f, true);
                linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);
            }
            else if (Face == AccodionButtonFace.Up)
            {
                //get polygone i.e triagnle with direction to up
                Active = new Point[] { new Point(width + 2, height + 29), new Point(width + 15, height + 2), new Point(width + 29, height + 29) };
                ActiveOuter = new Point[] { new Point(width, height + 30), new Point(width + 15, height), new Point(width + 30, height + 30) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 90f, true);
                linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
            }
            //draw gradiant background
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1));
            linearGradientBrush.Dispose();

            //now paint the polygon 
            using (LinearGradientBrush brush = new LinearGradientBrush(new Point(width, height), new Point(width + 30, height + 30), Color.FromArgb(255, 90, 90, 90), color))
            {
                e.Graphics.DrawPolygon(new Pen(Brushes.White, 1f), ActiveOuter);
                e.Graphics.FillPolygon(brush, Active);
            }


        }
        #endregion
    }

}
