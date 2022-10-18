using NUnit.Framework;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowBasicDemo.StepDefinitions
{
    [Binding]
    public class AddProductToCartStepDefinitions
    {
        string hq;
        int qh;

        [Given("the prodname is (.*)")]
        public void GivenTheProdnameIsProduct(string input)
        {
            hq = input;
        }

        [Given(@"the quantity is (.*)")]
        public void GivenTheQuantityIs(int p0)
        {
            qh = p0;
        }

        [When(@"Added to the cart")]
        public void WhenAddedToTheCart()
        {
            Console.WriteLine($"Product Name: {hq}  and QTY: {qh}");
        }
        [Then("the output should be (.*)")]
        public void ThenTheOutputShouldBe(string result)
        {
            string actual = null;
            if (qh > 0 && hq != null)
            {
                actual = result;
            }
            else
            {
                actual = "Not perfect to be added in";
            }
            Assert.AreEqual(result, actual);
        }

    }
}
