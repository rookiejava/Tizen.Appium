﻿using System;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Tizen;
using OpenQA.Selenium.Appium.Android;
using NUnit.Framework;
using System.Drawing;

namespace Xamarin.Issues.UITests
{
    [TestFixture(TestScriptUtils.Platform)]
    public class TimePickerTests_BackgroundColor_TimePicker_COLOR_CHANGE
    {
        string PlatformName;
        AppiumDriver Driver;

        public TimePickerTests_BackgroundColor_TimePicker_COLOR_CHANGE(string platform)
        {
            PlatformName = platform;
        }

        [TestFixtureSetUp]
        public void Setup()
        {
            Driver = new AppiumDriver(PlatformName);
            TestScriptUtils.FindTC(Driver, this.GetType().Name);
        }

        [TestFixtureTearDown]
        public void TearDown()
        {
            Driver.Quit();
        }

        [Test]
        public void BackgroundColorTest()
        {
            string ret = WebElementUtils.GetAttribute(Driver, "_timePicker5", "BackgroundColor");

            var pt = new Point(366, 974);
            RemoteTouchScreenUtils.Click(Driver, pt);

            string ret2 = WebElementUtils.GetAttribute(Driver, "_timePicker5", "BackgroundColor");
            Assert.AreNotEqual(ret, ret2);
        }
    }
}