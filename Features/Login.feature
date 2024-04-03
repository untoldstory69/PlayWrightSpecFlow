Feature: Login Feature

A short summary of the feature

@tag1 @TestCase=1234
Scenario: User should be successfully login
	Given I am on the login page
	And I enter valid "username" and "password"
	When I click "Login" button
	Then I should be logged in successfully

Scenario: Login Fail (this scenario is intentionally failed)
	Given I am on the login page
	And I enter valid "username" and "password"
	When I click "Login" button
	Then I should be logged in successfully failing

