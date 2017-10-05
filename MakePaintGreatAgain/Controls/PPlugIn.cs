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
    public partial class PPlugIn : UserControl
    {
        public XCommand xcom { get; set; }
        public PPlugIn()
        {
            InitializeComponent();
        }
    }
}
