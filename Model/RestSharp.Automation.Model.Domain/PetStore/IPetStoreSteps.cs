using System.Threading.Tasks;

using RestSharp.Automation.Model.Platform.Client;

namespace RestSharp.Automation.Model.Domain.PetStore
{
	public interface IPetStoreSteps
	{
		Task<PostResponse> CreateAsync(PostRequest postRequest);
		Task<PostResponse> GetAsync(int orderId);
		Task<StoreResponse> DeleteOrderAsync(string orderId);
		Task<InventoryResponse> GetInvetoryAsync();
		Task<ClientResponse> DeleteResponseOrderAsync(string value);
	}
}
