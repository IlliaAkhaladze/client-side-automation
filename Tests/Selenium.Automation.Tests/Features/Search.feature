@SerachBF
Feature: Search


@Production
Scenario: 1. Validate Search with Valid data
	Given I open main view
	When I search 'Комп'ютер HP 290 G1 MT (3ZD04EA)' value
	Then I see 'Комп'ютер HP 290 G1 MT (3ZD04EA)' result

@Smoke
Scenario: 2. Validate Search with Valid data
	Given I open main view
	When I search 'Комп'ютер HP 290 G1 MT (3ZD04EA)' value
	Then I see 'Комп'ютер HP 290 G1 MT (3ZD04EA)' result