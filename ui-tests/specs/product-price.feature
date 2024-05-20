Feature: As a user I want to be able to see the correct price for all the products when I have chosen a category for all catagories or a specific category. 

Scenario Outline: When I choose the category "<category>" the product "<productName>" should be shown with the price "<price>".
Given that I am on the product page
When I choose the category "<category>"
Then the product "<productName"> should be shown with the price "<price>"

Examples:
| category       | productName            | price  |
| Turntable      | Direct Drive Turntable | 499.99 |
| Turntable      | Belt Drive Turntable   | 299.99 |
| Turntable      | USB Turntable          | 199.99 | 
| Mixers         | 2-Channel Mixer        | 249.99 |
| Mixers         | 4-Channel Mixer        | 399.99 |
| Mixers         | Digital Mixer          | 599.99 |
| Speakers       | Powered Speaker        | 349.99 |
| Speakers       | Passive Speaker        | 249.99 |
| Speakers       | Subwoofer              | 499.99 |
| Headphones     | Over-Ear Headphones    | 149.99 |
| Headphones     | In-Ear Monitors        | 199.99 |
| Headphones     | Wireless DJ Headphones | 249.99 |
| DJ Controllers | 2-Deck DJ Controller   | 299.99 |
| DJ Controllers | 4-Deck DJ Controller   | 499.99 |
| DJ Controllers | All-in-One DJ System   | 999.99 |
| Alla           | Direct Drive Turntable | 499.99 |
| Alla           | Belt Drive Turntable   | 299.99 |
| Alla           | USB Turntable          | 199.99 | 
| Alla           | 2-Channel Mixer        | 249.99 |
| Alla           | 4-Channel Mixer        | 399.99 |
| Alla           | Digital Mixer          | 599.99 |
| Alla           | Powered Speaker        | 349.99 |
| Alla           | Passive Speaker        | 249.99 |
| Alla           | Subwoofer              | 499.99 |
| Alla           | Over-Ear Headphones    | 149.99 |
| Alla           | In-Ear Monitors        | 199.99 |
| Alla           | Wireless DJ Headphones | 249.99 |
| Alla           | 2-Deck DJ Controller   | 299.99 |
| Alla           | 4-Deck DJ Controller   | 499.99 |
| Alla           | All-in-One DJ System   | 999.99 |