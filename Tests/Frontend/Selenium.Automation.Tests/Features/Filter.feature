@Filter
Feature: Filter


@Smoke
Scenario: 1. Check filter feature working with valid data
	Given I open main view
	And I open goods category
	When I get filters by 'platforma' category
	Then I see 'Platform' filters
	
Scenario Outline: 2. Verify selected filters are correct
	Given I open main view
	And I open goods category
	When I check '<OptionValue>' option in '<Category>' category
	Then I see '<ExpectedValue>' filters at page top
	Examples: 
	| OptionValue   | Category  | ExpectedValue |
	| Playstation 5 | platforma | Playstation 5 |
	| Playstation 3 | platforma | Playstation 4 |
	| Playstation 4 | platforma | Playstation 3 |

Scenario: 3. Demo
	Given I have env
	When I call user api endpoint 
	Then I see user details


