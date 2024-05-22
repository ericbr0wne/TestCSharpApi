import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('that I is on out on the product page', () => {
    cy.visit("/products");
});

When('I clicked category {string}', (category) => {
    cy.get('#categories').select(category);
});

Then('the product {string} should be shown with the description {string}', (productName) => {
    cy.get('.product .name').contains(productName);

});