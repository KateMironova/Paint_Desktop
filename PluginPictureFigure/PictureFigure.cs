using MakePaintGreatAgain.Controls;
using MakePaintGreatAgain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginPictureFigure
{
    public class PictureFigure : IPlugin
    {
        Button btnPicturePlugIn;
        Command command = new Command();
        public string Name
        {
            get { return "Picture figure"; }
        }

        public void Run(MenuStrip menu, ToolStrip stripMenu, ToolStripMenuItem item, GroupBox plug, GroupBox property)
        {

            if (item.CheckState == CheckState.Unchecked)
            {
                item.CheckState = CheckState.Checked;

                btnPicturePlugIn = new Button();
                btnPicturePlugIn.Enter += delegate { command.AddMenu(stripMenu, property); };
                btnPicturePlugIn.Leave += delegate { command.DelMenu(stripMenu, property); };
                btnPicturePlugIn.Location = new System.Drawing.Point(31, 103);
                btnPicturePlugIn.Name = "btnPicturePlugIn";
                btnPicturePlugIn.Size = new System.Drawing.Size(114, 30);
                btnPicturePlugIn.TabIndex = 0;
                btnPicturePlugIn.Text = "Figure with Picture";
                btnPicturePlugIn.UseVisualStyleBackColor = true;
                plug.Controls.Add(btnPicturePlugIn);

            }
            else
            {
                plug.Controls.Remove(btnPicturePlugIn);
                command.DelMenu(stripMenu, property);
                item.CheckState = CheckState.Unchecked;
            }
        }
    }
}
