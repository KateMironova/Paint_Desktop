using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakePaintGreatAgain.Controls
{
    public partial class PTabData : TabPage
    {
        public PTabData()
        {
            InitializeComponent();
        }

        public PTabData(IContainer container)
        {
            container.Add(this);

            InitializeComponent();
        }
    }
}
