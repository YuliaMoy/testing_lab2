Feature: Customers

  Scenario: Open Account
    Given I am on the banking website
    When I select "Login as Bank Manager" option
    Then I click "Open Account"
    Then I choose Customer and Currency
    When I click button Process 
    Then I should see alert about opening account
    Then I click "Customers" 
    Then I should close Chrome
