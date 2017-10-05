using MakePaintGreatAgain.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PluginTextFigure
{
    public class TextFigure : IPlugin
    {
        Button btnTextPlugIn;
        Command command = new Command();
        public string Name
        {
            get { return "Text figure"; }
        }

        public void Run(MenuStrip menu, ToolStrip stripMenu, ToolStripMenuItem item, GroupBox plug, GroupBox property)
        {

            if (item.CheckState == CheckState.Unchecked)
            {
                item.CheckState = CheckState.Checked;
                btnTextPlugIn = new Button();
                btnTextPlugIn.Enter += delegate { command.AddMenu(stripMenu, property); };
                btnTextPlugIn.Leave += delegate { command.DelMenu(stripMenu, property); };
                btnTextPlugIn.Location = new System.Drawing.Point(30, 64);
                btnTextPlugIn.Name = "btnTextPlugIn";
                btnTextPlugIn.Size = new System.Drawing.Size(111, 27);
                btnTextPlugIn.TabIndex = 4;
                btnTextPlugIn.Text = "Figure with text";
                btnTextPlugIn.UseVisualStyleBackColor = true;
                btnTextPlugIn.Visible = true;
                plug.Controls.Add(btnTextPlugIn);

            }
            else
            {
                plug.Controls.Remove(btnTextPlugIn);
                command.DelMenu(stripMenu, property);
                item.CheckState = CheckState.Unchecked;
            }
        }
    }
}
