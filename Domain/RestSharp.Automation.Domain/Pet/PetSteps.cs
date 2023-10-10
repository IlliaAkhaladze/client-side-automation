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

        public async Task<PetPostResponse> CreatePetAsync(
            PetPostRequest postRequest) =>
			await _petApiClient.PostAsync(postRequest);

		public async Task<ResponseMessage> DeletePetAsync(
            string petId) =>
			await _petApiClient.DeleteByPetIdAsync(petId);

		public async Task<ClientResponse> DeleteResponsePetAsync(
            string petId) =>
			await _petApiClient.DeleteResponseAsync(petId);

		public async Task<PetPostResponse> GetPetAsync(
            string petId)=>
			await _petApiClient.GetByPetIdAsync(petId);

		public async Task<PetUpdateResponse> GetUpdPetAsync(
            string petId) =>
			await _petApiClient.GetUpdPetAsync(petId);

		public async Task<ResponseMessage> UpdatePetAsync(
            string petId, 
            PetUpdateRequest updateRequest) =>
			await _petApiClient.UpdatePetAsync(petId, updateRequest);

		public async Task<ClientResponse> GetResponseAsync(
            string petId) =>
			await _petApiClient.GetResponseAsync(petId);
	}
}
