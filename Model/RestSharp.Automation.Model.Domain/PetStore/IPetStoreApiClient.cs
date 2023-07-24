using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.PetStore
{
	public interface IPetStoreApiClient
	{
		Task<PostResponse> PostAsync(PostRequest postRequest);
		Task<PostResponse> GetByOrderIdAsync(int orderId);
		Task<StoreResponse> DeleteByOrderIdAsync(string orderId);
		Task<InventoryResponse> GetInvetoryAsync();
	}
}
