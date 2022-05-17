using CSSeleniumFramework.utilities;
using NUnit.Framework;
using System;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using System.Linq;
using AngleSharp.Text;
using System.Collections.Generic;
using CSSeleniumFramework.pageObjects;

namespace CSSeleniumFramework
{
    public class E2ETests : Base
    {
        [Test]
        public void EndToEndFlow()
        {
            String[] expectedProducts = { "iphone X", "Blackberry" };
            String[] actualProducts = new string[2];

            LoginPage loginPage = new LoginPage(getDriver());

            loginPage.validLogin("rahulshettyacademy", "learning");
            
            WebDriverWait wait = new WebDriverWait(driver, TimeSpan.FromSeconds(8));

            wait.Until(SeleniumExtras.WaitHelpers.ExpectedConditions.ElementIsVisible(driver.Value.FindElement(By.Id("signInBtn")), "Sign In"));

            IList<WebElement> products = driver.FindElements(By.TagName("app-card"));
            foreach (IWebElement product in products)
            {
                if (expectedProducts.Contains(product.FindElement(By.CssSelector(".card-footer button"))
                {
                    product.FindElement(By.CssSelector(".card-footer button")).Click();
                }
                TestContext.Progress.WriteLine(product.FindElement(By.CssSelector(".card-footer button"))
            }
        }

    }

    [Test]
        public void Test1()
        {
            Assert.Pass();
        }
    }
}