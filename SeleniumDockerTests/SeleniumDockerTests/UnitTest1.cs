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
        public void TestAppTitle()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Assert.That(Driver.PageSource.Contains("Take Notes"), Is.EqualTo(true), "The text Take Notes doesn't exists");
        }

        [Test]
        public void TestNewNoteSave()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Driver.FindElement(By.Id("new")).Click();
            Driver.FindElement(By.Name("title")).SendKeys("This is a title");
            Driver.FindElement(By.Name("description")).SendKeys("This is a description");
            Driver.FindElement(By.Id("save")).Click();
        }

        [Test]
        public void TestNewNoteCancel()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Driver.FindElement(By.Id("new")).Click();
            Driver.FindElement(By.Name("title")).SendKeys("This is a temporary title");
            Driver.FindElement(By.Name("description")).SendKeys("This is a temporary description");
            Driver.FindElement(By.Id("cancel")).Click();
        }

        [Test]
        public void TestDeleteNote()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Driver.FindElement(By.Id("new")).Click();
            Driver.FindElement(By.Name("title")).SendKeys("This is a title");
            Driver.FindElement(By.Name("description")).SendKeys("This is a description");
            Driver.FindElement(By.Id("save")).Click();
            Driver.FindElements(By.ClassName("btn-danger"))[0].Click();
        }

    }

    [TestFixture]
    public class FirefoxTesting:Hooks
    {
        public FirefoxTesting() : base(BrowserType.Firefox)
        {

        }

        [Test]
        public void TestAppTitle()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Assert.That(Driver.PageSource.Contains("Take Notes"), Is.EqualTo(true), "The text Take Notes doesn't exists");
        }

        [Test]
        public void TestNewNoteSave()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Driver.FindElement(By.Id("new")).Click();
            Driver.FindElement(By.Name("title")).SendKeys("This is a title");
            Driver.FindElement(By.Name("description")).SendKeys("This is a description");
            Driver.FindElement(By.Id("save")).Click();
        }

        [Test]
        public void TestNewNoteCancel()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Driver.FindElement(By.Id("new")).Click();
            Driver.FindElement(By.Name("title")).SendKeys("This is a temporary title");
            Driver.FindElement(By.Name("description")).SendKeys("This is a temporary description");
            Driver.FindElement(By.Id("cancel")).Click();
        }

        [Test]
        public void TestDeleteNote()
        {
            Driver.Navigate().GoToUrl("http://bth_demo:3000");
            Driver.FindElement(By.Id("new")).Click();
            Driver.FindElement(By.Name("title")).SendKeys("This is a title");
            Driver.FindElement(By.Name("description")).SendKeys("This is a description");
            Driver.FindElement(By.Id("save")).Click();
            Driver.FindElements(By.ClassName("btn-danger"))[0].Click();
        }

    }
}
