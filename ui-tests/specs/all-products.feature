Feature: Display all products

  Scenario Outline: Check that the product "<product>" is shown when the "Alla" category is selected
    Given I am on the homepage
    When I select "Alla" from the category selector
    Then I should see the product "<product>" listed

  Examples:
    | product               |
    | Direct Drive Turntable |
    | Belt Drive Turntable   |
    | USB Turntable          |
    | 2-Channel Mixer        |
    | 4-Channel Mixer        |
    | Digital Mixer          |
    | Powered Speaker        |
    | Passive Speaker        |
    | Subwoofer              |
    | Over-Ear Headphones    |
    | In-Ear Monitors        |
    | Wireless DJ Headphones |
    | 2-Deck DJ Controller   |
    | 4-Deck DJ Controller   |
    | All-in-One DJ System   |
