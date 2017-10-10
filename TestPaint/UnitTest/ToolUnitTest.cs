using System;
using NUnit.Framework;
using MakePaintGreatAgain.Controls;

namespace TestPaint.UnitTest
{
    [TestFixture]
    public class ToolUnitTest
    {
        TestCommand xcom;
        PToolStrip pTool = new PToolStrip();

       

        [SetUp]
        public void SetUp()
        {
            xcom = new TestCommand();
            pTool = new PToolStrip();
        }

        [TestCase("New window", "add")]
        [TestCase("Save", "save")]
        [TestCase("Load", "load")]
        public void TestMenuFile(string name, string result)
        {
            pTool.toolStrip1.Items[name].PerformClick();
            Assert.AreEqual(result, xcom.result);
        }
    }
}
