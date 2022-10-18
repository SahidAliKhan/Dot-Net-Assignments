Feature: AddProductToCart

A short summary of the feature

@tag1
Scenario:AddProductToCart
    Given the prodname is ParleG
	And the quantity is 3
	When Added to the cart
	Then the output should be added successfully
