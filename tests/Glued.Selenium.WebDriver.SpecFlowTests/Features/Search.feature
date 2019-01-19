Feature: Search

Scenario: Search nuget.org for NOpenPage project
	Given I am on the nuget.org website
	When I search for NOpenPage project
	Then the NOpenPage project is present in the search result

