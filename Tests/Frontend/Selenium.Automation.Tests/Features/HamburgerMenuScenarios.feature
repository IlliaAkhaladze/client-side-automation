@HamburgerMenu
Feature: HamburgerMenuScenarios

Scenario: 1. Check Hamburger menu can be expanded
	Given I open main view
	When I expand hamburger menu
	Then I see hamburger menu expanded

Scenario: 2. City can be change in Hamburger menu
	Given I open main view
	Given I change language to UA
	Given I expand hamburger menu
	When I click Change city in Hamburger menu 
	When I change city to "Львів" in Select city popup
	Then I see city is changed to "Львів" in Hamburger menu