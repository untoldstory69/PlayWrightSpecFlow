Feature: Login Feature

A short summary of the feature

@tag1
Scenario: User should be successfully login
	Given I am on the login page
	And I enter valid "username" and "password"
	When I click "Login" button
	Then I should be logged in successfully