using Bogus;
using RestSharp.Automation.Model.Domain.Pet;
using System.Collections.Generic;

namespace RestSharp.Automation.TestData.Storage.PetStore
{
    public static class PetUpdateStorage
    {
        public static Dictionary<string, PetUpdateRequest> Requests =>
            new Dictionary<string, PetUpdateRequest>
            {
                { "UpdateRequest", UpdateRequest },
            };

        public static PetUpdateRequest UpdateRequest =>
            new Faker<PetUpdateRequest>()
                .RuleFor(p => p.Name, f => "cat")
                .RuleFor(p => p.PhotoUrls, f => new[] { "https://petstore.swagger.io/#/pet/addPet" })
                .RuleFor(p => p.Status, f => "Updated");
    }
}