using System.Net;
using System.Threading.Tasks;
using FluentAssertions;
using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.PetStore;
using RestSharp.Automation.Model.Domain.PetStoreUser;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.TestData.Storage.PetStore;

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
		private UserPostResponse _actualUser;
		private UserUpdateRequest _updateRequest;
        private UserUpdateResponse _updatedUser;

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
			_response.Code
				.Should()
				.Be(200);
			_response.Message
				.Should()
				.NotBeNullOrEmpty();
			_response.Message.Length
				.Should()
				.Be(19);
		}

        [Given(@"I create '([^']*)' user")]
        public async Task GivenICreateUserAsync(string username)
        {
            _postRequest = UserRequestStorage.Requests[username];
            _response = await _userSteps.CreateUserAsync(_postRequest);
        }

        [When(@"I get created user data by username")]
        public async Task WhenIGetCreatedUserDataByUsernameAsync()
        {
            _actualUser = await _userSteps.GetUserAsync(_postRequest.UserName);
        }

		[Then(@"I see user information")]
		public void ThenISeeUserInformation()
		{
            _response.Code.
				Should().
                Be(200);
            _actualUser.UserName.
				Should().
				Be(_postRequest.UserName);
            _actualUser.Password.
				Should().
				Be(_postRequest.Password);
			
		}

        [When(@"I get user by '([^']*)' username")]
        public async Task WhenIGetUserByUsernameAsync(string username)
        {
            _clientResponse = await _userSteps.GetUserResponseAsync(username);
		
        }

        [When(@"I update created user information with '([^']*)'")]
        public async Task WhenIUpdateCreatedUserInformationWithAsync(string entityName)
        {
			_updateRequest = UserUpdateStorage.Requests[entityName];
			_response = await _userSteps.UpdateUserAsync(_postRequest.UserName, _updateRequest);
			_response.Code
				.Should().Be(200);
		}

		[Then(@"I see that user info is updated")]
		public async Task ThenISeeThatUserInfoIsUpdated()
		{
            _updatedUser = await _userSteps.GetUpdUserAsync(_updateRequest.UserName);
            _updatedUser.UserName
			   .Should()
			   .Be(_updateRequest.UserName);
           _updatedUser.Password
               .Should()
               .Be(_updateRequest.Password);
            _updatedUser.Email
                .Should()
                .Be(_updateRequest.Email);
			_updatedUser.Phone
				.Should()
				.Be(_updateRequest.Phone);
			_updatedUser.FirstName
				.Should()
				.Be(_updateRequest.FirstName);
			_updatedUser.LastName
				.Should()
				.Be(_updateRequest.LastName);
			_updatedUser.UserStatus
				.Should()
				.Be(_updateRequest.UserStatus);
        }

        [When(@"I delete created user")]
        public async Task WhenIDeleteCreatedUserAsync()
        {
            _response = await _userSteps.DeleteUserAsync(_postRequest.UserName);
		}

        [When(@"I delete '([^']*)' user")]
        public async Task WhenIDeleteUser(string userName)
        {
            _clientResponse = await _userSteps.DeleteResponseAsync(userName); 
        }

        [Then(@"I see that user was deleted")]
        public void ThenISeeThatUserWasDeleted()
        {
        	_response.Code.Should().Be(200);
			_response.Message.Should().Be(_postRequest.UserName);
		}

		[Then(@"I see '([^']*)' response")]
        public void ThenISeeResponse(HttpStatusCode expectedValue)
        {

            _clientResponse.StatusCode
                .Should()
                .Be(expectedValue);
        }

    }

}
