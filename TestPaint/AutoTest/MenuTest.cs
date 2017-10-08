using TestStack.White;
using TestStack.White.UIItems.WindowItems;
using TestStack.White.Factory;
using NUnit.Framework;
using TestStack.White.UIItems.Finders;
using System.Collections.Generic;
using TestStack.White.UIItems.MenuItems;
using TestStack.White.UIItems;
using TestStack.White.UIItems.ListBoxItems;

namespace TestPaint
{
    [TestFixture]
    public class MenuTest
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
        public void TestExistMenuBar()
        {
            List<Menu> menues = new List<Menu> { POM.MenuBar.FileMenu, POM.MenuBar.WindowMenu,
                POM.MenuBar.HelpMenu }; //+ POM.MenuBar.FigureMenu, POM.MenuBar.TextMenu,
            foreach (Menu menu in menues)
            {
                Assert.AreEqual(true, menu.Enabled);
            }
        }

        [Test]
        public void TestWindowMenu()
        {
            TestMenuClick(POM.MenuBar.SAboutMenu, "about");
        }
        private void TestMenuClick(Menu menu, string res)
        {
            menu.Click();

            if (window.GetElement(SearchCriteria.ByText(res)).Current.Name == res)
                window.Get<Button>(SearchCriteria.ByText("OK")).Click();
        }
        

        

    }
}
