using System.Drawing.Drawing2D;

namespace MovSoft.Controls
{
    public class ToggleButton : CheckBox
    {
        //Fields
        private Color onBackColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;
        private Color focusToggleColor = Color.Gold;

        //Properties
        public Color OnBackColor
        {
            get
            {
                return onBackColor;
            }
            set
            {
                onBackColor = value;
                Invalidate();
            }
        }
        public Color OnToggleColor
        {
            get
            {
                return onToggleColor;
            }
            set
            {
                onToggleColor = value;
                Invalidate();
            }
        }
        public Color OffBackColor
        {
            get
            {
                return offBackColor;
            }
            set
            {
                offBackColor = value;
                Invalidate();
            }
        }
        public Color OffToggleColor
        {
            get
            {
                return offToggleColor;
            }
            set
            {
                offToggleColor = value;
                Invalidate();
            }
        }
        public Color FocusToggleColor
        {
            get
            {
                return focusToggleColor;
            }
            set
            {
                focusToggleColor = value;
                Invalidate();
            }
        }


        public override string Text
        {
            get
            {
                return base.Text;
            }
            set
            {
                
            }
        }

        //Constructor
        public ToggleButton()
        {
            MinimumSize = new Size(45, 22);
        }

        //Methods
        private GraphicsPath GetFigurePath()
        {
            int arcSize = Height - 1;
            Rectangle leftArc = new(0, 0, arcSize, arcSize);
            Rectangle rightArc = new(Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path;
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(Parent.BackColor);
            
            if(Checked) //On
            {
                //Draw the control surface
                pevent.Graphics.FillPath(new SolidBrush(onBackColor), GetFigurePath());
                //Draw the toggle
                if (Focused)
                {
                    pevent.Graphics.FillEllipse(new SolidBrush(focusToggleColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
                }
                else
                {
                    pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(Width - Height + 1, 2, toggleSize, toggleSize));
                }

            }
            else //Off
            {
                //Draw the control surface
                pevent.Graphics.FillPath(new SolidBrush(offBackColor), GetFigurePath());
                //Draw the toggle
                if (Focused)
                {
                    pevent.Graphics.FillEllipse(new SolidBrush(focusToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
                }
                else
                {
                    pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
                }
            }

            
        }
    }
}
