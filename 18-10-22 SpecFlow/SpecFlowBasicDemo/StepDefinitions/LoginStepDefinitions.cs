using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasicDemo.StepDefinitions
{
    [Binding]
    public class LoginStepDefinitions
    {
        Calculate cal = new Calculate();
        string i, j;
        bool ans;

        [Given(@"User gives userid as '([^']*)'")]
        public void GivenUserGivesUseridAs(string p0)
        {
            i = p0;
        }

        [Given(@"User gives password as '([^']*)'")]
        public void GivenUserGivesPasswordAs(string p0)
        {
            j = p0;
        }

        [When(@"UserClicksLogin")]
        public void WhenUserClicksLogin()
        {
            Console.WriteLine($"{nameof(WhenUserClicksLogin)}");
        }

        [Then(@"SuccessfulLogIN message should display")]
        public void ThenSuccessfulLogINMessageShouldDisplay()
        {
            ans = cal.ValidateUser(i, j);
            Assert.AreEqual(ans, true);
            Console.WriteLine($"nameof{(ThenSuccessfulLogINMessageShouldDisplay)}  : SuccessfulLogIN");
        }
    }
}
