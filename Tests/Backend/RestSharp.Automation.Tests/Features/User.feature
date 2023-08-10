@useraccount
Feature: User

A short summary of the feature

@Create
Scenario: 1. Validate that user can be created
	Given I have free API
	When I create 'Demo' user
	Then I see user is created

@Read
Scenario: 2. Validate that user can be returned succsefully
	Given I have free API
	When I get 'Demo' user data by username
	Then I see user information

@Read
Scenario: 3. Validate that user can be returned unsuccsefully
	Given I have free API
	When I get 'Dummy' user information
	Then I see 'NotFound' response code 
@Update
Scenario: 4. Validate that user can be updated
	Given I have free API
	When I update 'Demo' user information
	Then I see that user info is updated

@Delete
Scenario: 5. Validate that user can be deleted succsefully
	Given I have free API
	When I delete 'Demo' user
	Then I see that user is deleted

@Delete
Scenario: 6. Validate that user can be deleted unsuccsefully
	Given I have free API
	When I delete 'Dummy' user
	Then I see 'NotFound' response code 