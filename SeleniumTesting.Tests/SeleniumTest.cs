using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumTesting.Tests
{
    public abstract class SeleniumTest : IISExpressServerTest
    {
        private RemoteWebDriver _remoteWebDriver;
        protected IWebDriver WebDriver
        {
            get { return _remoteWebDriver; }
        }

        protected SeleniumTest(string applicationName) : base(applicationName)
        {
        }

        public override void Initialize()
        {
            _remoteWebDriver = new ChromeDriver();
        }

        public override void Cleanup()
        {
            _remoteWebDriver.Dispose();
        }
    }
}
