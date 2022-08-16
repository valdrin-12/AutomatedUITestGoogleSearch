using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;


namespace GoogleUITest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestSearchStreetfighterthenverifystreetIsDisplayed()
        {
            By googleSearchBar = By.Name("q");
            //IWebElement googleSearchbutton =WebDriver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf.emcav > div.UUbT9 > div.aajZCb > div.CqAVzb.lJ9FBc > center > input.gNO89b"));
           By googleResultText = By.XPath(".//h2//span[text()='Street Fighter V']");


            IWebDriver webDriver = new ChromeDriver();
            //webDriver.Manage().Window.Maximize();
            webDriver.Navigate().GoToUrl("https://www.google.co.uk/");

            IWebElement googleSearchbutton = webDriver.FindElement(By.CssSelector("body > div.L3eUgb > div.o3j99.ikrT4e.om7nvf > form > div:nth-child(1) > div.A8SBwf > div.FPdoLc.lJ9FBc > center > input.gNO89b"));

           // IWebElement googleResultText = webDriver.FindElement(By.XPath(".//h2//span[text()='Street Fighter V']"));

            webDriver.FindElement(googleSearchBar).SendKeys("Street Fighter V");

            googleSearchbutton.Click();
            // webDriver.FindElement(googleSearchbutton).Submit();

            var actualResultText= webDriver.FindElement(googleResultText);
            Assert.IsTrue(actualResultText.Text.Equals("Street Fighter V"));
            webDriver.Quit();   






        }
    }
}
