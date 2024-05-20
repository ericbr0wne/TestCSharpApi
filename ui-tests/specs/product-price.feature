//Att rätt pris visas för varje produkt, 
//både när “Alla” är valt i kategoriväljaren och när endast en kategori visas.
Feature: As a user I want to be able to see the correct price for all the products when I have chosen a category for all catagories or a specific category. 

Scenario Outline: When I choose the category "<category>" the product "<productName>" should be shown with the price "<price>".
Given that I am on the product page
When I choose the category "<category>"
Then the product "<productName"> should be shown with the price "<price>"

Examples:
| category | productName | price |
| alla     | Direct Drive Turntable
           | Belt Drive Turntable
| USB Turntable
| 2-Channel Mixer
| 4-Channel Mixer
| Digital Mixer
| Powered Speaker
| Passive Speaker
| Subwoofer
| Over-Ear Headphones
| In-Ear Monitors
| Wireless DJ Headphones
| 2-Deck DJ Controller
| 4-Deck DJ Controller
| All-in-One DJ System