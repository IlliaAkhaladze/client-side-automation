using System.Net;
using System.Threading.Tasks;

using FluentAssertions;

using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.Pet;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.TestData.Storage.PetStore;

using TechTalk.SpecFlow;

namespace RestSharp.Automation.Tests.Features
{
	[Binding, Scope(Feature = "Pet")]
	public class PetDefinition
	{
		private readonly IPetSteps _petSteps;
		private PetPostResponse _response;
		private ResponseMessage _responseMessage;
		private PetPostRequest _pet;
		private ClientResponse _clientResponse;
		private PetUpdateRequest _updateRequest;
		private PetUpdateResponse _updatedPet;

		public PetDefinition(
			IPetSteps petSteps)
		{
			_petSteps = petSteps;
		}

		[Given(@"I have free API")]
		public void GivenIHaveFreeAPI()
		{
			//
		}

		[Given(@"I create '([^']*)' pet")]
		[When(@"I create '([^']*)' pet")]
		public async Task WhenICreatePet(string entityName)
		{
			_pet = PetRequestStorage.Requests[entityName];
			_response = await _petSteps.CreatePetAsync(_pet);
		}

		[When(@"I get created pet data by Id")]
		public async void WhenIGetCreatedPetDataById()
		{
			_response = await _petSteps.GetPetAsync(_pet.Id);
		}

		[When(@"I get pet by unexisted '([^']*)'")]
		public async Task WhenIGetPetByUnexisted(string testId)
		{
			_clientResponse = await _petSteps.GetResponseAsync(testId);
		}

		[When(@"I delete created pet")]
		public async Task WhenIDeleteCreatedPet()
		{
			string id = _pet.Id;
			_responseMessage = await _petSteps.DeletePetAsync(id);
		}

		[When(@"I delete pet with unexisted '([^']*)'")]
		public async Task WhenIDeletePetWithUnexisted(string testId)
		{
			_clientResponse = await _petSteps.DeleteResponsePetAsync(testId);
		}

		[When(@"I update created pet information with '([^']*)'")]
		public async Task WhenIUpdateCreatedPetInformationWith(string updateRequest)
		{
			_updateRequest = PetUpdateStorage.Requests[updateRequest];
			_updateRequest.Id = _pet.Id;
			_responseMessage = await _petSteps.UpdatePetAsync(_pet.Id, _updateRequest);
		}

		[Then(@"I see created pet")]
		[Then(@"I see pet information")]
		public void ThenISeeCreatedPet()
		{
			_response
			  .Should().BeEquivalentTo(_pet);
		}

		[Then(@"I see that pet was deleted")]
		public void ThenISeeThatPetWasDeleted()
		{
			_responseMessage.Code.Should().Be(200);
			_responseMessage.Message.Should().Be(_pet.Id);
		}

		[Then(@"I see '([^']*)' response")]
		public void ThenISeeResponse(HttpStatusCode expectedValue)
		{
			_clientResponse.StatusCode
				.Should()
				.Be(expectedValue);
		}

		[Then(@"I see that pet info is updated")]
		public async Task ThenISeeThatPetInfoIsUpdated()
		{
			_updatedPet = await _petSteps.GetUpdPetAsync(_updateRequest.Id);
			_updatedPet.Status
				.Should()
				.Be(_updatedPet.Status);
		}
	}
}