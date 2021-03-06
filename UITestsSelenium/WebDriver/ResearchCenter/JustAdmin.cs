// Generated by Selenium IDE
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using Xunit;

namespace UITestSelenium.WebDriver.ResearchCenter
{
    public class JustAdmin : IDisposable
    {
        public IWebDriver driver { get; private set; }
        public IDictionary<String, Object> vars { get; private set; }
        public IJavaScriptExecutor js { get; private set; }
        public JustAdmin()
        {
            driver = new ChromeDriver();
            js = (IJavaScriptExecutor)driver;
            vars = new Dictionary<String, Object>();
        }
        public void Dispose()
        {
            driver.Quit();
        }
        [Fact]
        public void JustAdminGroupTest()
        {
            driver.Navigate().GoToUrl("https://localhost:44331/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
            driver.FindElement(By.CssSelector(".mud-toolbar")).Click();
            driver.FindElement(By.LinkText("Iniciar Sesión")).Click();
            {
                var element = driver.FindElement(By.LinkText("Iniciar Sesión"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element).Perform();
            }
            {
                var element = driver.FindElement(By.TagName("body"));
                Actions builder = new Actions(driver);
                builder.MoveToElement(element, 0, 0).Perform();
            }
            driver.FindElement(By.CssSelector(".mud-grid-item:nth-child(2) .mud-input-slot")).Click();
            driver.FindElement(By.CssSelector(".mud-grid-item:nth-child(2) .mud-input-slot")).SendKeys("Prueba@ucr.ac.cr");
            driver.FindElement(By.CssSelector(".mud-input-root-adorned-end")).Click();
            driver.FindElement(By.CssSelector(".mud-input-root-adorned-end")).SendKeys("Prueba123@");
            driver.FindElement(By.CssSelector(".mud-button-filled > .mud-button-label")).Click();
            driver.FindElement(By.CssSelector(".mud-nav-item:nth-child(3) .mud-nav-link-text:nth-child(1)")).Click();
            driver.FindElement(By.CssSelector(".mud-grid-item-xs-12")).Click();
            Assert.Equal(driver.FindElement(By.CssSelector(".mud-typography-h6")).Text, "Grupos de este Centro");
            driver.FindElement(By.CssSelector(".mud-input-slot")).Click();
            {
                IReadOnlyCollection<IWebElement> elements = driver.FindElements(By.CssSelector(".mud-input-slot"));
                Assert.True(elements.Count > 0);
            }
            Assert.True(driver.FindElement(By.CssSelector(".mud-table-row:nth-child(1) .mud-switch-input")).Selected);
        }
    }
}
