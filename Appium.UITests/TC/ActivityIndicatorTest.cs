using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Tizen;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using NUnit.Framework;
using OpenQA.Selenium.Appium.MultiTouch;
using OpenQA.Selenium.Interactions.Internal;

namespace Appium.UITests
{
    [TestFixture(FormsTizenGalleryUtils.Platform)]
    public class ActivityIndicatorTest
    {
        string PlatformName;
        AppiumDriver Driver;

        public ActivityIndicatorTest(string platform)
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
        public void ColorTest()
        {
            string color = WebElementUtils.GetAttribute(Driver, "ai", "Color");

            WebElementUtils.Click(Driver, "button");

            string color2 = WebElementUtils.GetAttribute(Driver, "ai", "Color");

            Assert.AreNotEqual(color, color2);
        }
    }
}
