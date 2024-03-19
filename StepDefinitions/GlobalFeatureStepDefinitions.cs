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

        [StepDefinition(@"I open the browser with URL ""([^""]*)""")]
        public void GivenIOpenTheBrowserWith(string URL)
        {
            _driver.Page.GotoAsync(URL);
        }

        [StepDefinition(@"I open the browser with URL ""([^""]*)"" with window size ""([^""]*)"" \* ""([^""]*)""")]
        public void GivenIOpenTheBrowserWithURLWithWindowSize(string URL, int width, int height)
        {
            _driver.Page.GotoAsync(URL);
            _driver.Page.SetViewportSizeAsync(width, height);
        }
        
        [StepDefinition(@"I fill in the input field ""([^""]*)"" with the input value ""([^""]*)""")]
        public async Task GivenIFillInTheInputFieldWithTheInputValue(string locator, string value)
        {
            
            await _globalPage.FillInText(locator, value);
        }

       
        [StepDefinition(@"I click button ""([^""]*)""")]
        public async Task WhenIClickButton(string btnLocator)
        {
            await _globalPage.ClickButton(btnLocator);
        }

        
        [StepDefinition(@"I check the element ""([^""]*)"" with element locator ""([^""]*)""in the checkbox")]
        public async Task GivenICheckTheElementWithElementLocatorInTheCheckbox(string elementName, string elementLocator)
        {
            await _globalPage.CheckTheElement(elementLocator);
        }

        [StepDefinition(@"I verify the element ""([^""]*)"" with element locator ""([^""]*)"" is checked")]
        public async Task GivenIVerifyTheElementWithElemenLocatorIsChecked(string elementName, string locator)
        {
            await _globalPage.VerifyCheckBoxIsChecked(locator);
        }

        [StepDefinition(@"I uncheck the element ""([^""]*)"" with element locator ""([^""]*)"" in the checkbox")]
        public async Task ThenIUncheckTheElementWithElementLocatorInTheCheckbox(string home, string locator)
        {
            await _globalPage.UnCheckTheElement(locator);
        }

        [StepDefinition(@"I verify the element ""([^""]*)"" with element locator ""([^""]*)"" is unchecked")]
        public async Task ThenIverifyTheElementWithElementLocatorIsUnchecked(string home, string locator)
        {
            await _globalPage.VerifyCheckBoxIsUnChecked(locator);
        }

        [StepDefinition(@"I check the radio button ""([^""]*)"" with the element locator ""([^""]*)""")]
        public async Task WhenICheckTheRadioButtonWithTheElementLocator(string p0, string locator)
        {
            await _globalPage.CheckRadioButton(locator);
        }

        [StepDefinition(@"I verify the radio button ""([^""]*)"" with the element locator ""([^""]*)"" is checked")]
        public async Task ThenIVerifyTheRadioButtonWithTheElementLocatorIsChecked(string p0, string locator)
        {
            await _globalPage.VerifyRadioBtnIsChecked(locator);    
        }









    }
}
