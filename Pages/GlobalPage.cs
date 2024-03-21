using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

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

        Helper helper = new Helper();



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

        public async Task UploadFile(string fileName, string locator) => await _page.Locator(locator).SetInputFilesAsync(fileName);

        public async Task ClickAlertVerifyMsg(string locator, string expectedMsg)
        {
            void alert(object sender, IDialog dialog)
            {
              
                Assert.That(dialog.Message, Is.EqualTo(expectedMsg)); 
                dialog.DismissAsync();
                _page.Dialog -= alert;
            }
            _page.Dialog += alert;
            await _page.Locator(locator).ClickAsync();
        }

        public async Task ClickOKConfirmationAlert(string locator, string text)
        {
            void alert(object sender, IDialog dialog)
            {
                dialog.AcceptAsync(text);
                _page.Dialog -= alert;
            }
            _page.Dialog += alert;
            await _page.Locator(locator).ClickAsync();
        }

        public async Task ClickCancelConfirmationAlert(string locator)
        {
            void alert(object sender, IDialog dialog)
            {
                dialog.DismissAsync();
                _page.Dialog -= alert;
            }
            _page.Dialog += alert;
            await _page.Locator(locator).ClickAsync();
        }

        public async Task VerifyWebTableHasText( string locator, string expectedTxt)
        {
            
            // Find the table element
            var table = await _page.QuerySelectorAsync(locator);

            // Verify text in the table
            await helper.VerifyTextInTable(_page, table, expectedTxt);
        }

        public async Task VerifyTextNewTab(string locator1, string locator2, string expectedTxt)
        {
            var page2 = await _page.RunAndWaitForPopupAsync(async () =>
            {
                await _page.Locator(locator1).ClickAsync();
            });
            await Expect(page2.Locator(locator2)).ToContainTextAsync(expectedTxt);
        }

        public async Task VerifyTextInIFrame(string iframe, string locator, string expectedTxt)
        {
            await Expect(_page.FrameLocator(iframe).Locator(locator)).ToContainTextAsync(expectedTxt);
        }

        public async Task ClickElementIFrame(string iframe, string locator) => await _page.FrameLocator(iframe).Locator(locator).ClickAsync();



    }
}
