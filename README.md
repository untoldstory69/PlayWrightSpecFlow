# PlayWrightSpecFlow

## Add extntions specflow if you haven't already.

## Create a new project and select specflow template and select nunit framework. also add fluent assertion.

## Install package Microsoft.Playwright.NUnit

## Create a Driver.cs class
	### Driver pattern is simply an additional layer between your steps defintions and your automation code.
		Driver object can be used all across the project.

## Create Feature File

## Create StepDefinitions for those feature files

## Run test in parallel
	Add hook.cs file 
		add> [assembly: Parallelizable(ParallelScope.Fixtures)]

##  Generate Allure Report
		Allure.SpecFlow from nuget package manager

		Add specflow.json under root folder

		Add allure.config under bin/debug/netx Folder

		Generate result  using following command
			allure generate

		allure serve
			>>> creates the same report as allure generate but puts it into a temporary directory and starts a local web server configured to show this directory's contents. The command then automatically opens the main page of the report in a web browser.
				Use this command if you need to view the report  and do not need to save it.
