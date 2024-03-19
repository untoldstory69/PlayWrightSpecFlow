﻿using Allure.Net.Commons;
using Microsoft.Playwright;
using Microsoft.Playwright.NUnit;
using NUnit.Framework;
using PlayWrightSpecFlow.Drivers;
using PlayWrightSpecFlow.Pages;
using System.Reflection;
using TechTalk.SpecFlow;
using static System.Net.Mime.MediaTypeNames;
[assembly: Parallelizable(ParallelScope.Fixtures)]
namespace PlayWrightSpecFlow.Hooks
{
    [Binding]
    public sealed class Hooks
    {
        private readonly Driver _driver;
        public Hooks(Driver driver)
        {
            _driver = driver;

        }
        [AfterStep]
        public async Task AfterStep(ScenarioContext context) { 
            if (context.TestError != null)
            {
                var path = Path.GetDirectoryName(Assembly.GetEntryAssembly().Location);
                var screenShotName = "failedTest.png";
                  await _driver.Page.ScreenshotAsync(new PageScreenshotOptions
                    {
                        Path = screenShotName
                    });

                    AllureApi.AddAttachment("TestScreenShot", "image/png", path + "\\" + screenShotName);
                
            }

        }
       
    } 
}