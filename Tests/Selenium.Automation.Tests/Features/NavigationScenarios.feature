@Navigation
Feature: NavigationScenarios


Scenario: 1. Check that navigation link can redirecting
	Given I open main view
	When I open 'Ноутбуки та комп’ютери' link
	Then I see 'Комп'ютери та ноутбуки' header

