using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MakePaintGreatAgain.API
{
    public interface ICommand
    {
        IAction aSave { get; }
        IAction aLoad { get; }
        IAction aSaveCloud { get; }
        IAction aLoadCloud { get; }
        IAction aSaveSetting { get; }
        IAction aLoadSetting { get; }
        IAction aExit { get; }
        IAction aStatus { get; }
        IAction aAddDoc { get; }
        IAction aDeleteDoc { get; }
        IAction aRenameDoc { get; }
        IAction aTabFind { get; }
        IAction aChangeLang { get; }
        IAction aChangeSkin { get; }
        IAction aHelp { get; }
        IAction aAbout { get; }

    }
}
