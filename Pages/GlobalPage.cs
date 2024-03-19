using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;

namespace PlayWrightSpecFlow.Pages
{
    public class GlobalPage : PageTest
    {
        private IPage _page;
       // private readonly ILocator _email;

        public GlobalPage(IPage page)
        {
            _page = page;
            //_email = _page.Locator("#userEmail");
        }



        public async Task FillInText(string txtLocator, string text) => await _page.Locator(txtLocator).FillAsync(text);

        public async Task ClickButton(string btnLocator) => await _page.Locator(btnLocator).ClickAsync();

        

    }
}
