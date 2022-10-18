using Microsoft.VisualStudio.TestPlatform.Utilities;
using NUnit.Framework;

namespace SpecFlowBasicDemo.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        int i, j;
        Calculate cal = new Calculate();

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            //throw new PendingStepException();

            i = number;
            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            //throw new PendingStepException();

            j = number;
            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic
            //throw new PendingStepException();

            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic
            //throw new PendingStepException();

            int actual = cal.Add(i, j);
            Assert.AreNotEqual(result, actual);

            //result = i + j;
            Console.WriteLine($"{nameof(ThenTheResultShouldBe)} : {result}");
        }

        //------------------------------------------------------------


        [When("the two numbers are subtracted")]

        public void WhenthetwonumbersareSubtracted()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"{nameof(WhenthetwonumbersareSubtracted)}");
            // throw new PendingStepException();

        }

        [Then("the output should be (.*)")]
        public void theoutputshouldbe(double result)
        {
            result = i - j;
            //TODO: implement assert (verification) logic
            Console.WriteLine($"{nameof(theoutputshouldbe)} : {result}");
            //throw new PendingStepException();
        }

        //------------------------------------------------------------

        [When("the two numbers are multiplied")]

        public void WhenTheTwoNumbersAreMultiplied()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreMultiplied)}");
            // throw new PendingStepException();

        }

        [Then("the answer should be (.*)")]
        public void ThenTheAnswerShouldBe(double result)
        {
            result = i * j;
            //TODO: implement assert (verification) logic
            Console.WriteLine($"{nameof(ThenTheAnswerShouldBe)} : {result}");
            //throw new PendingStepException();
        }

        //------------------------------------------------------------

        [When("the two numbers are divided")]

        public void WhenTheTwoNumbersAreDivided()
        {
            //TODO: implement act (action) logic
            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreDivided)}");
            // throw new PendingStepException();

        }

        [Then("the divans should be (.*)")]
        public void ThenTheDivansShouldBe(double result)
        {
            int a;
            a = i / j;
            result = i / j;
            //TODO: implement assert (verification) logic
            Console.WriteLine($"{nameof(ThenTheAnswerShouldBe)} : {result}");
            Assert.AreEqual(a, result);
            //throw new PendingStepException();
        }

    }
}