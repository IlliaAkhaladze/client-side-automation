using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.PetStoreUser
{
    public interface IUserSteps
    {
        Task<ResponseMessage> CreateUserAsync(UserPostRequest postRequest);
        Task<UserPostResponse> GetUserAsync(string userName);
        Task<ResponseMessage> UpdateUserAsync(string userName, UserUpdateRequest updateRequest);
        Task<ClientResponse> UpdateUserResponse(string userName, UserUpdateRequest updateRequest);
        Task<ResponseMessage> DeleteUserAsync (string userName);
        Task<ClientResponse> DeleteResponseUserAsync(string value);
    }
}
