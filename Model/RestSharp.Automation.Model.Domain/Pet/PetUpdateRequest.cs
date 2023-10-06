using Newtonsoft.Json;

namespace RestSharp.Automation.Model.Domain.Pet
{
    public class PetUpdateRequest : PetPostRequest
    {
        [JsonProperty("category")]
        public Categories Category { get; set; }
        [JsonProperty("tags")]
        public Tag[] Tags { get; set; }

        public class Categories
        {
            public string Id { get; set; }
            public string Name { get; set; }
        }

        public class Tag
        {
            public int Id { get; set; }
            public string Name { get; set; }
        }
    }
}