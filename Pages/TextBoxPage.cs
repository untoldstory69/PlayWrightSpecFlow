using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlayWrightSpecFlow.Pages
{

    internal class TextBoxPage: PageTest
    {
        private readonly IPage _page;
        private readonly ILocator _fullName;
        private readonly ILocator _email;
        private readonly ILocator _btnSubmit;
        private readonly ILocator _responseName;

        public TextBoxPage(IPage page)
        {
            _page = page;
            _fullName = _page.Locator("#userName");
            _email = _page.Locator("#userEmail");
            _btnSubmit = _page.Locator("#submit");
            _responseName = _page.Locator("#name");
        }

        public async Task EnterDetails(string fullName, string email)
        {
            await _fullName.FillAsync(fullName);
            await _email.FillAsync(email);
        }

        public async Task ClickSubmitBtn() => await _btnSubmit.ClickAsync();
        public async Task VerifySubmitButtonClicked(string name) => await Expect(_responseName).ToHaveTextAsync(name);
    }
}
