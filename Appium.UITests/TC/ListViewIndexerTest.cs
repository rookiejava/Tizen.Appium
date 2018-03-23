using System;
using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture(FormsTizenGalleryUtils.Platform)]
    public class ListViewIndexerTest
    {
        string PlatformName;
        AppiumDriver Driver;

        public ListViewIndexerTest(string platform)
        {
            PlatformName = platform;
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            Driver = new AppiumDriver(PlatformName);
            FormsTizenGalleryUtils.FindTC(Driver, this.GetType().Name);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void Enable1Test()
        {
            var btnId = "enable1";
            var listId = "list";

            WebElementUtils.Click(Driver, btnId);

            var displayBinding = WebElementUtils.GetAttribute<string>(Driver, listId, "GroupDisplayBinding");
            var shortBinding = WebElementUtils.GetAttribute<string>(Driver, listId, "GroupDisplayBinding");

            var image = "ListViewIndexerTest_enable1.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, WebElementUtils.CompareToScreenshot(Driver, image));
        }

        [Test]
        public void Enable2Test()
        {
            var btnId = "enable2";
            var listId = "list";

            WebElementUtils.Click(Driver, btnId);

            var displayBinding = WebElementUtils.GetAttribute<string>(Driver, listId, "GroupDisplayBinding");
            var shortBinding = WebElementUtils.GetAttribute<string>(Driver, listId, "GroupDisplayBinding");

            var image = "ListViewIndexerTest_enable2.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, WebElementUtils.CompareToScreenshot(Driver, image));
        }

        [Test]
        public void Enable3Test()
        {
            var btnId = "enable3";
            var listId = "list";

            WebElementUtils.Click(Driver, btnId);

            var displayBinding = WebElementUtils.GetAttribute<string>(Driver, listId, "GroupDisplayBinding");
            var shortBinding = WebElementUtils.GetAttribute<string>(Driver, listId, "GroupDisplayBinding");

            var image = "ListViewIndexerTest_enable3.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, WebElementUtils.CompareToScreenshot(Driver, image));
        }
    }
}
