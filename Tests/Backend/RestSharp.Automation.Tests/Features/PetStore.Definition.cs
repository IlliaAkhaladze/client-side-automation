using System.Net;
using System.Threading.Tasks;

using FluentAssertions;

using RestSharp.Automation.Model.Domain.PetStore;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.TestData.Storage.PetStore;

using TechTalk.SpecFlow;

namespace RestSharp.Automation.Tests.Features
{
	[Binding, Scope(Feature = "Pet Store")]
	public class PetStoreDefinition
	{
		private readonly IPetStoreSteps _petStoreSteps;
		private PostResponse _response;
		private PostRequest _postRequest;
		private ClientResponse _clientResponse;

		public PetStoreDefinition(
			IPetStoreSteps petStoreSteps)
		{
			_petStoreSteps = petStoreSteps;
		}

		[Given(@"I have free API")]
		public void GivenIHaveFreeAPI()
		{
			// Syntactic sugar
		}

		[When(@"I create '([^']*)' store")]
		public async Task WhenICreateStore(string entityName)
		{
			_postRequest = PetStoreRequestStorage.Requests[entityName];
			_response = await _petStoreSteps.CreateAsync(_postRequest);
		}

		[Then(@"I see created store with defiined values")]
		public void ThenISeeStoreWithCreatedValues()
		{
			_response.Id
				.Should()
				.NotBeNullOrEmpty();
		}

		[When(@"I delete '([^']*)' from store")]
		public async Task WhenIDeleteFromStore(string value)
		{
			_clientResponse = await _petStoreSteps.DeleteResponseOrderAsync(value);
		}

		[Then(@"I see '([^']*)' response")]
		public void ThenISee(HttpStatusCode expectedValue)
		{
			_clientResponse.StatusCode
				.Should()
				.Be(expectedValue);
		}
    }
}
