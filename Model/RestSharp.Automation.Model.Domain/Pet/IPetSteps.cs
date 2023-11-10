using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.Pet
{
    public interface IPetSteps
    {
        Task<PetPostResponse> CreatePetAsync(PetPostRequest postRequest);
        Task<PetPostResponse> GetPetAsync(string petId);
        Task<ClientResponse> GetPetResponseAsync(string petId);
        Task<ResponseMessage> DeletePetAsync(string petId);
        Task<ClientResponse> DeleteResponsePetAsync(string petId);
        Task<ResponseMessage> UpdatePetAsync(
       string petId, PetUpdateRequest petUpdateRequest);
        Task<PetUpdateResponse> GetUpdatePetAsync(string petId);
    }
}