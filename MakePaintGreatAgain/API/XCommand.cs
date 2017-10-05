using MakePaintGreatAgain.Controls;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MakePaintGreatAgain.API
{
    public class XCommand
    {
        public PPanel panel;
        public TabControl pTab;
        public PTabData childTab;


        public ActionSave aSave;
        public ActionLoad aLoad;
        public ActionSaveToCloud aSaveCloud;
        public ActionLoadFromCloud aLoadCloud;
        public ActionSaveSetting aSaveSetting;
        public ActionLoadSetting aLoadSetting;
        public ActionExit aExit;
        public ActionStatus aStatus;
        public ActionAddDocument aAddDoc;
        public ActionDeleteDocument aDeleteDoc;
        public ActionRenameDocument aRenameDoc;
        public ActionTabFindDocument aTabFind;
        public ActionChangeLang aChangeLang;
        public ActionChangeSkin aChangeSkin;
        public ActionHelp aHelp;
        public ActionAbout aAbout;
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
       
        public class ActionSave
        {
            XCommand xcom;
            public ActionSave(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("save");

            }
        }
        public class ActionLoad
        {
            XCommand xcom;
            public ActionLoad(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("load");
            }
        }
        public class ActionSaveToCloud
        {
            XCommand xcom;
            public ActionSaveToCloud(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("saveCloud");
            }
        }
        public class ActionLoadFromCloud
        {
            XCommand xcom;
            public ActionLoadFromCloud(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("loadCloud");
            }
        }
        public class ActionSaveSetting
        {
            XCommand xcom;
            public ActionSaveSetting(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("saveSetting");
            }
        }
        public class ActionLoadSetting
        {
            XCommand xcom;
            public ActionLoadSetting(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("loadSetting");
            }
        }
        public class ActionStatus
        {
            XCommand xcom;
            public ActionStatus(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {

            }
        }
        public class ActionExit
        {
            XCommand xcom;
            public ActionExit(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("exit");
            }
        }
      
        public class ActionAddDocument
        {
            XCommand xcom;
            public ActionAddDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("add");
            }
        }
        public class ActionRenameDocument
        {
            XCommand xcom;
            public ActionRenameDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("rename");
            }
        }
        public class ActionDeleteDocument
        {
            XCommand xcom;
            public ActionDeleteDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("delete");
            }
        }
        public class ActionTabFindDocument
        {
            XCommand xcom;
            public ActionTabFindDocument(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
            }
        }
        public class ActionChangeLang
        {
            XCommand xcom;
            public ActionChangeLang(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                MessageBox.Show("Lang");
            }
        }
        public class ActionChangeSkin
        {
            XCommand xcom;
            public ActionChangeSkin(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, ToolStripItemClickedEventArgs e)
            {
                MessageBox.Show("Skin");
            }
        }
        public class ActionHelp
        {
            XCommand xcom;
            public ActionHelp(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("help");
            }
        }
        public class ActionAbout
        {
            XCommand xcom;
            public ActionAbout(XCommand xcom)
            {
                this.xcom = xcom;
            }
            public void ActionPerformed(object sender, EventArgs e)
            {
                MessageBox.Show("about");
            }
        }
    }
}
