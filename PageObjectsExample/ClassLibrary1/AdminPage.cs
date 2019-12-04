using OpenQA.Selenium;

namespace ClassLibrary1
{
    internal class AdminPage
    {
        private IWebDriver browser;

        public AdminPage(IWebDriver browser)
        {
            this.browser = browser;
        }
    }
}