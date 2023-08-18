using Automation.Common.Environment;
using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.PetStoreUser;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Client;
using RestSharp.Automation.Platform.Extensions;
using Serilog;
using System.Threading.Tasks;

namespace RestSharp.Automation.Domain.PetStoreUser
{
    public class UserApiClient:ApiClientBase, IUserApiClient
    {
        public UserApiClient(
            IClient client,
            IEnvironmentConfiguration environmentConfiguration,
            ILogger logger
            ) : base(client, logger)
        {
            string baseUri = environmentConfiguration.EnvironmentUri;
            client.SetBaseUri($"{baseUri}/user");
        }
  
        public async Task<UserPostResponse> GetUserAsync(string userName)
        {
            var response = await GetResponseAsync(userName);
            var model = response.GetModel<UserPostResponse>();

            return model;
        }
        public async Task<UserUpdateResponse> GetUpdUserAsync(string username)
        {

            var response = await GetResponseAsync(username);
            var model = response.GetModel<UserUpdateResponse>();

            return model;
        }

        public async Task<ClientResponse> GetResponseAsync(string userName)
        {
            var uri = $"/{userName}";
            var response = await ExecuteGetAsync(uri);
            return response;
        }

        public async Task<ResponseMessage> PostAsync(
            UserPostRequest postRequest)
        {
            var uri = "";
            var response = await ExecutePostAsync<ResponseMessage, UserPostRequest>(
                uri,
                postRequest);

            return response;
        }
        public async Task<ResponseMessage> UpdateUserAsync(string username, UserUpdateRequest userUpdateRequest)
        {
            var uri = $"/{username}";

            var response = await ExecutePutAsync(uri, userUpdateRequest, null);
            var model = response.GetModel<ResponseMessage>();
            return model;
        }
        public async Task<ResponseMessage> DeleteUserAsync(string username)
        {
            var response = await DeleteResponseAsync(username);
            var model = response.GetModel<ResponseMessage>();

            return model;
        }
        public async Task<ClientResponse> DeleteResponseAsync(string username)
        {
            var uri = $"/{username}";
            var response = await ExecuteDeleteAsync(uri);
                return response;
           
        }

        
              
    }
       
}

