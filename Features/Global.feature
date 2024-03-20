Feature: Global Feature

This Featue files contains the global features used in web application

@tag1
Scenario: Input Field such as text field, text area
	Given I open the browser with URL "https://demoqa.com/text-box"
	And I fill in the input field "#userName" with the input value "the rock"
	And I fill in the input field "#userEmail" with the input value "test@gmail.com"
	And I fill in the input field "#currentAddress" with the input value "brisbane australia"
	And I fill in the input field "#permanentAddress" with the input value "BNE Australia"
	When I click "Submit" button with locator "#submit"

	
Scenario: Checkbox 
	Given I open the browser with URL "https://demoqa.com/checkbox" with window size "1920" * "1080"
	When I check the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']"in the checkbox
	Then I verify the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']" is checked
	And I uncheck the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']" in the checkbox
	Then I verify the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']" is unchecked

Scenario: Radio button
	Given I open the browser with URL "https://demoqa.com/radio-button" with window size "1920" * "1080" 
	When I check the radio button "element name" with the element locator "//label[@for='impressiveRadio']" 
	Then I verify the radio button "element name" with the element locator "//label[@for='impressiveRadio']" is checked

Scenario: Buttons
	Given I open the browser with URL "https://demoqa.com/buttons" with window size "1920" * "1080"
	When I click "clickMe" button with text "Click Me" of Nth "2" element 
	Then I verify message "You have done a dynamic click" is shown on locator "#dynamicClickMessage"
	When I double click "double click me" button with locator "#doubleClickBtn"
	Then I verify message "You have done a double click" is shown on locator "#doubleClickMessage"
	When I right click "Right Click Me" button with locator "#rightClickBtn"
	Then I verify message "You have done a right click" is shown on locator "#rightClickMessage"

Scenario: Upload File
	Given I open the browser with URL "https://demoqa.com/upload-download" with window size "1920" * "1080"
	When I upload file "C:\Users\kishor.sharma\Downloads\sampleFile.jpeg" with locator "#uploadFile"
	Then I verify message "C:\fakepath\sampleFile.jpeg" is shown on locator "#uploadedFilePath"

Scenario: Alerts
	Given I open the browser with URL "https://testpages.eviltester.com/styled/alerts/alert-test.html"
	When I click alert button "Click Me" with locator "#alertexamples" and verify alert message "I am an alert box!"
	

	

	
	