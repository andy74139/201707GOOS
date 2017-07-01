﻿using System;
using FluentAutomation;
using GOOS_SampleTests.PageObjects;
using TechTalk.SpecFlow;

namespace GOOS_SampleTests
{
    [Binding]
    [Scope(Feature = "BudgetCreate")]
    public class BudgetCreateSteps : FluentTest
    {
        private BudgetCreatePage _budgetCreatePage;

        [BeforeScenario()]
        public void BeforeScenario()
        {
            SeleniumWebDriver.Bootstrap(SeleniumWebDriver.Browser.Chrome);
        }


        public BudgetCreateSteps()
        {
            this._budgetCreatePage = new BudgetCreatePage(this);
        }

        [Given(@"go to adding budget page")]
        public void GivenGoToAddingBudgetPage()
        {
            this._budgetCreatePage.Go();
        }
        
        [When(@"I add a budget (.*) for ""(.*)""")]
        public void WhenIAddABudgetFor(int amount, string yearMonth)
        {
            this._budgetCreatePage
                    .Amount(amount)
                    .Month(yearMonth)
                    .AddBudget();
        }
        
        [Then(@"it should display ""(.*)""")]
        public void ThenItShouldDisplay(string message)
        {
            this._budgetCreatePage.ShouldDisplay(message);
        }
    }
}
