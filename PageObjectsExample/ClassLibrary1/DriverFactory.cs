using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace ClassLibrary1
{
    public class DriverFactory 
    {
        internal static IWebDriver Get()
        {
            var driver = new ChromeDriver();

            driver.Manage().Window.Maximize();

            return driver;

        }

    }

}