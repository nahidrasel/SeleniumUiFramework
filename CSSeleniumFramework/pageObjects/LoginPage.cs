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
        //driver.FindElement(By.Id("username")).SendKeys("rahulshettyacademy");
        //driver.FindElement(By.XPath("//div[@class='form-group'][5]/label/span/input")).Click();
       // driver.FindElement(By.XPath("//input[@value='Sign in']")).Click();


        private IWebDriver driver;
        
        public LoginPage(IWebDriver driver)
        {
            this.driver = driver;
            PageFactory.InitElements(driver,this);
        }

        //pageObject Factory Model

        [FindsBy(How = How.Id, Using = "username")]
        private IWebElement username;
        [FindsBy(How = How.Id, Using = "password")]
        private IWebElement password;


        [FindsBy(How = How.XPath, Using = "//div[@class='form-group'][5]/label/span/input")]
        private IWebElement checkBox;

        [FindsBy(How = How.CssSelector, Using = "input[@value='Sign in']")]
        private IWebElement signInButton;


        //page object Model
        public void validLogin(string user, string pass)
        {
            username.SendKeys(user);
            password.SendKeys(pass);
            checkBox.Click();
            signInButton.Click();
        }
        public IWebElement getUserName()
        {
            return username;
        }
    }
}
