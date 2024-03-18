using PlayWrightSpecFlow.Drivers;
using PlayWrightSpecFlow.Pages;
using System;
using TechTalk.SpecFlow;

namespace PlayWrightSpecFlow.StepDefinitions
{
    [Binding]
    public class LoginFeatureStepDefinitions
    {
        private readonly Driver _driver;
        private readonly HomePage _homePage;
        private readonly LoginPage _loginPage;  
        private readonly MainPage _mainPage;
   
        public LoginFeatureStepDefinitions(Driver driver) 
        {
            _driver = driver;
            _homePage = new HomePage(_driver.Page);
            _loginPage = new LoginPage(_driver.Page);
            _mainPage = new MainPage(_driver.Page);
        }

        [Given(@"I am on the login page")]
        public void GivenIAmOnTheLoginPage()
        {
             _driver.Page.GotoAsync(GlobalVariables.baseURL);
            _mainPage.ClickBookStoreApplication();
            _mainPage.ClickLogin();
        }

        [Given(@"I enter valid ""([^""]*)"" and ""([^""]*)""")]
        public  async Task GivenIEnterValidAnd(string username, string password)
        {
            await _loginPage.EnterUserNamePassword("untoldstory", "Pikachu@123");

        }
        [When(@"I click ""([^""]*)"" button")]
        public async Task WhenIClickButton(string login)
        {
            await _loginPage.ClickBtnLogin();
        }

        [Then(@"I should be logged in successfully")]
        public async Task ThenIShouldBeLoggedInSuccessfully()
        {
            await _homePage.VerifyUserLoggedIn("untoldstory");
        }
    }
}
