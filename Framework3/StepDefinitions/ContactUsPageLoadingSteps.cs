using System;
using TechTalk.SpecFlow;

namespace Framework3.StepDefinitions
{
    [Binding]
    public class ContactUsPageLoadingSteps
    {
        [Given(@"I am on start page of blog\.io")]
        public void GivenIAmOnStartPageOfBlog_Io()
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I click on Contact Us menu item")]
        public void WhenIClickOnContactUsMenuItem()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"User is redirected to ContactUs page")]
        public void ThenUserIsRedirectedToContactUsPage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
