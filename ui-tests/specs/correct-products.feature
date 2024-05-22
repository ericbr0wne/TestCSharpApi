Feature: As a user, I want to be able to see the correct products listed when I have chosen a category so that I can easily filter the product list by category.

  Scenario Outline: Display products based on selected category
    Given Im chilling on the homepage
    When I pick "<category>" from the category selector
    Then I should only see the "<product>" 

Examples:
| category       | product          | price   |
| Turntables      | Direct Drive Turntable | 499    |
| Turntables      | Belt Drive Turntable   | 299    |
| Turntables      | USB Turntable          | 199    | 
| Mixers         | 2-Channel Mixer        | 249    |
| Mixers         | 4-Channel Mixer        | 399    |
| Mixers         | Digital Mixer          | 599    |
| Speakers       | Powered Speaker        | 349    |
| Speakers       | Passive Speaker        | 249    |
| Speakers       | Subwoofer              | 499    |
| Headphones     | Over-Ear Headphones    | 149    |
| Headphones     | In-Ear Monitors        | 199    |
| Headphones     | Wireless DJ Headphones | 249    |
| DJ Controllers | 2-Deck DJ Controller   | 299    |
| DJ Controllers | 4-Deck DJ Controller   | 499    |
| DJ Controllers | All-in-One DJ System   | 999    |
| Alla           | Direct Drive Turntable | 499    |
| Alla           | Belt Drive Turntable   | 299    |
| Alla           | USB Turntable          | 199    | 
| Alla           | 2-Channel Mixer        | 249    |
| Alla           | 4-Channel Mixer        | 399    |
| Alla           | Digital Mixer          | 599    |
| Alla           | Powered Speaker        | 349    |
| Alla           | Passive Speaker        | 249    |
| Alla           | Subwoofer              | 499    |
| Alla           | Over-Ear Headphones    | 149    |
| Alla           | In-Ear Monitors        | 199    |
| Alla           | Wireless DJ Headphones | 249    |
| Alla           | 2-Deck DJ Controller   | 299    |
| Alla           | 4-Deck DJ Controller   | 499    |
| Alla           | All-in-One DJ System   | 999    |