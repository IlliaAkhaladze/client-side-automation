using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.PetStoreUser;
using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Domain.PetStoreUser
{
    public class UserSteps : IUserSteps
    {
        private readonly IUserApiClient _userApiClient;
        public UserSteps(
            IUserApiClient userApiClient)
        {
            _userApiClient = userApiClient;
        }

        public async Task<ResponseMessage> CreateUserAsync(UserPostRequest postRequest)
        {
            var model = await _userApiClient.PostAsync(postRequest);
            return model;
        }

        public async Task<UserPostResponse> GetUserAsync(string userName)
        {
            var model = await _userApiClient.GetUserByNameAsync(userName);
            return model; 
        }

        public async Task<ResponseMessage> UpdateUserAsync(string userName, UserUpdateRequest updateRequest)
        {
            var model = await _userApiClient.UpdateUserByNameAsync(userName, updateRequest);
            return model;
        }
        public async Task<ClientResponse> UpdateUserResponse(string username, UserUpdateRequest userUpdateRequest)
        {
            var clientResponse = await _userApiClient.UpdateResponseAsync(username, userUpdateRequest);
        }

        public async Task<ResponseMessage> DeleteUserAsync(string userName)
        {
            var model = await _userApiClient.DeleteUserByNameAsync(userName);
            return model;
        }

        public async Task<ClientResponse> DeleteResponseUserAsync(string value)
        {
            var clientResponse = await _userApiClient.DeleteResponseAsync(value);

            return clientResponse;
        }

      
    }
}
