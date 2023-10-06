using Newtonsoft.Json;

namespace RestSharp.Automation.Model.Domain.Pet
{
    public class PetPostRequest
    {
        [JsonProperty("id")]
        public string Id { get; set; }
        [JsonProperty("name")]
        public string Name { get; set; }
        [JsonProperty("photoUrls")]
        public string[] PhotoUrls { get; set; }
        [JsonProperty("status")]
        public string Status { get; set; }
    }
}