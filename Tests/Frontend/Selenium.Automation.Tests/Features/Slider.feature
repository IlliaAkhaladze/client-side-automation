@Slider
Feature: Slider

A short summary of the feature

Scenario: 1. Validate that user can see posts
	When I open main view
	Then I see 'https://rozetka.com.ua/ua/promo/rztk/' posts

@MoveNext
Scenario: Validate that user can swap next post
	Given I open main view
	When I swap post
	Then I see '' post