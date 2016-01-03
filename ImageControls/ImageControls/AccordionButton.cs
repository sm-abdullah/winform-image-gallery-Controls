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
        private Color _normalColor = Color.Silver;
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
                //if Mouse button up Set it To False
                //because we will paint the button down state on behavlf of this.
                isButtonDown = false;
            }
            base.OnMouseUp(e);
        }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            if (e.Button == System.Windows.Forms.MouseButtons.Left)
            {
                //if mouse button down set True
                isButtonDown = true;
            }
            base.OnMouseDown(e);
        }
        protected override void OnMouseEnter(EventArgs e)
        {
            //if mouse enters we say hover true
            isHover = true;
            base.OnMouseEnter(e);

        }
        protected override void OnMouseLeave(EventArgs e)
        {
            //if mouse leave we say hover false
            base.OnMouseLeave(e);
            isHover = false;
        }
        protected override void OnPaint(PaintEventArgs e)
        {
            //In order to make play Icon center
            //get the Top ,left position asuming button height width is 30 pixels
            var top = (this.Height - 30) / 2;
            var left = (this.Width - 30) / 2; 
            // it will store polygone points which draw the triangle
            Point[] Active = null;
            Point[] ActiveOuter = null; //it is outer border 
            //default color 
            Color color = Color.Purple;
            //if button is active and enable true
            if (isHover && _isEnable)
            {
                //if  button is down
                if (isButtonDown)
                {  
                    //set down color
                    color = DownColor;
                }
                else
                {
                    //set Hover Color
                    color = HoverColor;
                }
            }
            else
            {
                //if normal state set silver color
                color = _normalColor;
            }


            LinearGradientBrush linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);


            if (Face == AccodionButtonFace.Left)
            {
                //get polygone i.e triagnle with direction to Left
                Active = new Point[] { new Point(left + 31, top - 1), new Point(left + 31, top + 31), new Point(left - 1, top + 15) };
                //draw outer line
                ActiveOuter = new Point[] { new Point(left + 30, top), new Point(left + 30, top + 30), new Point(left, top + 15) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);

            }
            else if (Face == AccodionButtonFace.Right)
            {

                //get polygone i.e triagnle with direction to right
                Active = new Point[] { new Point(left, top), new Point(left, top + 30), new Point(left + 30, top + 15) };
                ActiveOuter = new Point[] { new Point(left - 1, top - 1), new Point(left - 1, top + 31), new Point(left + 31, top + 15) };
                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 180f, true);
                linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
            }
            else if (Face == AccodionButtonFace.Down)
            {
                //get polygone i.e triagnle with direction to  down
                Active = new Point[] { new Point(left, top), new Point(left + 15, top + 29), new Point(left + 30, top) };
                ActiveOuter = new Point[] { new Point(left - 1, top - 1), new Point(left + 15, top + 30), new Point(left + 31, top - 1) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 90f, true);
                linearGradientBrush.SetBlendTriangularShape(0.1f, 0.8f);
            }
            else if (Face == AccodionButtonFace.Up)
            {
                //get polygone i.e triagnle with direction to up
                Active = new Point[] { new Point(left + 2, top + 29), new Point(left + 15, top + 2), new Point(left + 29, top + 29) };
                ActiveOuter = new Point[] { new Point(left, top + 30), new Point(left + 15, top), new Point(left + 30, top + 30) };

                linearGradientBrush = new LinearGradientBrush(this.ClientRectangle, color, Color.White, 90f, true);
                linearGradientBrush.SetBlendTriangularShape(0.9f, 0.8f);
            }
            //draw gradiant background
            e.Graphics.FillRectangle(linearGradientBrush, this.ClientRectangle);
            e.Graphics.DrawRectangle(Pens.Black, new Rectangle(0, 0, this.ClientRectangle.Width - 1, this.ClientRectangle.Height - 1));
            linearGradientBrush.Dispose();

            //now paint the polygon 
            using (LinearGradientBrush brush = new LinearGradientBrush(new Point(left, top), new Point(left + 30, top + 30), Color.FromArgb(255, 90, 90, 90), color))
            {
                e.Graphics.DrawPolygon(new Pen(Brushes.White, 1f), ActiveOuter);
                e.Graphics.FillPolygon(brush, Active);
            }


        }
        #endregion
    }

}
