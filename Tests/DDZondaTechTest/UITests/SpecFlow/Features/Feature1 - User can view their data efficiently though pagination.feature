Feature: Feature 1 - User can view their data efficiently through pagination

A short summary of the feature

@Feature1
Scenario: Verify default behaviour
	Given I am a user
	When I visit "http://localhost:3000"
	Then I am presented with "10" results
	And I am told I am on page "Page 1"
	And the left arrow is disabled

Scenario: "Show" drop down correctly limits the results on the page
	Given I am a user
	When I visit "http://localhost:3000"
	When I click the "Show" dropdown and select "Show 20"
	Then I am presented with "20" results
	And the "Show" dropdown UI is updated to say "Show 20"

Scenario: User can move page and keep the page limit
	Given I am a user
	When I visit "http://localhost:3000"
	When I click the "Show" dropdown and select "Show 50"
	Then I am presented with "50" results
	When I click the right arrow once
	Then I am told I am on page "Page 2"
	Then I am presented with "50" results