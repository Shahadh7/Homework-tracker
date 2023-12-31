﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CustomControlsProject.CustomControls
{
    public class ToggleButton : CheckBox 
    {
        //Fields 
        private Color onBackroundColor = Color.MediumSlateBlue;
        private Color onToggleColor = Color.WhiteSmoke;
        private Color offBackroundColor = Color.Gray;
        private Color offToggleColor = Color.Gainsboro;

        //Properties
        [Category("Custom Properties")]
        public Color OnBackroundColor { get => onBackroundColor; set { onBackroundColor = value; this.Invalidate(); } }
        [Category("Custom Properties")]
        public Color OnToggleColor { get => onToggleColor; set { onToggleColor = value; this.Invalidate(); } }
        [Category("Custom Properties")]
        public Color OffBackroundColor { get => offBackroundColor; set { offBackroundColor = value; this.Invalidate();  } }
        [Category("Custom Properties")]
        public Color OffToggleColor { get => offToggleColor; set { offToggleColor = value; this.Invalidate(); } }


        public override string Text { get => base.Text; set { }  }

        //Constructor
        public ToggleButton()
        {
            this.MinimumSize = new Size(45, 22);

        }

        //Methods 
        private GraphicsPath GetFigurePath()
        {
            int arcSize = this.Height - 1;
            Rectangle leftArc = new Rectangle(0, 0, arcSize, arcSize);
            Rectangle rightArc = new Rectangle(this.Width - arcSize - 2, 0, arcSize, arcSize);

            GraphicsPath path = new GraphicsPath();
            path.StartFigure();
            path.AddArc(leftArc, 90, 180);
            path.AddArc(rightArc, 270, 180);
            path.CloseFigure();

            return path; 
        }

        protected override void OnPaint(PaintEventArgs pevent)
        {
            int toggleSize = this.Height - 5;
            pevent.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
            pevent.Graphics.Clear(this.Parent.BackColor);

            if(this.Checked) //ON state
            {
                //Draw the control surface
                pevent.Graphics.FillPath(new SolidBrush(onBackroundColor), GetFigurePath());
                // Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(onToggleColor), new Rectangle(this.Width - this.Height + 1, 2, toggleSize, toggleSize ));

            }
            else //OFF state
            {
                //Draw the control surface
                pevent.Graphics.FillPath(new SolidBrush(offBackroundColor), GetFigurePath());
                // Draw the toggle
                pevent.Graphics.FillEllipse(new SolidBrush(offToggleColor), new Rectangle(2, 2, toggleSize, toggleSize));
            }

        }

    }
}
