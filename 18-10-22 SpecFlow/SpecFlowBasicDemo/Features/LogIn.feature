Feature: Login

A short summary of the feature

@tag1
Scenario: Successful Login with Valid Credentials
    Given User gives userid as 'testuser_1'
    Given User gives password as 'Test@123'
    When UserClicksLogin
    Then SuccessfulLogIN message should display


    

