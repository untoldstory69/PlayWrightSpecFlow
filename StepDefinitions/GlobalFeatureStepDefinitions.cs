using PlayWrightSpecFlow.Drivers;
using PlayWrightSpecFlow.Pages;
using System;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace PlayWrightSpecFlow.StepDefinitions
{
    [Binding]
    public class GlobalFeatureStepDefinitions
    {
        private readonly Driver _driver;
        private readonly GlobalPage _globalPage;
       

        public GlobalFeatureStepDefinitions(Driver driver)
        {
            _driver = driver;
            _globalPage = new GlobalPage(_driver.Page);
        }

        [Given(@"I open the browser with URL ""([^""]*)""")]
        public void GivenIOpenTheBrowserWith(string URL)
        {
            _driver.Page.GotoAsync(URL);
        }

        [Given(@"I open the browser with URL ""([^""]*)"" with window size ""([^""]*)"" \* ""([^""]*)""")]
        public void GivenIOpenTheBrowserWithURLWithWindowSize(string URL, int width, int height)
        {
            _driver.Page.GotoAsync(URL);
            _driver.Page.SetViewportSizeAsync(width, height);
        }
        
        [Given(@"I fill in the input field ""([^""]*)"" with the input value ""([^""]*)""")]
        public async Task GivenIFillInTheInputFieldWithTheInputValue(string locator, string value)
        {
            
            await _globalPage.FillInText(locator, value);
        }

       
        [When(@"I click button ""([^""]*)""")]
        public async Task WhenIClickButton(string btnLocator)
        {
            await _globalPage.ClickButton(btnLocator);
        }

        
        [Given(@"I check the element ""([^""]*)"" with element locator ""([^""]*)""in the checkbox")]
        public async Task GivenICheckTheElementWithElementLocatorInTheCheckbox(string elementName, string elementLocator)
        {
            await _globalPage.CheckTheElement(elementLocator);
        }

        [Given(@"I verify the element ""([^""]*)"" with element locator ""([^""]*)"" is checked")]
        public async Task GivenIVerifyTheElementWithElemenLocatorIsChecked(string elementName, string locator)
        {
            await _globalPage.VerifyCheckBoxIsChecked(locator);
        }





    }
}
