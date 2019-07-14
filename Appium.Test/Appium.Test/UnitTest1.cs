using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Android;
using OpenQA.Selenium.Remote;
using System;

namespace Appium.Test
{
    [TestClass]
    public class UnitTest1
    {
        // Creating instance of Appium Driver
        AppiumDriver<IWebElement> driver;
        DesiredCapabilities cap = new DesiredCapabilities();


        [TestMethod]
        public void TestMethod1()
        {
            cap.SetCapability("platformName", "Android");
            cap.SetCapability("platformVersion", "7.1.1");
            cap.SetCapability("deviceName", "Nexus6p");
            cap.SetCapability("app", "D:\\Repository\\Appium.Test\\Appium.Test\\APKs\\elmenus.apk");
            //cap.SetCapability("appPackage", "com.elmenus.app");


            driver = new AndroidDriver<IWebElement>(new Uri("http://127.0.0.1:4723/wd/hub"),cap);
        }
    }
}
