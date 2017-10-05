using MakePaintGreatAgain.API;
using MakePaintGreatAgain.Controls;
using MakePaintGreatAgain.PluginBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakePaintGreatAgain.Models
{
    public interface IPlugin
    {
        string Name { get; }
        void Run(MenuStrip menu, ToolStrip stripMenu, ToolStripMenuItem item, GroupBox plug, GroupBox property);
    }
}
