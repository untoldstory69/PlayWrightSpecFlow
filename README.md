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

### Attaching screenshot in the allure report when test fails
		Hook.cs is updated accordingly.


### Replace Given, When and Then in the step definition with StepDefinition, so that the steps won't be GWT specific.

### Using Playwright debug mode
		Open the pwsh in the project folder (simply go to the project folder if file explorer and type pwsh in file path and hit enter)
		powershell will open
		Enter:
			$env:PWDEBUG=1
			dotnet test
			 >>> if you want to run specific test then enter
					dotnet test --filter "TextBox"