using System.Threading.Tasks;

using RestSharp.Automation.Model.Domain.PetStore;
using RestSharp.Automation.Model.Platform.Client;

namespace RestSharp.Automation.Domain.PetStore
{
	public class PetStoreSteps : IPetStoreSteps
	{
		private readonly IPetStoreApiClient _petStoreApiClient;

		public PetStoreSteps(
			IPetStoreApiClient petStoreApiClient)
		{
			_petStoreApiClient = petStoreApiClient;
		}

		public async Task<PostResponse> CreateAsync(PostRequest postRequest)
		{
			var model = await _petStoreApiClient.PostAsync(postRequest);

			return model;
		}

		public async Task<StoreResponse> DeleteOrderAsync(string orderId)
		{
			var model = await _petStoreApiClient.DeleteByOrderIdAsync(orderId);

			return model;
		}

		public async Task<ClientResponse> DeleteResponseOrderAsync(
			string value)
		{
			var clientResponse = await _petStoreApiClient.DeleteResponseAsync(value);

			return clientResponse;
		}

		public async Task<PostResponse> GetAsync(int orderId)
		{
			var model = await _petStoreApiClient.GetByOrderIdAsync(orderId);

			return model;
		}

		public async Task<InventoryResponse> GetInvetoryAsync()
		{
			var model = await _petStoreApiClient.GetInvetoryAsync();

			return model;
		}
	}
}
