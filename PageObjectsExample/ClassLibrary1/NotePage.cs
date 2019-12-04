using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using System.Linq;

namespace ClassLibrary1
{
    internal class NotePage
    {
        private IWebDriver browser;

        public NotePage(IWebDriver browser)
        {
            this.browser = browser;
        }

        internal NotePage AddComment(ExampleComment exampleComment)
        {
            var coment = browser.FindElement(By.Id("comment"));
            coment.SendKeys(exampleComment.Content);

            var author = browser.FindElement(By.Id("author"));
            author.SendKeys(exampleComment.Author);

            var email = browser.FindElement(By.Id("email"));
            email.SendKeys(exampleComment.Email);

            MoveToElement(browser.FindElement(By.CssSelector("div.nav-links")));
            browser.FindElement(By.Id("submit")).Submit();

            return new NotePage(browser);
        }

        internal bool Has(ExampleComment exampleComment)
        {
            var comments = browser.FindElements(By.CssSelector("article.comment-body"));
            var myComments = comments
                .Where(c => c.FindElement(By.CssSelector(".fn")).Text == exampleComment.Author)
                .Where(c => c.FindElement(By.CssSelector(".comment-content > p")).Text == exampleComment.Content);

            return myComments.Count() == 1;
        }

        private void MoveToElement(IWebElement element)
        {
            Actions builder = new Actions(browser);
            Actions moveTo = builder.MoveToElement(element);
            moveTo.Build().Perform();


        }
    }
}