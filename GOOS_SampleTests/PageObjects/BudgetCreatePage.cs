using System;
using FluentAutomation;

namespace GOOS_SampleTests.PageObjects
{
    internal class BudgetCreatePage : PageObject<BudgetCreatePage>
    {
        public BudgetCreatePage(FluentTest test) : base(test)
        {
        }

        public BudgetCreatePage Amount(int amount)
        {
            throw new NotImplementedException();
        }

        public BudgetCreatePage Month(string yearMonth)
        {
            throw new NotImplementedException();
        }

        public void AddBudget()
        {
            throw new NotImplementedException();
        }

        public BudgetCreatePage ShouldDisplay(string message)
        {
            throw new NotImplementedException();
        }
    }
}