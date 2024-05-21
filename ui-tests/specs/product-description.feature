Feature: As a user I want to be able to see the correct description for all the products when I have chosen a category for all catagories or a specific category. 

Scenario Outline: When I choose the category "<category>" the product "<productName>" should be shown with the description "<description>".
Given that I hang out on the product page
When I get the category "<category>"
Then the product "<productName>" should be shown with the description "<description>"

Examples:
| category       | productName            | description                                               |
| Turntables     | Direct Drive Turntable | High torque direct drive turntable for professional DJs.  |
| Turntables     | Belt Drive Turntable   | Smooth and reliable belt drive turntable.                 |
| Turntables     | USB Turntable          | Versatile USB turntable for digital conversion.           | 
| Mixers         | 2-Channel Mixer        | Compact 2-channel mixer with all essential features.      |
| Mixers         | 4-Channel Mixer        | Advanced 4-channel mixer for complex setups.              |
| Mixers         | Digital Mixer          | Cutting-edge digital mixer with customizable effects.     |
| Speakers       | Powered Speaker        | High-output powered speaker for live performances.        |
| Speakers       | Passive Speaker        | Durable passive speaker with excellent sound quality.     |
| Speakers       | Subwoofer              | Deep bass subwoofer to enhance your DJ setup.             |
| Headphones     | Over-Ear Headphones    | Comfortable over-ear headphones with superior sound isolation.|
| Headphones     | In-Ear Monitors        | High-fidelity in-ear monitors for precise audio monitoring.|
| Headphones     | Wireless DJ Headphones | Wireless headphones with long battery life for DJs.       |
| DJ Controllers | 2-Deck DJ Controller   | Compact 2-deck DJ controller with intuitive controls.     |
| DJ Controllers | 4-Deck DJ Controller   | Versatile 4-deck DJ controller for complex mixing.        |
| DJ Controllers | All-in-One DJ System   | Comprehensive all-in-one DJ system for professional use.  |
| Alla           | Direct Drive Turntable | High torque direct drive turntable for professional DJs.  |
| Alla           | Belt Drive Turntable   | Smooth and reliable belt drive turntable.                 |
| Alla           | USB Turntable          | Versatile USB turntable for digital conversion.           | 
| Alla           | 2-Channel Mixer        | Compact 2-channel mixer with all essential features.      |
| Alla           | 4-Channel Mixer        | Advanced 4-channel mixer for complex setups.              |
| Alla           | Digital Mixer          | Cutting-edge digital mixer with customizable effects.     |
| Alla           | Powered Speaker        | High-output powered speaker for live performances.        |
| Alla           | Passive Speaker        | Durable passive speaker with excellent sound quality.     |
| Alla           | Subwoofer              | Deep bass subwoofer to enhance your DJ setup.             |
| Alla           | Over-Ear Headphones    | Comfortable over-ear headphones with superior sound isolation.|
| Alla           | In-Ear Monitors        | High-fidelity in-ear monitors for precise audio monitoring.|
| Alla           | Wireless DJ Headphones | Wireless headphones with long battery life for DJs.       |
| Alla           | 2-Deck DJ Controller   | Compact 2-deck DJ controller with intuitive controls.     |
| Alla           | 4-Deck DJ Controller   | Versatile 4-deck DJ controller for complex mixing.        |
| Alla           | All-in-One DJ System   | Comprehensive all-in-one DJ system for professional use.  |
