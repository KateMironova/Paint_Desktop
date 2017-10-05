using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MakePaintGreatAgain.API;
using MakePaintGreatAgain.PluginBase;

namespace MakePaintGreatAgain.Controls
{
    public partial class PPanel : UserControl, IHost
    {
        XCommand xcom;
        private PluginManager pm = new PluginManager();
        public PPanel()
        {
            InitializeComponent();
            xcom = new XCommand();
            pMenu1.xcom = xcom;
            pToolStrip1.xcom = xcom;
            pPlugIn1.xcom = xcom;

            //сканируем плагины в папке Plugins
            pm.ScanPlugins(AppDomain.CurrentDomain.BaseDirectory + "\\Plugins\\");

            //создаем меню плагинов
            ToolStripMenuItem mi = new ToolStripMenuItem("Plugins");
            pMenu1.menuStrip1.Items.Add(mi);
            
            //перебираем плагины, создаем пункт меню для каждого
            foreach (var plugin in pm.Plugins)
            {
                ToolStripMenuItem item = new ToolStripMenuItem(plugin.Name);
                mi.DropDownItems.Add(item);
                item.Click += delegate { plugin.Run(pMenu1.menuStrip1, pToolStrip1.toolStrip1, item, pPlugIn1.groupBoxPlugin, pProperty1.groupBox2); };//при клике на меню, запускаем плагин на выполнение
                item.CheckState = CheckState.Unchecked;
            }
        }
        public void AddControlToMainForm(Control ctrl)
        {
            //Controls.Add(ctrl);
        }
    }
}
