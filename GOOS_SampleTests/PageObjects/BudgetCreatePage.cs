using System;
using FluentAutomation;

namespace GOOS_SampleTests.PageObjects
{
    internal class BudgetCreatePage : PageObject<BudgetCreatePage>
    {
        public BudgetCreatePage(FluentTest test) : base(test)
        {
            this.Url = string.Format("{0}/budget/add", PageContext.Domain);
        }

        public BudgetCreatePage Amount(int amount)
        {
            I.Enter(amount.ToString()).In("#amount");
            return this;
        }

        public BudgetCreatePage Month(string yearMonth)
        {
            I.Enter(yearMonth).In("#month");
            return this;
        }

        public void AddBudget()
        {
            I.Click("input[type=\"submit\"]");
        }

        public BudgetCreatePage ShouldDisplay(string message)
        {
            I.Assert.Text(message).In("#message");
            return this;
        }
    }
}