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

        public async Task CheckTheElement(string chkLocator) => await _page.Locator(chkLocator).CheckAsync();

        public async Task VerifyCheckBoxIsChecked(string chkLocator) => await _page.Locator(chkLocator).IsCheckedAsync();

        public async Task UnCheckTheElement(string chkLocator) => await _page.Locator(chkLocator).UncheckAsync();

        public async Task VerifyCheckBoxIsUnChecked(string chkLocator) => await _page.Locator(chkLocator)!.IsCheckedAsync();

        public async Task CheckRadioButton(string rbLocator) => await _page.Locator(rbLocator).CheckAsync();

        public async Task VerifyRadioBtnIsChecked(string rbLocator) => await _page.Locator(rbLocator).IsCheckedAsync();

        public async Task ClickButtonWithText(string btnTxt, int n) => await _page.GetByText(btnTxt).Nth(n).ClickAsync();

        public async Task VerifyMessageShown(string message, string locator) => await Expect(_page.Locator(locator)).ToHaveTextAsync(message);

        public async Task DoubleClickButton(string locator) => await _page.Locator(locator).DblClickAsync();

        public async Task RightClickButton(string locator) => await _page.Locator(locator).ClickAsync(new LocatorClickOptions()
        {
            Button = MouseButton.Right
        });
    }
}
