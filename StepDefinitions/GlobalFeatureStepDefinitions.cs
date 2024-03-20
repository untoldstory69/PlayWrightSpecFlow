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

       
      
        [StepDefinition(@"I click ""([^""]*)"" button with locator ""([^""]*)""")]
        public async Task GivenIClickButtonWithLocator(string buttonName, string btnLocator)
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

      
        [StepDefinition(@"I click ""([^""]*)"" button with text ""([^""]*)"" of Nth ""([^""]*)"" element")]
        public async Task WhenIClickButtonWithTextOfNthElement(string clickMe, string buttonName, int n)
        {
            await _globalPage.ClickButtonWithText(buttonName, n); ;
        }


        [StepDefinition(@"I verify message ""([^""]*)"" is shown on locator ""([^""]*)""")]
        public async Task ThenIVerifyMessageIsShownOnLocator(string message, string locator)
        {
            await _globalPage.VerifyMessageShown(message, locator);
        }

        [StepDefinition(@"I double click ""([^""]*)"" button with locator ""([^""]*)""")]
        public async Task WhenIDoubleClickButtonWithLocator(string p0, string locator)
        {
            await _globalPage.DoubleClickButton(locator);
        }

        [StepDefinition(@"I right click ""([^""]*)"" button with locator ""([^""]*)""")]
        public async Task WhenIRightClickButtonWithLocator(string p0, string locator)
        {
            await _globalPage.RightClickButton(locator);
        }

        [StepDefinition(@"I upload file ""([^""]*)"" with locator ""([^""]*)""")]
        public async Task WhenIUploadFileWithLocator(string fileName, string locator)
        {
            await _globalPage.UploadFile(fileName, locator);
        }

        [StepDefinition(@"I click alert button ""([^""]*)"" with locator ""([^""]*)"" and verify alert message ""([^""]*)""")]
        public async Task WhenIClickAlertButtonWithLocatorAndVerifyAlertMessage(string p0, string locator, string expectedMsg)
        {
            await _globalPage.ClickAlertVerifyMsg(locator, expectedMsg);
        }


        [StepDefinition(@"I click confirmation alert box ""([^""]*)"" with locator ""([^""]*)"" and click OK with text \(optional\) ""([^""]*)""")]
        public async Task GivenIClickConfirmationAlertBoxWithLocatorAndClickOKWithTextOptional(string confirm, string locator, string text)
        {
            await _globalPage.ClickOKConfirmationAlert(locator, text);
        }

        [StepDefinition(@"I click confirmation alert box ""([^""]*)"" with locator ""([^""]*)"" and click Cancel")]
        public async Task GivenIClickConfirmationAlertBoxWithLocatorAndClickCancel(string confirm, string locator)
        {
            await _globalPage.ClickCancelConfirmationAlert(locator);
        }






    }
}
