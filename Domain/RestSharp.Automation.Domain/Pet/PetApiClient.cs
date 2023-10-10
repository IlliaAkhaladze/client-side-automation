using Automation.Common.Environment;
using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.Pet;
using RestSharp.Automation.Model.Platform.Client;
using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Client;
using RestSharp.Automation.Platform.Extensions;
using Serilog;
using System.Threading.Tasks;

namespace RestSharp.Automation.Domain.Pet
{
    public class PetApiClient : ApiClientBase, IPetApiClient
    {
        public PetApiClient(
            IClient client,
            IEnvironmentConfiguration environmentConfiguration,
            ILogger logger)
            : base(client, logger)
        {
            string baseUri = environmentConfiguration.EnvironmentUri;
            client.SetBaseUri($"{baseUri}/pet");
        }

        public async Task<PetPostResponse> GetByPetIdAsync(
            string petId)
        {
            var uri = $"/{petId}";
            var response = await ExecuteGetAsync(uri);
            var model = response.GetModel<PetPostResponse>();
            return model;
        }

        public async Task<ClientResponse> GetPetResponseAsync(string petId)
        {
            var uri = $"/{petId}";
            var response = await ExecuteGetAsync(uri);
            return response;
        }
        public async Task<PetUpdateResponse> GetUpdatePetAsync(string petId)
        {
            var response = await GetPetResponseAsync(petId);
            var model = response.GetModel<PetUpdateResponse>();
            return model;
        }

        public async Task<PetPostResponse> PostAsync(
            PetPostRequest postRequest)
        {
            var uri = "";
            var response = await ExecutePostAsync<PetPostResponse, PetPostRequest>(
                uri,
                postRequest);
            return response;
        }
        public async Task<ResponseMessage> UpdatePetAsync(string petId, PetUpdateRequest petUpdateRequest)
        {
            var uri = "";
            var response = await ExecutePutAsync(uri, petUpdateRequest, null);
            var model = response.GetModel<ResponseMessage>();
            return model;
        }

        public async Task<ResponseMessage> DeleteByPetIdAsync(
            string petId)
        {
            var response = await DeletePetResponseAsync(petId);
            var model = response.GetModel<ResponseMessage>();
            return model;
        }

        public async Task<ClientResponse> DeletePetResponseAsync(
            string petId)
        {
            var uri = $"/{petId}";
            var response = await ExecuteDeleteAsync(uri);
            return response;
        }
    }
}