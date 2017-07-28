using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ImageControls.ImageSilder.Transitions;

namespace ImageControls.ImageSilder
{
    public partial class ImageSliderBox : UserControl
    {
        #region Private

        List<ImageFrame> _Frames;
        private bool _loop;
        private bool _autoStart;
       
        private Image backgroundImage;
        private Image ForegroundImage;
        private ITransition Transition;
        private int _index=0;
        #endregion
        #region Properties
        //[Browsable(true)]
        
        //[Description("Images to Cycle Through")]

        public List<ImageFrame> Frames;
        //{ 
        //    get{return _Frames;}
        //    set { _Frames = value; }
        //}
        [Browsable(true)]
        [Description("Start again if ends")]
        public bool Loop
        {
            get { return _loop; }
            set { _loop = value; }
        }
        [Browsable(true)]
        [Description("Set True if auto Start")]
        public bool AutoStart
        {
            get { return _autoStart; }
            set { _autoStart = value; }
        }
        #endregion

        public ImageSliderBox()
        {

            InitializeComponent();
            _Frames = new List<ImageFrame>();
          //  SetStyle(ControlStyles.OptimizedDoubleBuffer | ControlStyles.SupportsTransparentBackColor | ControlStyles.UserPaint, true);
          //  SetStyle(ControlStyles.Selectable, false);
          //  UpdateStyles();
            this.DoubleBuffered = true;
            base.TabStop = false;
            base.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            Frames = _Frames;
        }

        #region Utility
        protected override void OnPaint(PaintEventArgs e)
        {
            if (Transition != null && this.backgroundImage!=null && this.ForegroundImage !=null)
            {

                Transition.Draw(e.Graphics,this.ClientRectangle,this.backgroundImage,this.ForegroundImage);
            }
        }
        #endregion
        #region Methods
        public void Start() 
        {
           

            Next();
        }
        public void Next() 
        {
            if (_index >= _Frames.Count && _loop==true) 
            {
                _index = 0;
            }
            if (_Frames.Count > _index)
            {
                Image bmp = new Bitmap(this.Width, this.Height);
                if (_index == 0)
                {

                    this.DrawToBitmap((Bitmap)bmp, this.ClientRectangle);
                    this.backgroundImage = bmp;
                }
                else
                {
                    bmp = _Frames[_index - 1].TransitionImage;
                }
                this.Transition = Utility.CreateTransition(_Frames[_index].Effect);
                this.ForegroundImage = Utility.ResizeImage(_Frames[_index].TransitionImage,this.ClientRectangle);
                this.backgroundImage = Utility.ResizeImage(bmp, this.ClientRectangle);
                this.Transition.Changed += Transition_Changed;
                this.Transition.Finished += Transition_Finished;
                this.Transition.Start();
                _index++;

            }
           
        }

        void Transition_Finished(object sender, EventArgs e)
        {
            this.Transition.Finished -= Transition_Finished;
            this.Transition.Changed -= Transition_Changed;
            Next();
        }
       
        void Transition_Changed(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                this.Invoke(new MethodInvoker(this.Invalidate));
            }
            else
            {
                this.Invalidate();
            }
        }
        #endregion
    }
}
