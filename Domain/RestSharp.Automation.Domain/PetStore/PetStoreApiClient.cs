using System.Threading.Tasks;

using Automation.Common.Environment;

using RestSharp.Automation.Model.Domain.PetStore;
using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Client;
using RestSharp.Automation.Platform.Extensions;

using Serilog;

namespace RestSharp.Automation.Domain.PetStore
{
	public class PetStoreApiClient : ApiClientBase, IPetStoreApiClient
	{
		public PetStoreApiClient(
			IClient client,
			IEnvironmentConfiguration environmentConfiguration,
			ILogger logger)
			: base(client, logger)
		{
			//string baseUri = $"https://petstore.swagger.io/v2/";
			string baseUri = environmentConfiguration.EnvironmentUri;
			client.SetBaseUri($"{baseUri}/store");
		}

		public async Task<PostResponse> GetByOrderIdAsync(
			int orderId)
		{
			var uri = $"/order/{orderId}";
			var response = await ExecuteGetAsync(uri);

			var model = response.GetModel<PostResponse>();

			return model;
		}

		public async Task<InventoryResponse> GetInvetoryAsync()
		{
			var uri = "/inventory";
			var response = await ExecuteGetAsync(uri);

			var model = response.GetModel<InventoryResponse>();

			return model;
		}

		public async Task<PostResponse> PostAsync(
			PostRequest postRequest)
		{
			var uri = "/order";
			var response = await ExecutePostAsync<PostResponse, PostRequest>(
				uri,
				postRequest);

			return response;
		}

		public async Task<StoreResponse> DeleteByOrderIdAsync(
			string orderId)
		{
			var uri = $"/order/{orderId}";
			var response = await ExecuteDeleteAsync(uri);

			var model = response.GetModel<StoreResponse>();

			return model;
		}
	}
}
