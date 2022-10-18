Feature: Calculator
![Calculator](https://specflow.org/wp-content/uploads/2020/09/calculator.png)
Simple calculator for adding **two** numbers

Link to a feature: [Calculator](SpecFlowBasicDemo/Features/Calculator.feature)
***Further read***: **[Learn more about how to generate Living Documentation](https://docs.specflow.org/projects/specflow-livingdoc/en/latest/LivingDocGenerator/Generating-Documentation.html)**

@mytag
    Scenario: Add two numbers
	Given the first number is 50
	And the second number is 70
	When the two numbers are added
	Then the result should be 120

	Scenario: Subtract two numbers
	Given the first number is 70
	And the second number is 50
	When the two numbers are subtracted
	Then the output should be 20

	Scenario: Multiply two numbers
	Given the first number is 7
	And the second number is 5
	When the two numbers are multiplied
	Then the answer should be 35

	Scenario: Divide two numbers
	Given the first number is 10
	And the second number is 5
	When the two numbers are divided
	Then the divans should be 2