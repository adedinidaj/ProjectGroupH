using ProjectGroupH.PageObjects;
using System;
using TechTalk.SpecFlow;

namespace ProjectGroupH.StepDefinitions
{
    [Binding]
    public class DataDrivenRegistrationSteps
    {
        DataDrivenRegistrationPage dataDrivenRegistrationPage;

        public DataDrivenRegistrationSteps()
        {
            dataDrivenRegistrationPage = new DataDrivenRegistrationPage();
        }


        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenRegistrationPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter my Username ""(.*)""")]
        public void GivenIEnterMyUsername(string username)
        {
            dataDrivenRegistrationPage.EnterUsername(username);
        }
        
        [Given(@"I enter my Email ""(.*)""")]
        public void GivenIEnterMyEmail(string email)
        {
            dataDrivenRegistrationPage.EnterEmail(email);
        }
        
        [Given(@"I enter my Password ""(.*)""")]
        public void GivenIEnterMyPassword(string password)
        {
            dataDrivenRegistrationPage.EnterPassword(password);
        }
    }
}
