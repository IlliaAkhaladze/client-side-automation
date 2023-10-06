Feature: Pet

A short summary of the feature

@Create
Scenario: 1. Validate that pet can be created
	Given I have free API
	When I create 'Default' pet
	Then I see created pet 

@Read
Scenario: 2. Validate that pet can be returned succsefully
	Given I have free API
	And I create 'Default' pet
	When I get created pet data by Id
	Then I see pet information

@Read
Scenario: 3. Validate that pet can be returned unsuccsefully
	Given I have free API
	When I get pet by unexisted 'TestId'
	Then I see 'NotFound' response

@Delete
Scenario: 4. Validate that pet can be deleted succsefully
	Given I have free API
	And I create 'Default' pet
	When I delete created pet
	Then I see that pet was deleted

@Delete
Scenario: 5. Validate error while unsuccsefully deleting the pet  
	Given I have free API
	When I delete pet with unexisted 'TestId'
	Then I see 'NotFound' response

@Update
Scenario: 6. Validate that pet can be updated
	Given I have free API
	And I create 'Default' pet
	When I update created pet information with 'UpdateRequest'
	Then I see that pet info is updated