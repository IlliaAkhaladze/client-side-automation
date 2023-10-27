using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.Pet
{
    public interface IPetApiClient
    {
        Task<PetPostResponse> PostAsync(PetPostRequest postRequest);
        Task<PetPostResponse> GetByPetIdAsync(string petId);
        Task<ClientResponse> GetPetResponseAsync(string petId);
        Task<ResponseMessage> DeleteByPetIdAsync(string petId);
        Task<ClientResponse> DeletePetResponseAsync(string petId);
        Task<ResponseMessage> UpdatePetAsync(
         string petId, PetUpdateRequest petUpdateRequest);
        Task<PetUpdateResponse> GetUpdatePetAsync(string petId);
    }
}