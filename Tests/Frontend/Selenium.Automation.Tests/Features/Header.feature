@Header

Feature: Header

Scenario: 1. Validate that user can change language
	Given I open main view
	When I change language to UA
	Then I see language is  UA 