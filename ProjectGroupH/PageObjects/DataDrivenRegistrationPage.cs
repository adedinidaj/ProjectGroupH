using OpenQA.Selenium;
using ProjectGroupH.Utilities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ProjectGroupH.PageObjects
{
    class DataDrivenRegistrationPage
    {
        public DataDrivenRegistrationPage()
        {
            driver = Hooks1.driver;
        }

        IWebDriver driver;

       // IWebElement SignUp => driver.FindElement(By.XPath("/html/body/div/app-header/nav/div/ul[1]/li[3]/a"));
        IWebElement Username => driver.FindElement(By.XPath("/html/body/div/div/div/div/div/div/form/fieldset/fieldset[1]/input"));

        IWebElement Email => driver.FindElement(By.XPath("//input[@type='email']"));

        IWebElement Password => driver.FindElement(By.XPath("//input[@placeholder='Password']"));

        //IWebElement SignUpButton => driver.FindElement(By.XPath("//button[text()='Sign up']"));

       // IWebElement NewArticle => driver.FindElement(By.XPath("(//a[@class='nav-link'])[3]"));

        public void NavigateToWebsite(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        //public void ClickOnSignUp()
        //{
        //    SignUp.Click();
        //}

        public void EnterUsername(string username)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Username.SendKeys(username + randomInt);
            //Username.SendKeys(username);
        }

        public void EnterEmail(string email)
        {
            Random randomGenerator = new Random();
            int randomInt = randomGenerator.Next(1000);
            Email.SendKeys(email + randomInt + "@gmail.com");
            //Email.SendKeys(email);
        }

        public void EnterPassword(string password)
        {
            Password.SendKeys(password);
        }

        //public void ClickOnSignUpButton()
        //{
        //    SignUpButton.Click();
        //}

        //public bool IsNewArticleDisplayed()
        //{
        //    return NewArticle.Displayed;
        //}


    }
}
