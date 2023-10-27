using Newtonsoft.Json;

namespace RestSharp.Automation.Model.Domain.Pet
{
    public class PetUpdateRequest : PetPostRequest
    {
        [JsonProperty("category")]
        public Categories Category { get; set; }
        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }
    }
}