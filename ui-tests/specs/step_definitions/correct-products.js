import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('Im chilling on the homepage', () => {
  cy.visit("/products");
});

When('I pick {string} from the category selector', (category) => {
  cy.get('#categories').select(category);
});

Then('I should only see the {string}', (productName) => {
  cy.get('.product .name').contains(productName);
});