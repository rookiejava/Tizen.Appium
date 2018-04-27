using NUnit.Framework;
using System;

namespace Appium.UITests
{
    [TestFixture]
    public class NavigationPageAsyncTest2 : TestTemplate
    {
        [Test]
        public void InsertTest()
        {
            var pushBtnId = "pushBtn_1";
            var insertBtnId = "insertBefore_2";

            var depthBefore = GetNavigationStackDepth();

            Driver.Click(pushBtnId);

            var depthAfter = GetNavigationStackDepth();
            Assert.True((depthBefore < depthAfter), "StackDepth should be increased, but got before: " + depthBefore + ", after: " + depthAfter);

            depthBefore = depthAfter;
            var currenPageBefore = GetNavigationCurrenPage();

            Driver.Click(insertBtnId);

            var currenPageAfter = GetNavigationCurrenPage();
            depthAfter = GetNavigationStackDepth();
            Assert.True((depthBefore < depthAfter), "StackDepth should be increased, but got before: " + depthBefore + ", after: " + depthAfter);
            Assert.True((currenPageBefore == currenPageAfter), "CurrenPage should be same, but got before: " + depthBefore + ", after: " + depthAfter);

            var image = "NavigationPageAsyncTest2_insert.png";
            Driver.CheckScreenshot(image);
            Driver.GoBack();
            System.Threading.Thread.Sleep(2000);

            var image2 = "NavigationPageAsyncTest2_insert2.png";
            Driver.CheckScreenshot(image2);
            Driver.GoBack();
            System.Threading.Thread.Sleep(2000);

            var image3 = "NavigationPageAsyncTest2_insert3.png";
            Driver.CheckScreenshot(image3);

            System.Threading.Thread.Sleep(3000);
        }

        [Test]
        public void RemoveTopTest()
        {
            var pushBtnId = "pushBtn_1";
            var removeBtnId = "removeTop_2";

            var depthBefore = GetNavigationStackDepth();
            var currentPageBefore = GetNavigationCurrenPage();

            Driver.Click(pushBtnId);

            var depthAfter = GetNavigationStackDepth();
            var currentPageAfter = GetNavigationCurrenPage();
            Assert.True((depthBefore < depthAfter), "StackDepth should be increased, but got before: " + depthBefore + ", after: " + depthAfter);
            Assert.True((currentPageBefore != currentPageAfter), "current page should not be same, but got before: " + depthBefore + ", after: " + depthAfter);

            System.Threading.Thread.Sleep(2000);
            var image = "NavigationPageAsyncTest2_removeTop.png";
            Driver.CheckScreenshot(image);

            Driver.Click(removeBtnId);

            depthAfter = GetNavigationStackDepth();
            currentPageAfter = GetNavigationCurrenPage();
            Assert.True((depthBefore == depthAfter), "StackDepth should be same, but got before: " + depthBefore + ", after: " + depthAfter);
            Assert.True((currentPageBefore == currentPageAfter), "current page should be same, but got before: " + depthBefore + ", after: " + depthAfter);

            System.Threading.Thread.Sleep(2000);
            var image2 = "NavigationPageAsyncTest2_removeTop2.png";
            Driver.CheckScreenshot(image2);
        }

        [Test]
        public void RemoveBeforeTest()
        {
            var pushBtnId = "pushBtn_1";
            var pushBtn2Id = "pushBtn_2";
            var removeBtnId = "removeBeforeTop_3";

            var depthBefore = GetNavigationStackDepth();
            var currentPageBefore = GetNavigationCurrenPage();

            Console.WriteLine("#### depthBefore: " + depthBefore);

            Driver.Click(pushBtnId);
            Driver.Click(pushBtn2Id);

            var depthAfter = GetNavigationStackDepth();
            var currentPageAfter = GetNavigationCurrenPage();

            Console.WriteLine("#### depthBefore: " + depthBefore);
            Console.WriteLine("#### depthAfter: " + depthAfter);
            Assert.True(((depthBefore + 2) == depthAfter), "StackDepth should be increased, but got before: " + depthBefore + ", after: " + depthAfter);
            Assert.True((currentPageBefore != currentPageAfter), "current page should not be same, but got before: " + depthBefore + ", after: " + depthAfter);

            System.Threading.Thread.Sleep(2000);
            var image = "NavigationPageAsyncTest2_removeBefore.png";
            Driver.CheckScreenshot(image);

            depthBefore = depthAfter;
            currentPageBefore = currentPageAfter;

            Driver.Click(removeBtnId);

            depthAfter = GetNavigationStackDepth();
            currentPageAfter = GetNavigationCurrenPage();
            Assert.True((depthBefore > depthAfter), "StackDepth should be decreased, but got before: " + depthBefore + ", after: " + depthAfter);
            Assert.True((currentPageBefore == currentPageAfter), "current page should be same, but got before: " + depthBefore + ", after: " + depthAfter);

            System.Threading.Thread.Sleep(2000);
            var image2 = "NavigationPageAsyncTest2_removeBefore2.png";
            Driver.CheckScreenshot(image2);

            Driver.GoBack();
            System.Threading.Thread.Sleep(3000);

            var image3 = "NavigationPageAsyncTest2_removeBefore3.png";
            Driver.CheckScreenshot(image3);
        }

        int GetNavigationStackDepth()
        {
            var depth = Driver.GetAttribute<int>("MainPage", "StackDepth");
            return depth;
        }

        string GetNavigationCurrenPage()
        {
            var page = Driver.GetAttribute<string>("MainPage", "CurrentPage");
            return page;
        }
    }
}
