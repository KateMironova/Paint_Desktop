using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using NUnit.Framework;
using TestStack.White.UIItems.Finders;
using System.Collections.Generic;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;
namespace TestPaint.AutoTest
{
    [TestFixture]
    public class ToolTest
    {
        public Window window = null;

        [SetUp]
        public void SetUp()
        {
            string appPath = @"D:\COURSE\paint\MakePaintGreatAgain\TestForm\bin\Debug\TestForm.exe";
            Application application = Application.Launch(appPath);
            window = application.GetWindows()[0];
            POM.window = window;
        }

        [TearDown]
        public void TearDown()
        {
            window.Close();
        }

        [Test]
        public void TestExistToolBar()
        {
            List<Button> tools = new List<Button> { POM.ToolBar.NewWindowTool, POM.ToolBar.LoadTool, POM.ToolBar.SaveTool };
            foreach (Button btn in tools)
            {
                Assert.AreEqual(true, btn.Enabled);
            }
        }
        [Test]
        public void TestToolBar()
        {
            TestToolClick(POM.ToolBar.NewWindowTool, "New Window", "add");
            TestToolClick(POM.ToolBar.NewWindowTool, "Save", "save");
            TestToolClick(POM.ToolBar.NewWindowTool, "Load", "load");
        }

        private void TestToolClick(Button btn, string txt, string result)
        {
            btn.Click();

            if (window.GetElement(SearchCriteria.ByText(txt)).Current.Name == result)
                window.Get<Button>(SearchCriteria.ByText("OK")).Click();
        }
    }
}
