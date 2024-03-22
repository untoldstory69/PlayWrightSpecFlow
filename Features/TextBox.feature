Feature: TextBox

A short summary of the feature

@tag1
Scenario: TextBox Submit User Details
	Given I am on the TextBox page
	And I enter valid detais
	When I click Submit
	Then form should be submitted

Scenario:  a TextBox Submit User Details (failing this scennario intentionally for testing purpose)
	Given I am on the TextBox page
	And I enter valid detais
	When I click Submit
	Then form should be Not submitted
	

