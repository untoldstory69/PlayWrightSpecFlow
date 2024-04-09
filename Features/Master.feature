Feature: Master Feature

This Featue files contains the global features used in web application


#Scenario: Input Field such as text field, text area
	#Given I open the browser with URL "https://demoqa.com/text-box"
	#And I fill "the rock" in the input field "userName" with the locator "#userName"
	#And I fill "test@gmail.com" in the input field "userEmail" with the locator "#userEmail"
	#And I fill "brisbane australia" in the input field "currentAddress" with the locator "#currentAddress"
	#And I fill "Australia" in the input field "permanentAddress" with the locator "#permanentAddress"
	#When I click "Submit" button with locator "#submit"

	
#Scenario: Checkbox 
#	Given I open the browser with URL "https://demoqa.com/checkbox" with window size "1920" * "1080"
#	When I check the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']"in the checkbox
#	Then I verify the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']" is checked
	#And I uncheck the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']" in the checkbox
	#Then I verify the element "element name" with element locator "//span[@class='rct-node-icon']//*[name()='svg']" is unchecked

#Scenario: Radio button
#	Given I open the browser with URL "https://demoqa.com/radio-button" with window size "1920" * "1080" 
#	When I check the radio button "element name" with the element locator "//label[@for='impressiveRadio']" 
#	Then I verify the radio button "element name" with the element locator "//label[@for='impressiveRadio']" is checked

#Scenario: Buttons
#	Given I open the browser with URL "https://demoqa.com/buttons" with window size "1920" * "1080"
#	When I click "clickMe" button with text "Click Me" of Nth "2" element 
#	Then I verify message "You have done a dynamic click" is shown on locator "#dynamicClickMessage"
#	When I double click "double click me" button with locator "#doubleClickBtn"
#	Then I verify message "You have done a double click" is shown on locator "#doubleClickMessage"
#	When I right click "Right Click Me" button with locator "#rightClickBtn"
#	Then I verify message "You have done a right click" is shown on locator "#rightClickMessage"

#Scenario: Upload File
#	Given I open the browser with URL "https://demoqa.com/upload-download" with window size "1920" * "1080"
#	When I upload file "C:\Users\kishor.sharma\Downloads\sampleFile.jpeg" with locator "#uploadFile"
#	Then I verify message "C:\fakepath\sampleFile.jpeg" is shown on locator "#uploadedFilePath"

#Scenario: Alerts
#	Given I open the browser with URL "https://testpages.eviltester.com/styled/alerts/alert-test.html"
#	And I click button "Click Me" with locator "#alertexamples" and verify alert message "I am an alert box!"
#	And I click confirmation alert box "confirm" with locator "#confirmexample" and click OK with text (optional) ""
#	And I click confirmation alert box "confirm" with locator "#confirmexample" and click Cancel 
#	And I click confirmation alert box "Show Prompt Box" with locator "#promptexample" and click OK with text (optional) "I am test"

#Scenario: HTML Table
#	Given I open the browser with URL "https://testpages.eviltester.com/styled/index.html" 
#	And I click "Table Test Page" button with locator "#tablestest"
#	And I verify the text "Alan" in the table with locator "#mytable"

#Scenario: Sort Table
#	Given I open the browser with URL "https://practice-automation.com/tables/" 
#	And I sort table with table locator "#tablepress-1_wrapper" using column "th"
#	And I sort table with table locator "#tablepress-1_wrapper" using column "th"
#	And I verify column with column name and index "1" is sorted for table locator "#tablepress-1"


#Scenario: Modal Dialogue
#	Given I open the browser with URL "https://demoqa.com/alertsWindows"
#	And I click "Modal Dialogue" button with locator "//span[normalize-space()='Modal Dialogs']"
#	And I click "Small Modal" button with locator "#showSmallModal"
#	And I verify message "This is a small modal. It has very less content" is shown on locator "//div[@class='modal-body']"

#Scenario: New Tab / Window 
#	Given I open the browser with URL "https://demoqa.com/browser-windows"
#	And I click element "#windowButton" to open New Tab/Window and verify Text "This is a sample page" in the new tab with locator"#sampleHeading"
	
#Scenario: IFrame
#	Given I open the browser with URL "https://testpages.eviltester.com/styled/index.html"
#	And I click "iFame Test" button with locator "#iframestest"
#	Then I verify text "Nested Page Example" in the iFrame "#theheaderhtml" with locator "//h1[normalize-space()='Nested Page Example']"
#	And I click the element "Index" in the iFrame "#theheaderhtml" with locator "//a[normalize-space()='Index']"

#Scenario: Autocomplete
#	Given I open the browser with URL "https://demoqa.com/widgets"
#	And I click "Auto Complete" button with locator "//div[@class='element-list collapse show']//li[@id='item-1']"
#	And I fill in text "Blue" in the auto complete locator "#autoCompleteMultipleInput"


#Scenario: Drop down
#	Given I open the browser with URL "https://testpages.eviltester.com/styled/basic-html-form-test.html"
#	And I select options "Drop Down Item 4" from the drop down menu with locator "//select[@name='dropdown']"


#Scenario: Submit form successfully
#	Given I open the browser with URL "https://practice-automation.com/" with window size "1920" * "1080"
#	When I click "Form Fields" button with locator "//a[normalize-space()='Form Fields']"
#	Then I redirected to the next page with URL "https://practice-automation.com/form-fields/"
#	And I fill "test name" in the input field "Name" with the locator "#name"
#	And I check the element "Milk" with element locator "#drink2"in the checkbox
#	And I check the radio button "Yellow" with the element locator "#color3"
#	And I select options "yes" from the drop down menu with locator "#siblings"
#	And I fill "test@gmail.com" in the input field "Email " with the locator "#email"
#	And I fill "here is message " in the input field "Message " with the locator "#message"
#	And I click button "Submit" with locator "#submit-btn" and verify alert message "Message received!"
	 

	

	

	
	