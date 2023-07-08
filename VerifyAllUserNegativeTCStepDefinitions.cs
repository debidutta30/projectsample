using System;
using TechTalk.SpecFlow;

namespace APIBDDProject
{
    [Binding]
    public class VerifyAllUserNegativeTCStepDefinitions
    {
        [Given(@"the API base URL is ""([^""]*)""")]
        public void GivenTheAPIBaseURLIs(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I send a GET request to ""([^""]*)""")]
        public void WhenISendAGETRequestTo(string p0)
        {
            throw new PendingStepException();
        }

        [Then(@"the response status code should be (.*)")]
        public void ThenTheResponseStatusCodeShouldBe(int p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the request body does not contain the required fields")]
        public void GivenTheRequestBodyDoesNotContainTheRequiredFields()
        {
            throw new PendingStepException();
        }

        [When(@"I send a POST request to ""([^""]*)""")]
        public void WhenISendAPOSTRequestTo(string p0)
        {
            throw new PendingStepException();
        }

        [Given(@"the request body contains updated user details")]
        public void GivenTheRequestBodyContainsUpdatedUserDetails()
        {
            throw new PendingStepException();
        }

        [When(@"I send a PUT request to ""([^""]*)""")]
        public void WhenISendAPUTRequestTo(string p0)
        {
            throw new PendingStepException();
        }

        [When(@"I send a PATCH request to ""([^""]*)""")]
        public void WhenISendAPATCHRequestTo(string p0)
        {
            throw new PendingStepException();
        }
    }
}
