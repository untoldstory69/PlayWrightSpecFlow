# PlayWrightSpecFlow

Add extntions specflow if you haven't already.

Create a new project and select specflow template and select nunit framework. also add fluent assertion.

Install package Microsoft.Playwright.NUnit

Create a Driver.cs class
	### Driver pattern is simply an additional layer between your steps defintions and your automation code.
		Driver object can be used all across the project.

Create Feature File

Create StepDefinitions for those feature files

Run test in parallel
	Add hook.cs file 
		add> [assembly: Parallelizable(ParallelScope.Fixtures)]