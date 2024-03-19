Feature: Global Feature

This Featue files contains the global features used in web application

@tag1
Scenario: Input Field such as text field, text area
	Given I open the browser with URL "https://demoqa.com/text-box"
	And I fill in the input field "#userName" with the input value "the rock"
	And I fill in the input field "#userEmail" with the input value "test@gmail.com"
	And I fill in the input field "#currentAddress" with the input value "brisbane australia"
	And I fill in the input field "#permanentAddress" with the input value "BNE Australia"
	When I click button "#submit"

	
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
	
	