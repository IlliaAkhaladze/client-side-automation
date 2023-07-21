Feature: Filter

A short summary of the feature

@tag1
Scenario: 1. Check filter feature working with valid data
	Given I open Ігрові приставки page
	When I filter goods by "Платформа"
	* I select filter category value "Playstation 5 "
	Then I see selected filter options above goods
	* I see "Playstation 5" header
