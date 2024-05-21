import { Given, When, Then } from "@badeball/cypress-cucumber-preprocessor";

Given('I on the homepage', () => {
  cy.visit("/homepage");
});

When('I choose {string} from the category selector', (category) => {
  cy.get()
});

Then('I should only see products belonging to the {string}', (category) => {
  // TODO: implement step
});