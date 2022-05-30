using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TechTalk.SpecFlow;

namespace ProjectGroupH.Utilities
{
    [Binding]
    public class Hooks1
    {
        public static IWebDriver driver;

        [BeforeScenario]
        public void BeforeScenario()
        {
            //What I want the driver to do before it runs the test
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [AfterScenario]
        public void AfterScenario()
        {
            //What I want the driver to do after the test has finished
            //driver.Quit();
        }
    }
}
