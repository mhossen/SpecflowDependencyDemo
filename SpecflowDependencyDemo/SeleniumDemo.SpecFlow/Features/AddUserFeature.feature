Feature: AddUserFeature

    Scenario: Add new user
        Given I navigate to login page
        And I provide 'admin' and 'password'
        Then I verify home page has header 'Welcome to Sample Website'
        When I navigate to 'Add User'