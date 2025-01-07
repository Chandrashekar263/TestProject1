using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace TestProject1
{
    [TestClass]
    public  class Meshoo
    {
        [TestMethod]
        public void TestMethod1()
        {
            WebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.meesho.com/");
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
            driver.FindElement(By.XPath("//span[text()='Women Western']")).Click();
            IWebElement jeans = driver.FindElement(By.XPath("//p[text()='Jeans & Jeggings']"));
            Actions action = new Actions(driver);
            action.MoveToElement(jeans).Click().Perform();
            IWebElement ts = driver.FindElement(By.XPath("//p[text()='Classic Elegant Women Jeans']"));
            IJavaScriptExecutor je = (IJavaScriptExecutor)driver;
            je.ExecuteScript("arguments[0].click();", ts);
            driver.FindElement(By.XPath("(//span[@class='SingleChip__StyledChip-sc-g3p1gd-0 bfRnQN'])[1]")).Click();
            driver.FindElement(By.XPath("//span[text()='Buy Now']")).Click();
            driver.Quit();
        }
    }
}
