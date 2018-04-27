using NUnit.Framework;

namespace Appium.UITests
{
    [TestFixture]
    public class SearchBarTest1 : TestTemplate
    {
        [Test]
        public void ScrollWithoutAnimationTest()
        {
            var searchBarBtnId = "searchBar";

            Driver.SetText(searchBarBtnId, "test");
            System.Threading.Thread.Sleep(4000);

            var image = "SearchBarTest1.png";
            Driver.CheckScreenshot(image);
        }
    }
}
