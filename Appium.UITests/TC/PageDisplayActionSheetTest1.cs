using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture]
    public class PageDisplayActionSheetTest1 : TestTemplate
    {
        [Test]
        public void ViewTest()
        {
            var btnId = "button";

            Driver.Click(btnId);

            var image = "PageDisplayActionSheetTest1_button.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, Driver.CompareToScreenshot(image));

            Driver.GoBack();
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void ViewTest2()
        {
            var btnId = "button1";

            Driver.Click(btnId);

            var image = "PageDisplayActionSheetTest1_button1.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, Driver.CompareToScreenshot(image));

            Driver.GoBack();
            System.Threading.Thread.Sleep(1000);
        }

        [Test]
        public void ViewTest3()
        {
            var btnId = "button2";

            Driver.Click(btnId);

            var image = "PageDisplayActionSheetTest1_button3.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, Driver.CompareToScreenshot(image));

            Driver.GoBack();
            System.Threading.Thread.Sleep(1000);
        }
    }
}
