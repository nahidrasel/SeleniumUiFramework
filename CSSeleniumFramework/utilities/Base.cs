using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

using WebDriverManager.DriverConfigs.Impl;

namespace CSSeleniumFramework.utilities
{
    public  class Base
    {
       public IWebDriver driver;
        [SetUp]
        public void StartBrowser()
        {
            new WebDriverManager.DriverManager().SetUpDriver(new ChromeConfig());
            driver = new ChromeDriver();

            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(5);

            driver.Manage().Window.Maximize();

            driver.Url = "https://rahulshettyacademy.com/loginpagePractise/";

        }

    }
}
