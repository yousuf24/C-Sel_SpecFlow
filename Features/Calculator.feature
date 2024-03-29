Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowBasics/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@smoke
Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

@Regression
Scenario: substract two numbers
	Given the input integers are provided
	| Numbers |
	| 93      |
	| 18      |
	When two input numbers are subtracted
	Then Result With Details
	| Result | Logo    |
	| 75     | sutract |
	Then Result should be "PASSED."