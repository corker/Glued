Feature: Search

Scenario: Search nuget.org for Glued project
	Given I am on the nuget.org website
	When I search for Glued project
	Then the Glued project is present in the search result
