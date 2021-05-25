Feature: Test Stack White + SpecFlow (Calculator application)

Scenario Outline: Check calculator result
	Given Calculator is started
	When I select calculator mode '<mode>'
	When I input '12'
	When I click plus button
	When I input '999'
	When I click result button and click 'Add To Memory' button
	When I input '19'
	When I add the entered number with the number from memory
	Then The result should be '1030'

Examples:
		| mode		 |
		| Standard   |
		| Scientific |
