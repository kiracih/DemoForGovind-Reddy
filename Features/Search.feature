Feature: Search
	In order to reach content that I'm looking for
	As a TechCrunch user
	I want to use Search function

Scenario: Search term is found in article title and/or in content
	Given I have opened 'TechCrunch' homepage
	When I click Search icon on the left
	And I enter 'test' for search term
	And I press enter
	Then I should see search result page
	And I should see search term in the results
