Feature: Global Feature

A short summary of the feature

@tag1
Scenario: Testing Global Feature
	Given I open the browser with URL "https://demoqa.com/text-box"
	And I fill in the input field "#userName" with the input value "the rock"
	And I fill in the input field "#userEmail" with the input value "test@gmail.com"
	And I fill in the input field "#currentAddress" with the input value "brisbane australia"
	And I fill in the input field "#permanentAddress" with the input value "BNE Australia"
	When I click button "#submit"

	
Scenario: Testing Global Feature 1
	Given I open the browser with URL "https://demoqa.com/text-box" with window size "1920" & "1080"
	And I fill in the input field "#userName" with the input value "the rock"