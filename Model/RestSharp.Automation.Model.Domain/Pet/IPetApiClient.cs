using RestSharp.Automation.Model.Platform.Client;
using System.Threading.Tasks;

namespace RestSharp.Automation.Model.Domain.Pet
{
    public interface IPetApiClient
    {
        Task<PetPostResponse> PostAsync(PetPostRequest postRequest);
        Task<PetPostResponse> GetByPetIdAsync(string petId);
        Task<ClientResponse> GetResponseAsync(string petId);
        Task<ResponseMessage> DeleteByPetIdAsync(string petId);
        Task<ClientResponse> DeleteResponseAsync(string petId);
        Task<ResponseMessage> UpdatePetAsync(
         string petId, PetUpdateRequest petUpdateRequest);
        Task<PetUpdateResponse> GetUpdPetAsync(string petId);
    }
}