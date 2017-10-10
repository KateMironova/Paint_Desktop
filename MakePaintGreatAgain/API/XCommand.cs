using MakePaintGreatAgain.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakePaintGreatAgain.API
{
    public class XCommand : ICommand
    {
        public PPanel panel;
        public TabControl pTab;
        public PTabData childTab;


        public IAction aSave { get; }
        public IAction aLoad { get; }
        public IAction aSaveCloud { get; }
        public IAction aLoadCloud { get; }
        public IAction aSaveSetting { get; }
        public IAction aLoadSetting { get; }
        public IAction aExit { get; }
        public IAction aStatus { get; }
        public IAction aAddDoc { get; }
        public IAction aDeleteDoc { get; }
        public IAction aRenameDoc { get; }
        public IAction aTabFind { get; }
        public IAction aChangeLang { get; }
        public IAction aChangeSkin { get; }
        public IAction aHelp { get; }
        public IAction aAbout { get; }
        public XCommand()
        {
            aSave = new ActionSave(this);
            aLoad = new ActionLoad(this);
            aSaveCloud = new ActionSaveToCloud(this);
            aLoadCloud = new ActionLoadFromCloud(this);
            aSaveSetting = new ActionSaveSetting(this);
            aLoadSetting = new ActionLoadSetting(this);
            aExit = new ActionExit(this);
            aStatus = new ActionStatus(this);
            aAddDoc = new ActionAddDocument(this);
            aDeleteDoc = new ActionDeleteDocument(this);
            aRenameDoc = new ActionRenameDocument(this);
            aTabFind = new ActionTabFindDocument(this);
            aChangeLang = new ActionChangeLang(this);
            aChangeSkin = new ActionChangeSkin(this);
            aHelp = new ActionHelp(this);
            aAbout = new ActionAbout(this);
        }
       
        public class ActionSave: IAction
        {
            ICommand xcom;
            public ActionSave(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("save");

            }
        }
        public class ActionLoad : IAction
        {
            ICommand xcom;
            public ActionLoad(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("load");
            }
        }
        public class ActionSaveToCloud : IAction
        {
            ICommand xcom;
            public ActionSaveToCloud(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("saveCloud");
            }
        }
        public class ActionLoadFromCloud : IAction
        {
            ICommand xcom;
            public ActionLoadFromCloud(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("Load from cloud");
            }
        }
        public class ActionSaveSetting : IAction
        {
            ICommand xcom;
            public ActionSaveSetting(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("saveSetting");
            }
        }
        public class ActionLoadSetting : IAction
        {
            ICommand xcom;
            public ActionLoadSetting(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("loadSetting");
            }
        }
        public class ActionStatus : IAction
        {
            ICommand xcom;
            public ActionStatus(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {

            }
        }
        public class ActionExit : IAction
        {
            ICommand xcom;
            public ActionExit(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("exit");
            }
        }
      
        public class ActionAddDocument : IAction
        {
            ICommand xcom;
            public ActionAddDocument(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("add");
            }
        }
        public class ActionRenameDocument : IAction
        {
            ICommand xcom;
            public ActionRenameDocument(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("rename");
            }
        }
        public class ActionDeleteDocument : IAction
        {
            ICommand xcom;
            public ActionDeleteDocument(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("delete");
            }
        }
        public class ActionTabFindDocument : IAction
        {
            ICommand xcom;
            public ActionTabFindDocument(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {

            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
            }
        }
        public class ActionChangeLang : IAction
        {
            ICommand xcom;
            public ActionChangeLang(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {

            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                MessageBox.Show("Lang");
            }
        }
        public class ActionChangeSkin : IAction
        {
            ICommand xcom;
            public ActionChangeSkin(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {

            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                MessageBox.Show("Skin");
            }
        }
        public class ActionHelp : IAction
        {
            ICommand xcom;
            public ActionHelp(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("help");
            }
        }
        public class ActionAbout : IAction
        {
            ICommand xcom;
            public ActionAbout(ICommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("About");
            }
        }
    }
}
