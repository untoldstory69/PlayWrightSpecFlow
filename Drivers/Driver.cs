using Microsoft.Playwright;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayWrightSpecFlow.Drivers
{

    public class Driver : IDisposable
    {

        private readonly Task<IPage> _page;
        
        private IBrowser? _browser;
        public Driver()
        {
            _page = InitializePlaywright();
        }

        public IPage Page => _page.Result;

        // creating/initializing playwright
        private async Task<IPage> InitializePlaywright()
        {
            //Playwright >>> it will start downaloding things for us for automation.
            var playwright = await Playwright.CreateAsync();

            //create browser instance
            _browser = await playwright.Chromium.LaunchAsync(new BrowserTypeLaunchOptions
            {
                Headless = false,
                SlowMo = 100

            });
            

            //create page instance
            return await _browser.NewPageAsync();
        }
        public void Dispose() => _browser?.CloseAsync();


    }
}
