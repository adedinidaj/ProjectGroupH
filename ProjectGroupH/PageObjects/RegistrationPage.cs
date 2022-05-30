using OpenQA.Selenium;
using ProjectGroupH.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGroupH.PageObjects
{
    class RegistrationPage
    {
        public RegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

        IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

        IWebElement GlobalFeed => driver.FindElement(By.CssSelector("body > div > div > div > div.container.page > div > div.col-md-9 > div > ul > li:nth-child(2) > a"));

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://angularjs.realworld.io/#/");
        }

        public void ClickOnSignUp()
        {
            SignUp.Click();
        }

        public void EnterUsername()
        {
            Username.SendKeys("testing31");
        }

        public void EnterEmail()
        {
            Email.SendKeys("testing31@gmail.com");
        }

        public void EnterPassword()
        {
            Password.SendKeys("testing");
        }

        public void ClickOnSignUpButton()
        {
            SignUpButton.Click();
        }

        public bool GlobalFeedDisplayed()
        {
            return GlobalFeed.Selected;
        }
  

    }
}
