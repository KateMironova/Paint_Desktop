using System;
using NUnit.Framework;
using MakePaintGreatAgain.Controls;
using System.Windows.Forms;

namespace TestPaint
{
    [TestFixture]
    public class UnitTest
    {
        TestCommand xcom;
        PMenu menuBar;

        [SetUp]
        public void SetUp()
        {
            xcom = new TestCommand();
            menuBar = new PMenu();
        }

        [TestCase("Save", "save")]
        public void TestMenuFile(string name, string result)
        {
            ToolStripMenuItem file = menuBar.menuStrip1.Items["File"] as ToolStripMenuItem;
            file.DropDownItems[name].PerformClick();
            Assert.AreEqual(result, xcom.result);
        }
        
    }
}
