using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSSeleniumFramework.pageObjects
{
    public class LoginPage
    {
        //driver.FindElement(By.Id("username"))
        //By.Id("username"))

        //.SendKeys("rahulshettyacademy");
        private IWebDriver driver;
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        //pageObject Factory

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;
        public IWebElement getUserName()
        {
            return username;
        }
    }
}
