Feature: Pet

A short summary of the feature

Background: 
	Given I have free API

@Create
Scenario: 1. Validate that pet can be created
	When I create 'Default' pet
	Then I see created pet 

@Read
Scenario: 2. Validate that pet can be returned succsefully
	Given I create 'Default' pet
	When I get created pet data by Id
	Then I see pet information

@Read
Scenario: 3. Validate that pet can be returned unsuccsefully
	When I get pet by unexisted 'TestId'
	Then I see 'NotFound' response

@Delete
Scenario: 4. Validate that pet can be deleted succsefully
	Given I create 'Default' pet
	When I delete created pet
	Then I see that specific pet was deleted
	And I see '200' status code

@Delete
Scenario: 5. Validate error while unsuccsefully deleting the pet  
	When I delete pet with unexisted 'TestId'
	Then I see 'NotFound' response

@Update
Scenario: 6. Validate that pet can be updated
	Given I create 'Default' pet
	When I update created pet information with 'UpdateRequest'
	Then I see that pet info is updated