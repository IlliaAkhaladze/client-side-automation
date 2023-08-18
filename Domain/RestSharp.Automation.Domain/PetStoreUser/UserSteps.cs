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
            var model = await _userApiClient.GetUserAsync(userName);
            return model; 
        }
        public async Task<UserUpdateResponse> GetUpdUserAsync(string userName)
        {
            var model = await _userApiClient.GetUpdUserAsync(userName);
            return model;
        }
        public async Task<ResponseMessage> UpdateUserAsync(string userName, UserUpdateRequest updateRequest)
        {
            var model = await _userApiClient.UpdateUserAsync(userName, updateRequest);
            return model;
        }
       

        public async Task<ResponseMessage> DeleteUserAsync(string userName)
        {
            var response = await _userApiClient.DeleteUserAsync(userName);
            return response;
        }

        public async Task<ClientResponse> DeleteResponseAsync(string userName)
        { 
            var clientResponse = await _userApiClient.DeleteResponseAsync(userName);

            return clientResponse;
        }
        public async Task<ClientResponse> GetUserResponseAsync(string username)
        {
            var clientResponse = await _userApiClient.GetResponseAsync(username);

            return clientResponse;
        }
    }
}
