using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture]
    public class LabelTest2 : TestTemplate
    {
        [Test]
        public void ViewTest()
        {
            var image = "LabelTest2.png";
            //WebElementUtils.GetScreenshotAndSave(Driver, image);
            Assert.AreEqual(true, Driver.CompareToScreenshot(image));
        }
    }
}
