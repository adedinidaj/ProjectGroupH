Feature: DataDrivenRegistration
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven Valid Registration
	Given I navigate to "https://angularjs.realworld.io/#/"
	And I click on sign up
	And I enter my Username "testing"
	And I enter my Email "testing"
	And I enter my Password "testing"
	#When I click on the sign up button
	#Then I should be able to register successfully 