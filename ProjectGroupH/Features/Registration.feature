Feature: Registration
	For me to have full access to the benefits of the website
	I first need to register 

@mytag
Scenario: Valid Registration
	Given I navigate to the website
	And I click on sign up
	And I enter my Username 
	And I enter my Email
	And I enter my Password 
	When I click on the sign up button
	Then I should be able to register successfully 