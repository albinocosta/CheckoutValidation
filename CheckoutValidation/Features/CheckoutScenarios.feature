@Chrome
Feature: Checkout and payment verification
       This scenarios will verify if transactions was succeeded

    Scenario: 01. Validate order total amount and succeeded operation
    Given I'm at Inventary page 
    And I have added 2 products to the cart
    When I go to checkout 
    And Fill in my basic information
    And go to checkout step two page
    Then I can verify that the order amount is correct
    And I can complete the order    