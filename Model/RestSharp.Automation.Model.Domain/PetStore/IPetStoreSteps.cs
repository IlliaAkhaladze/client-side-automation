using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.PetStore
{
	public interface IPetStoreSteps
	{
		Task<PostResponse> CreateAsync(PostRequest postRequest);
		Task<PostResponse> GetAsync(int orderId);
		Task<StoreResponse> DeleteOrderAsync(string orderId);
		Task<InventoryResponse> GetInvetoryAsync();
	}
}
