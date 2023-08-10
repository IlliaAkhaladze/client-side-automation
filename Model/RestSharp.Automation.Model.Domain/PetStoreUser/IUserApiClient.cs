using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.PetStoreUser
{
    public interface IUserApiClient
    {
        Task<ResponseMessage> PostAsync(UserPostRequest postRequest);
        Task<UserPostResponse> GetUserByNameAsync(string UserName);
        Task<ClientResponse> UpdateResponseAsync(
           string username, UserUpdateRequest userUpdateRequest);
        Task<UserUpdateRequest> UpdateUserByName(
            string username, UserUpdateRequest userUpdateRequest);
        Task <ResponseMessage>DeleteUserByNameAsync(string username);
        Task<ClientResponse> DeleteResponseAsync(
            string username);

    }
}
