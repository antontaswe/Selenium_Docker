using System;
using NUnit.Framework;
using OpenQA.Selenium;

namespace SeleniumDockerTests
{
    [TestFixture]
    public class ChromeTesting :Hooks
    {
        public ChromeTesting():base(BrowserType.Chrome)
        {

        }

        [Test]
        public void ChromeGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("BTH University");
            Driver.FindElement(By.Name("btnK")).Click();
            Assert.That(Driver.PageSource.Contains("BTH"), Is.EqualTo(true), "The Text BTH doesn't exists");
        }
    }

    [TestFixture]
    public class FirefoxTesting:Hooks
    {
        public FirefoxTesting() : base(BrowserType.Firefox)
        {

        }

        [Test]
        public void FirefoxGoogleTest()
        {
            Driver.Navigate().GoToUrl("http://www.google.com");
            Driver.FindElement(By.Name("q")).SendKeys("BTH University");
            Driver.FindElement(By.Name("btnK")).Click();
            Assert.That(Driver.PageSource.Contains("BTH"), Is.EqualTo(true), "The Text BTH doesn't exists");
        }
    }
}
