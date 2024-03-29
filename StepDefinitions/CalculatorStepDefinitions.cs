using TechTalk.SpecFlow.Assist;
using TechTalk.SpecFlow.CommonModels;

namespace SpecFlowBasics.StepDefinitions
{
    [Binding]
    public sealed class CalculatorStepDefinitions
    {
        // For additional details on SpecFlow step definitions see https://go.specflow.org/doc-stepdef

        [Given("the first number is (.*)")]
        public void GivenTheFirstNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic
            // For storing and retrieving scenario-specific data see https://go.specflow.org/doc-sharingdata
            // To use the multiline text or the table argument of the scenario,
            // additional string/Table parameters can be defined on the step definition
            // method. 

            Console.WriteLine($"{nameof(GivenTheFirstNumberIs)} : {number}");
        }

        [Given("the second number is (.*)")]
        public void GivenTheSecondNumberIs(int number)
        {
            //TODO: implement arrange (precondition) logic

            Console.WriteLine($"{nameof(GivenTheSecondNumberIs)} : {number}");
        }

        [When("the two numbers are added")]
        public void WhenTheTwoNumbersAreAdded()
        {
            //TODO: implement act (action) logic

            Console.WriteLine($"{nameof(WhenTheTwoNumbersAreAdded)}");
        }

        [Then("the result should be (.*)")]
        public void ThenTheResultShouldBe(int result)
        {
            //TODO: implement assert (verification) logic

            Console.WriteLine($"{nameof(ThenTheResultShouldBe)} : {result}");
        }
        [Given(@"the input integers are provided")]
        public void GivenTheInputIntegersAreProvided(Table table)
        {
            var dataCollection = table.CreateDynamicSet();
            foreach (var item in dataCollection)
            {
                Console.WriteLine($"Number is {item.Numbers}");
            }
        }

        [When(@"two input numbers are subtracted")]
        public void WhenTwoInputNumbersAreSubtracted()
        {
            
        }
        [Then(@"Result With Details")]
        public void ThenResultWithDetails(Table table)
        {
            dynamic data=table.CreateDynamicInstance();
            Console.WriteLine($"Result has {data.Result} with logo {data.Logo}");
        }


        [Then(@"Result should be ""([^""]*)""")]
        public void ThenResultShouldBe(string p0)
        {
            
        }

    }
}
