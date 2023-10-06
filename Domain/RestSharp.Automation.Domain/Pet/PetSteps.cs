using RestSharp.Automation.Model.Domain;
using RestSharp.Automation.Model.Domain.Pet;
using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Domain.Pet
{
    public class PetSteps : IPetSteps
    {
        private readonly IPetApiClient _petApiClient;

        public PetSteps(
            IPetApiClient petApiClient)
        {
            _petApiClient = petApiClient;
        }

        public async Task<PetPostResponse> CreatePetAsync(PetPostRequest postRequest)
        {
            var model = await _petApiClient.PostAsync(postRequest);
            return model;
        }

        public async Task<ResponseMessage> DeletePetAsync(string petId)
        {
            var model = await _petApiClient.DeleteByPetIdAsync(petId);
            return model;
        }

        public async Task<ClientResponse> DeleteResponsePetAsync(
            string petId)
        {
            var clientResponse = await _petApiClient.DeleteResponseAsync(petId);
            return clientResponse;
        }

        public async Task<PetPostResponse> GetPetAsync(string petId)
        {
            var model = await _petApiClient.GetByPetIdAsync(petId);
            return model;
        }

        public async Task<PetUpdateResponse> GetUpdPetAsync(string petId)
        {
            var model = await _petApiClient.GetUpdPetAsync(petId);
            return model;
        }

        public async Task<ResponseMessage> UpdatePetAsync(string petId, PetUpdateRequest updateRequest)
        {
            var model = await _petApiClient.UpdatePetAsync(petId, updateRequest);
            return model;
        }

        public async Task<ClientResponse> GetResponseAsync(string petId)
        {
            var clientResponse = await _petApiClient.GetResponseAsync(petId);

            return clientResponse;
        }
    }
}
