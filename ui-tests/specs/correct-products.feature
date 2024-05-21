Feature: As a user, I want to be able to see the correct products listed when I have chosen a category so that I can easily filter the product list by category.

  Scenario Outline: Display products based on selected category
    Given I on the homepage
    When I choose "<category>" from the category selector
    Then I should only see products belonging to the "<category>"

  Examples:
    | category       |
    | Turntables     |
    | Mixers         |
    | Speakers       |
    | Headphones     |
    | DJ Controllers |
    | Alla           |