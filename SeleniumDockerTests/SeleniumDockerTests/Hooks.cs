using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumDockerTests
{
    public enum BrowserType
    {
        Chrome,
        Firefox,
        IE
    }

    [TestFixture]
    public class Hooks :Base
    {
        private BrowserType _browserType;

        public Hooks(BrowserType browser)
        {
            _browserType = browser;
        }

        [SetUp]
        public void Intialize()
        {
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowserType browserType)
        {
            if(browserType==BrowserType.Chrome)
            {
                var cap = new ChromeOptions();
                Driver = new RemoteWebDriver(new Uri("http://localhost:4446/wd/hub"), cap);
            }

            else if (browserType == BrowserType.Firefox)
            {
                var cap = new FirefoxOptions();
                Driver = new RemoteWebDriver(new Uri("http://localhost:4446/wd/hub"), cap);
            }
        }

        [TearDown]
        public void Cleanup()
        {
            Driver.Quit();
        }
    }
}
