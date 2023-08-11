using FluentAssertions;
using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.PetStoreUser;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.TestData.Storage.PetStore;
using System.Net;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace RestSharp.Automation.Tests.Features
{
    [Binding, Scope(Feature = "User")]
    public class User
    {
        private readonly IUserSteps _userSteps;
        private ResponseMessage _response;
        private UserPostRequest _postRequest;
        private ClientResponse _clientResponse;
        
        public User(
            IUserSteps userSteps) 
        {
            _userSteps = userSteps;
        }

        [Given(@"I have free API")]
        public void GivenIHaveFreeAPI()
        {
            //
        }

        [When(@"I create '([^']*)' user")]
        public async Task WhenICreateUser(string name)
        {
            _postRequest = UserRequestStorage.Requests[name];
            _postRequest.UserName = _postRequest.UserName.Substring(0, 10);
            _response = await _userSteps.CreateUserAsync(_postRequest);
        }

        [Then(@"I see user is created")]
        public void ThenISeeUserIsCreated()
        {
            _response.Code.Should().Be(200);          
        }

        [When(@"I get '([^']*)' user data by username")]
        public async Task WhenIGetUserDataByUsername(string username)
        {
            _postRequest = UserRequestStorage.Requests[username];
            _response = await _userSteps.CreateUserAsync(_postRequest);
        }

        [Then(@"I see user information")]
        public async Task ThenISeeUserInformation()
        {
            var actualUser = await _userSteps.GetUserAsync(_postRequest.UserName);
            actualUser.Password.Should().Be(_postRequest.Password);
            
        }

        [When(@"I get '([^']*)' user information")]
        public void WhenIGetUserInformation(string userName)
        {
            throw new PendingStepException();
        }

        [Then(@"I see '([^']*)' response code")]
        public void ThenISeeResponseCode(string notFound)
        {
            throw new PendingStepException();
        }

        [When(@"I update '([^']*)' user information")]
        public async Task WhenIUpdateUserInformation(string demo)
        {
            //_response = await _userSteps.
        }

        [Then(@"I see that user info is updated")]
        public void ThenISeeThatUserInfoIsUpdated()
        {
            throw new PendingStepException();
        }


        [When(@"I delete '([^']*)' user")]
        public async void WhenIDeleteUser(string userName)
        {
            userName = _postRequest.UserName;
            _clientResponse = await _userSteps.DeleteResponseUserAsync(_postRequest.UserName);
        }

        [Then(@"I see '([^']*)' response code")]
        public void ThenISeeThatUserIsDeleted(HttpStatusCode expectedValue)
        {
            _clientResponse.StatusCode
                .Should()
                .Be(expectedValue);
        }


        [When(@"I delete non existing '([^']*)' user")]
        public void WhenIDeleteNonExistingUser(string dummy)
        {
            throw new PendingStepException();
        }

        [Then(@"I see '([^']*)' response")]
        public void ThenISeeResponse(string notFound)
        {
            throw new PendingStepException();
        }






    }

}
