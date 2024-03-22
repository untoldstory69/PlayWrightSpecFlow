using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightSpecFlow
{
    internal class Helper
    {
        public async Task<bool> VerifyTextInTable(IPage page, IElementHandle table, string searchText)
        {
            await page.WaitForLoadStateAsync();
            // Get all table rows
            var rows = await table.QuerySelectorAllAsync("tr");

            // Loop through each row to find the desired text
            foreach (var row in rows)
            {
                // Get all cells in the row
                var cells = await row.QuerySelectorAllAsync("td");

                // Loop through each cell to check for the desired text
                foreach (var cell in cells)
                {
                    // Get the text content of the cell
                    var cellText = await cell.TextContentAsync();

                    // Check if the cell text contains the desired text
                    if (cellText.Contains(searchText))
                    {
                        return true; // Desired text found
                    }
                }
            }
            return false;
        }

        
    }
}

