Feature: googleSearch
	Open Google Chrome
	Enter the text "Software Tester" in google search bar 
	Click the second result from the second page
	Assert the page title
	

@googleSearch
Scenario: Search the text in google Search engine 
	Given Open Google Chrome 
	Then Enter Software Tester in search bar
	Then Click the second page and click the second result in second page
	Then Assert the page title
	Then close the browser