using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasicDemo.StepDefinitions
{
    [Binding]
    public class LogOutStepDefinitions
    {
        [When(@"User LogOut from the Application")]
        public void WhenUserLogOutFromTheApplication()
        {
            Console.WriteLine($"{nameof(WhenUserLogOutFromTheApplication)}");
        }

        [Then(@"Successful LogOut message should display")]
        public void ThenSuccessfulLogOutMessageShouldDisplay()
        {
            Console.WriteLine($"nameof{(ThenSuccessfulLogOutMessageShouldDisplay)}  : LoggedOutSuccessfully");
        }
    }
}
