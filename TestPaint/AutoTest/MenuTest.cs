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
            string appPath = @"D:\COURSE\paint\MakePaintGreatAgain\TestForm\bin\Debug\TestForm";
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
                POM.MenuBar.HelpMenu };
            foreach (Menu menu in menues)
            {
                Assert.AreEqual(true, menu.Enabled);
            }
        }

        [Test]
        public void TestFileMenu()
        {
            TestMenuClick(POM.MenuBar.SSaveMenu, "Save", "save");
            TestMenuClick(POM.MenuBar.SSaveMenu, "Load", "load");
            TestMenuClick(POM.MenuBar.SSaveCloudMenu, "Save to cloud", "saveCloud");
            TestMenuClick(POM.MenuBar.SLoadCloudMenu, "Load from cloud", "loadCloud");
            TestMenuClick(POM.MenuBar.SSaveSetMenu, "Save setting to", "saveSetting");
            TestMenuClick(POM.MenuBar.SLoadSetMenu, "Load setting from", "loadSetting");
            TestMenuClick(POM.MenuBar.SExitMenu, "Exit", "exit");
        }
        public void TestWindowMenu()
        {
            TestMenuClick(POM.MenuBar.SAddTabMenu, "Add tab", "add");
            TestMenuClick(POM.MenuBar.SDelTabMenu, "Delete tab", "delete");
            TestMenuClick(POM.MenuBar.SNameTabMenu, "Rename tab", "rename");
        }
        public void TestHelpMenu()
        {
            TestMenuClick(POM.MenuBar.SHelpMenu, "Help", "help");
            TestMenuClick(POM.MenuBar.SAboutMenu, "About", "about");
        }
        private void TestMenuClick(Menu menu, string txt, string res)
        {
            menu.Click();

            if (window.GetElement(SearchCriteria.ByText(txt)).Current.Name == res)
                window.Get<Button>(SearchCriteria.ByText("OK")).Click();
        }
    }
}
