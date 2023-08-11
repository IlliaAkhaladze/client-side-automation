Feature: Pet Store

A short summary of the feature

@tag1
Scenario: 1. Validate that store can be created
	Given I have free API
	When I create 'Default' store
	Then I see created store with defiined values


@Delete
Scenario: 2. Validate that delete returns NotFound when data incorrect
	Given I have free API
	When I delete 'Dummy' from store
	Then I see 'NotFound' response
