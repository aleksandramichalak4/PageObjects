using System;
using OpenQA.Selenium;

namespace ClassLibrary1
{
    internal class LoginPage
    {
         
        private const string MAIN_PAGE_BASE_URL = "https://automatyzacja.benedykt.net/wp-admin";
        private readonly IWebDriver browser;

        private LoginPage(IWebDriver browser)
        {
            this.browser = browser;
           

        }

        internal AdminPage Login(string user, string password)
        {
            browser.Navigate().GoToUrl(MAIN_PAGE_BASE_URL);
            var LoginBox = browser.FindElement(By.Id("user_login"));
            LoginBox.SendKeys(user);
            var PasswordBox = browser.FindElement(By.Id("user_pass"));
            PasswordBox.SendKeys(password);
            var Submit = browser.FindElement(By.Id("wp-submit"));
            Submit.Submit();

            return new AdminPage(browser);
        }

        internal static object CreateToNewestNote()
        {
            throw new NotImplementedException();
        }

        internal static LoginPage Open(IWebDriver browser)
        {
            return new LoginPage(browser);
        }
    }
}