using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.PetStoreUser
{
    public interface IUserApiClient
    {
        Task<ResponseMessage> PostAsync(UserPostRequest postRequest);
        Task<UserPostResponse> GetUserAsync(string username);
        Task<ClientResponse> GetResponseAsync(string username);
        Task<ResponseMessage> UpdateUserAsync(
            string username, UserUpdateRequest userUpdateRequest);
        Task<ResponseMessage> DeleteUserAsync(string username);
        Task<ClientResponse> DeleteResponseAsync(string value);
        Task<UserUpdateResponse> GetUpdUserAsync(string username);
    }
}
