Feature: Sample
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers
	Given I have entered 50 into the calculator
	And I have entered 70 into the calculator
	When I press add
	Then the result should be 120 on the screen

Scenario: Create a new employee with mandatary details
#Given I have opened my application
#Then I should see employee details page
When I fill all the mandatory details in form
| Name | Age | Phone | Email                  |
| Hung11 | 11  | 0123  | lai.minh.hung@kloon.vn |
| Hung22 |22  | 0912  | hung123@kloon.vn |
| Hung33 |33  | 0912  | hung123@kloon.vn |
| Hung44 |44  | 0912  | hung123@kloon.vn |
#And I click the save button
#Then I should see all the details saved in my application and database

Scenario Outline: Create a new employee with mandatary details multi test case
#Given I have opened my application
#Then I should see employee details page
When I fill all the mandatory details in form with <Name> and <Age>
#And I click the save button
#Then I should see all the details saved in my application and database
Examples: 
| Name   | Age | Phone | Email                  |
| Hung1  | 11  | 0123  | lai.minh.hung@kloon.vn |
| Hung2  | 22  | 0912  | hung123@kloon.vn       |
| Hung3  | 33  | 0912  | hung123@kloon.vn       |
| Hung4  | 44  | 0912  | hung123@kloon.vn       |

Scenario: Check if I could get the details entered via Table from Extended Steps
When I fill all the mandatory details in form
| Name | Age | Phone | Email          |
| Hung | 28  | '0123'  | hung@gmail.com |
| Hung1 | 22  | '01232'  | 1hung@gmail.com |
Then I should get the same value from Extended steps