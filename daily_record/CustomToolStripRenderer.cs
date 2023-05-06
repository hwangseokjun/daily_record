using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace daily_record
{
    public class CustomToolStripRenderer : ToolStripProfessionalRenderer
    {
        protected override void OnRenderButtonBackground(ToolStripItemRenderEventArgs e)
        {
            if (e.Item is ToolStripButton button)
            {
                var bounds = new Rectangle(Point.Empty, button.Size);

                if (button.Pressed || button.Checked)
                {
                    using (var brush = new SolidBrush(SystemColors.ControlDark))
                    {
                        e.Graphics.FillRectangle(brush, bounds);
                    }
                }
                else if (button.Selected)
                {
                    using (var brush = new SolidBrush(SystemColors.Control))
                    {
                        e.Graphics.FillRectangle(brush, bounds);
                    }
                }
                else
                {
                    base.OnRenderButtonBackground(e);
                }
            }
            else 
            {
                base.OnRenderButtonBackground(e);
            }
        }
    }
}
