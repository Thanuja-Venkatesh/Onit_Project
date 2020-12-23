using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace Onit_Project
{
    [Binding]
    public class GoogleSearchSteps
    {
        private IWebDriver driver;

        [Given(@"Open Google Chrome")]
        public void GivenOpenGoogleChrome()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("http://www.google.com/");
            driver.Manage().Window.Maximize();
            System.Threading.Thread.Sleep(2000);
        }

        [Then(@"Enter Software Tester in search bar")]
        public void ThenEnterSoftwareTesterInSearchBar()
        {
            IWebElement searchtext = driver.FindElement(By.XPath("//input[@class='gLFyf gsfi']"));
            searchtext.SendKeys("software tester");

            IWebElement searchbutton = driver.FindElement(By.XPath("(//input[@aria-label='Google Search'])[2]"));
            searchbutton.Click();
        }

        [Then(@"Click the second page and click the second result in second page")]
        public void ThenClickTheSecondPageAndClickTheSecondResultInSecondPage()
        {
            IWebElement clickpage = driver.FindElement(By.XPath("//a[@aria-label='Page 2']"));
            clickpage.Click();

            IWebElement clickresult = driver.FindElement(By.XPath("(//div[@data-async-context='query:software%20tester']//div[@class='g'])[2]"));
            clickresult.Click();

            System.Threading.Thread.Sleep(100);
        }

        [Then(@"Assert the page title")]
        public void ThenAssertThePageTitle()
        {

            String actualtitle = driver.Title;

            Assert.IsNotEmpty(actualtitle);
        }

        [Then(@"close the browser")]
        public void ThenCloseTheBrowser()
        {
            driver.Quit();
        }
    }
}
