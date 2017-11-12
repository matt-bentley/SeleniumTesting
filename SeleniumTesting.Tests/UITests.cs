using Microsoft.Owin.Hosting;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting.Tests
{
    [TestClass]
    public class UITests : SeleniumTest
    {
        public UITests() : base("SeleniumTesting")
        {
        }

        [TestMethod]
        public async Task TestMethod()
        {
            // Navigate to main page
            WebDriver.Navigate().GoToUrl(GetAbsoluteUrl(@"home/index"));

            IList<IWebElement> links = WebDriver.FindElements(By.ClassName("navbar-link"));
            links.First(element => element.Text == "API").Click();
            await Task.Delay(2000);
        }
    }
}
