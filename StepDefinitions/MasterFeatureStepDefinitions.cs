using Newtonsoft.Json.Linq;
using PlayWrightSpecFlow.Drivers;
using PlayWrightSpecFlow.Pages;
using System;
using System.Runtime.CompilerServices;
using System.Security.Policy;
using TechTalk.SpecFlow;

namespace PlayWrightSpecFlow.StepDefinitions
{
    [Binding]
    public class MasterFeatureStepDefinitions
    {
        private readonly Driver _driver;
        private readonly MasterPage _globalPage;
       

        public MasterFeatureStepDefinitions(Driver driver)
        {
            _driver = driver;
            _globalPage = new MasterPage(_driver.Page);
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
        
  

        [StepDefinition(@"I redirected to the next page with URL ""([^""]*)""")]
        public async Task ThenIRedirectedToTheNextPageWithURL(string uRL)
        {
            await _globalPage.VerifyPageURL(uRL);
        }

        [StepDefinition(@"I fill ""([^""]*)"" in the input field ""([^""]*)"" with the locator ""([^""]*)""")]
        public async Task ThenIFillInTheInputFieldWithTheLocator(string inputValue, string inputField, string locator)
        {
            await _globalPage.FillInText(locator, inputValue);
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

        [StepDefinition(@"I click button ""([^""]*)"" with locator ""([^""]*)"" and verify alert message ""([^""]*)""")]
        public async Task WhenIClickButtonWithLocatorAndVerifyAlertMessage(string p0, string locator, string expectedMsg)
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

        [StepDefinition(@"I verify the text ""([^""]*)"" in the table with locator ""([^""]*)""")]
        public async Task GivenIVerifyTheTextInTheTableWithLocator(string text, string locator)
        {
            await _globalPage.VerifyWebTableHasText(locator, text);
        }


        [StepDefinition(@"I sort table with table locator ""([^""]*)"" using column ""([^""]*)""")]
        public async Task GivenISortTableWithTableLocatorUsingColumn(string tableLocator, string columnLocator)
        {
            await _globalPage.SortTable(tableLocator, columnLocator);
        }

        [StepDefinition(@"I verify column with column name and index ""([^""]*)"" is sorted for table locator ""([^""]*)""")]
        public async void GivenIVerifyColumnWithColumnNameAndIndexIsSortedForTableLocator(string columnIndex, string tableLocator)
        {
            await _globalPage.VerifySortDataTable(tableLocator, columnIndex);   
        }




        [StepDefinition(@"I click element ""([^""]*)"" to open New Tab/Window and verify Text ""([^""]*)"" in the new tab with locator""([^""]*)""")]
        public async Task GivenIClickElementToOpenNewTabWindowAndVerifyTextInTheNewTabWithLocator(string locator1, string expectedTxt, string locator2)
        {
            await _globalPage.VerifyTextNewTab(locator1, locator2, expectedTxt);
        }

        [StepDefinition(@"I verify text ""([^""]*)"" in the iFrame ""([^""]*)"" with locator ""([^""]*)""")]
        public async void ThenIVerifyTextInTheIFrameWithLocator(string text, string iFrame, string locator)
        {
            await _globalPage.VerifyTextInIFrame(iFrame, locator, text);
        }

        [StepDefinition(@"I click the element ""([^""]*)"" in the iFrame ""([^""]*)"" with locator ""([^""]*)""")]
        public async Task ThenIClickTheElementInTheIFrameWithLocator(string element, string iFrame, string locator)
        {
            await _globalPage.ClickElementIFrame(iFrame, locator);
        }
        [StepDefinition(@"I fill in text ""([^""]*)"" in the auto complete locator ""([^""]*)""")]
        public async void GivenIFillInTextInTheAutoCompleteLocator(string text, string locator)
        {
            await _globalPage.FillInAutoComplete(locator, text);
        }

        [StepDefinition(@"I select options ""([^""]*)"" from the drop down menu with locator ""([^""]*)""")]
        public async Task GivenISelectOptionsFromTheDropDownMenuWithLocator(string option, string locator)
        {
            await _globalPage.SelectItemsFromDropDown(locator, option);
        }








    }
}
