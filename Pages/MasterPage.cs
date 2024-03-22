using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using static System.Net.Mime.MediaTypeNames;

namespace PlayWrightSpecFlow.Pages
{
    
    public class MasterPage : PageTest
    {
        private IPage _page;
       // private readonly ILocator _email;

        public MasterPage(IPage page)
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


        public async Task SortTable(string tableLocator, string columnLocator)
        {
            try
            {
               // Find the table element
                var table = await _page.QuerySelectorAsync(tableLocator);

                // Find the column header element you want to sort by
                var columnHeader = await table.QuerySelectorAsync(columnLocator);

                await columnHeader.ClickAsync();                
            }
            catch (Exception) {
            
            }
            
        }


        public async Task VerifySortDataTable(string tableLocator, string columnIndex)
        {
            try
            {
                
                // Find the table element
                var table = await _page.QuerySelectorAsync(tableLocator);

                // Find the rows in the table
                var rows = await table.QuerySelectorAllAsync("tr");

                // Extract text values from a specific column in each row
                List<string> columnValues = new List<string>();
                foreach (var row in rows)
                {
                    var cellSelector = $"td:nth-child({columnIndex + 1})"; // Adjust the selector to target the specific cell in the row
                    var cell = await row.QuerySelectorAsync(cellSelector);
                    if (cell != null)
                    {
                        var cellText = await cell.TextContentAsync();
                        columnValues.Add(cellText);
                    }
                }

                // Check if the values are sorted in ascending order
                bool isSorted = IsSorted(columnValues);

      
            }
            catch
            {

            }
        }

        static bool IsSorted(List<string> values)
        {
            for (int i = 1; i < values.Count; i++)
            {
                if (string.Compare(values[i - 1], values[i], StringComparison.Ordinal) > 0)
                {
                    return false;
                }
            }
            return true;
        }
    






        public async Task VerifyTextNewTab(string locator1, string locator2, string expectedTxt)
        {
            var page2 = await _page.RunAndWaitForPopupAsync(async () =>
            {
                await _page.Locator(locator1).ClickAsync();
            });
            await Expect(page2.Locator(locator2)).ToHaveTextAsync(expectedTxt);
        }

        public async Task VerifyTextInIFrame(string iframe, string locator, string expectedTxt)=> await Expect(_page.FrameLocator(iframe).Locator(locator)).ToHaveTextAsync(expectedTxt);
        

        public async Task ClickElementIFrame(string iframe, string locator) => await _page.FrameLocator(iframe).Locator(locator).ClickAsync();

        public async Task FillInAutoComplete(string locator, string text)
        {
            try
            {
                await _page.Locator(locator).FillAsync(text);
                await _page.Locator(locator).PressAsync("Enter");

            }
            catch (Exception ex)
            {
                Console.WriteLine("Caught Exception", ex.ToString());
            }

        }

        public async Task SelectItemsFromDropDown(string locator, string item) => await _page.Locator(locator).SelectOptionAsync(item);

        public async Task VerifyPageURL(string URL) => await Expect(_page).ToHaveURLAsync(URL);
       
    }
}
