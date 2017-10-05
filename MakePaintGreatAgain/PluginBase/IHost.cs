using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakePaintGreatAgain.PluginBase
{
    public interface IHost
    {
        void AddControlToMainForm(Control ctrl);
    }
}
