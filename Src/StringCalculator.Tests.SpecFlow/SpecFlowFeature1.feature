Feature: Simple string calculation
	In order to have an ability to easely add numbers
	I want to enter them as string and get the sum.

@mytag
Scenario: Calling Add with an empty string
	Given I have a method that accepts a string with numbers
	When I pass an empty string
	Then it should return zero
