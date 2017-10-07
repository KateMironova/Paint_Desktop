using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePaintGreatAgain.API
{
    public interface IAction
    {
        void ActionPerformed(object sender, EventArgs e);
    }
}
