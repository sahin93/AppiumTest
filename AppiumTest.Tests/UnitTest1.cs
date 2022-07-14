using OpenQA.Selenium.Appium;
using OpenQA.Selenium.Appium.Enums;
using OpenQA.Selenium.Appium.Windows;

namespace AppiumTest.Tests
{
    public class UnitTest1
    {
        [Fact]
        public void Test1()
        {
            var capabilities = new AppiumOptions();
            capabilities.AddAdditionalCapability(MobileCapabilityType.App, "C4D551A1-5391-4EE7-9AA8-6650B8830A8C_bmnx82tmghg8a!App");
            capabilities.AddAdditionalCapability(MobileCapabilityType.PlatformName, "Windows");
            capabilities.AddAdditionalCapability(MobileCapabilityType.DeviceName, "WindowsPC");

            // start the driver
            var driver = new WindowsDriver<WindowsElement>(new Uri("http://127.0.0.1:4723/wd/hub/"), capabilities);
            var button = driver.FindElement(MobileBy.AccessibilityId("btnClick"));

            var entry = driver.FindElement(MobileBy.AccessibilityId("entName"));
            entry.SendKeys("Welcome");
            button.Click();
        }
    }
}