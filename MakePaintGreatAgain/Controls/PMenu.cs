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
    public partial class PMenu : UserControl
    {
        public ICommand xcom { get; set; }
        public PMenu()
        {
            InitializeComponent();

            saveToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSave.ActionPerformed(s, e));
            loadToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aLoad.ActionPerformed(s, e));
            saveToCloudToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSaveCloud.ActionPerformed(s, e));
            loadFromCloudToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aLoadCloud.ActionPerformed(s, e));
            saveSettingToToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aSaveSetting.ActionPerformed(s, e));
            loadSettingFromToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aLoadSetting.ActionPerformed(s, e));
            exitToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aExit.ActionPerformed(s, e));
            addTabToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aAddDoc.ActionPerformed(s, e));
            deleteTabToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aDeleteDoc.ActionPerformed(s, e));
            renameTabToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aRenameDoc.ActionPerformed(s, e));
            skinToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aChangeSkin.ActionPerformed(s, e));
            languageToolStripMenuItem.DropDownItemClicked += new ToolStripItemClickedEventHandler((s, e) => xcom.aChangeLang.ActionPerformed(s, e));
            helpToolStripMenuItem1.Click += new EventHandler((s, e) => xcom.aHelp.ActionPerformed(s, e));
            aboutToolStripMenuItem.Click += new EventHandler((s, e) => xcom.aAbout.ActionPerformed(s, e));
        }
    }
}
