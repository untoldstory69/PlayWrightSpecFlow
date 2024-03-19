using PlayWrightSpecFlow.Drivers;
using PlayWrightSpecFlow.Pages;
using System;
using TechTalk.SpecFlow;

namespace PlayWrightSpecFlow.StepDefinitions
{
    [Binding]
    public class TextBoxStepDefinitions
    {
        private readonly Driver _driver;
        private readonly TextBoxPage _textBoxPage;
        
        public TextBoxStepDefinitions(Driver driver)
        {
            _driver = driver;
            _textBoxPage = new TextBoxPage(_driver.Page);
         
        }
        [Given(@"I am on the TextBox page")]
        public void GivenIAmOnTheTextBoxPage()
        {
            _driver.Page.GotoAsync("https://demoqa.com/text-box");
        }

        [Given(@"I enter valid detais")]
        public async Task GivenIEnterValidDetais()
        {
            await _textBoxPage.EnterDetails("testFullName", "test@gmail.com");
        }

        [When(@"I click Submit")]
        public async Task WhenIClickSubmit()
        {
            await _textBoxPage.ClickSubmitBtn();
        }

        [Then(@"form should be submitted")]
        public async Task ThenFormShouldBeSubmitted()
        {
            await _textBoxPage.VerifySubmitButtonClicked("Name:testFullName");
        }

        [Then(@"form should be Not submitted")]
        public async Task ThenFormShouldBeNotSubmitted()
        {
            await _textBoxPage.VerifySubmitButtonClicked("Name:testFullName1");
        }

    }
}
