Feature: LoginFeature

    Scenario: Login into sample html app
        Given I navigate to login page
        And I provide 'admin' and 'password'
        Then I verify home page has header 'Welcome to Sample Website'
       