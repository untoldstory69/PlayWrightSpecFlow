﻿using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlayWrightSpecFlow.Pages
{
    public class LoginPage : PageTest
    {
        private IPage _page;
        
        private readonly ILocator _txtUserName;
        private readonly ILocator _txtPassword;
        private readonly ILocator _btnLogin;
        private readonly ILocator _msgError;
        
        public LoginPage(IPage page)
        {
            _page = page;

            _txtUserName = _page.Locator("#userName");
            _txtPassword = _page.Locator("#password");
            _btnLogin = _page.Locator("id=login");
            _msgError = _page.Locator("#name");
        }

        public async Task EnterUserNamePassword (string username, string password)
        {
            await _txtUserName.FillAsync(username);
            await _txtPassword.FillAsync(password);
            
        }

        public async Task ClickBtnLogin() => await _btnLogin.ClickAsync();

        public async Task VerifyUserIsNotLoggedIn() => await Expect(_msgError).ToHaveTextAsync("Invalid username or password!");
    }
}
