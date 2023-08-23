@filter
Feature: Filter

A short summary of the feature

Scenario: 1. Check filter feature working with valid data
	Given I open main view
	And I open goods category
	When I get filters by 'platforma' category
	Then I see 'Platform' filters
	
Scenario: 2. Verify selected filters are correct
	Given I open main view
	And I open goods category
	When I check 'Playstation 5' option in 'platforma' category
	Then I see 'Playstation 5' filters at page top
