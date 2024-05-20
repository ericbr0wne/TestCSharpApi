import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

/* No duplicate steps, this one already in correct-products.js
Given('that I am on the product page', () => {});*/

When('I choose the category {string}', (category) => {
  // TODO: implement step
});

Then('the product {string}> should be shown with the price {string}', (price, a) => {
  // TODO: implement step
});