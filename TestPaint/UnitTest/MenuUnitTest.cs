using System;
using NUnit.Framework;
using MakePaintGreatAgain.Controls;
using System.Windows.Forms;

namespace TestPaint
{
    [TestFixture]
    public class MenuUnitTest
    {
        TestCommand xcom;
        PMenu pMenu;

        [SetUp]
        public void SetUp()
        {
            xcom = new TestCommand();
            pMenu = new PMenu();
        }

        [TestCase("Save", "save")]
        [TestCase("Load", "load")]
        [TestCase("Save to cloud", "saveCloud")]
        [TestCase("Load from cloud", "loadCloud")]
        [TestCase("Save setting to", "saveSetting")]
        [TestCase("Load setting from", "loadSetting")]
        [TestCase("Exit", "exit")]
        public void TestMenuFile(string name, string result)
        {
            ToolStripMenuItem file = pMenu.menuStrip1.Items[0] as ToolStripMenuItem;
            file.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, xcom.result);
        }

        [TestCase("Add tab", "add")]
        [TestCase("Delete tab", "delete")]
        [TestCase("Rename tab", "rename")]
        public void TestMenuWindow(string name, string result)
        {
            ToolStripMenuItem wind = pMenu.menuStrip1.Items[1] as ToolStripMenuItem;
            wind.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, xcom.result);
        }

        [TestCase("Help", "help")]
        [TestCase("About", "about")]
        public void TestMenuHelp(string name, string result)
        {
            ToolStripMenuItem help = pMenu.menuStrip1.Items[2] as ToolStripMenuItem;
            help.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, xcom.result);
        }

    }
}
