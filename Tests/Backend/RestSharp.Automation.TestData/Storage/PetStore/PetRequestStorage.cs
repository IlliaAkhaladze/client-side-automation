using Bogus;
using RestSharp.Automation.Model.Domain.Pet;
using RestSharp.Automation.Model.Domain.PetStore;
using Selenium.Automation.Platform.Enum;
using System.Collections.Generic;

namespace RestSharp.Automation.TestData.Storage.PetStore
{
    public static class PetRequestStorage
    {
        public static Dictionary<string, PetPostRequest> Requests =>
            new Dictionary<string, PetPostRequest>
            {
                { "Default", Default },
            };

        public static PetPostRequest Default =>
            new Faker<PetPostRequest>()
                .RuleFor(p => p.Id, p => $"{p.Random.Int(1000, 2000)}")
                .RuleFor(p => p.Status, p => EnumExtensions.GetEnumMemberValue(p.PickRandom<PetStatus>()))
                .RuleFor(p => p.Name, f => "doggie")
                .RuleFor(p => p.PhotoUrls, f => new[] { "https://petstore.swagger.io/#/pet/addPet" });
    }
}