@ignore
@homework
Feature: Homework

A short summary of the feature

@C
Scenario: 1. Validate that user can be created
	Given I have free API
	When I create <UserDetails> user with details
	Then I see <OK> status code

@R
Scenario: 2. Validate that user can be returned succsefully
	Given I have free API
	And I have create <UserDetails> user with details
	When I get the created user 
	Then I see <UserDetails> user with created details

@R
Scenario: 3. Validate that user can be returned unsuccsefully
	Given I have free API
	When I get the created user by <incorrect> id
	Then I see <NotFound> status code

@U
Scenario: 4. Validate that user can be updated
	Given I have free API
	And I have create <UserDetails> user with details
	When I update created user with <NewDetails> details
	And I get the created user
	Then I see user with <NewDetails> details

@D
Scenario: 5. Validate that user can be deleted succsefully
	Given I have free API
	And I have create <UserDetails> user with details
	When I delete created user
	Then I see <OK> status code

@D
Scenario: 6. Validate that user can be deleted unsuccsefully
	Given I have free API
	When I delete user <incorrect> id
	Then I see <NotFound> status code