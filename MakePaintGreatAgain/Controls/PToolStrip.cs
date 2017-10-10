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

namespace MakePaintGreatAgain.Controls
{
    public partial class PToolStrip : UserControl
    {
        public ICommand xcom { get; set; }
        public PToolStrip()
        {
            InitializeComponent();
            toolStripBtnNewWind.Click += new EventHandler((s, e) => xcom.aAddDoc.ActionPerformed(s, e));
            toolStripBtnLoad.Click += new EventHandler((s, e) => xcom.aLoad.ActionPerformed(s, e));
            toolStripBtnSave.Click += new EventHandler((s, e) => xcom.aSave.ActionPerformed(s, e));
           
        }
    }
}
