using Bogus;
using RestSharp.Automation.Model.Domain.PetStoreUser;
using System;
using System.Collections.Generic;
using System.Text;

namespace RestSharp.Automation.TestData.Storage.PetStore
{
    public class UserUpdateStorage
    {
        public static Dictionary<string, UserUpdateRequest> Requests =>
            new Dictionary<string, UserUpdateRequest>
            {
                { "UpdateRequest", UpdateRequest },

            };
        private static UserUpdateRequest UpdateRequest =>
           new Faker<UserUpdateRequest>()
             .RuleFor(u => u.UserName, u => $"Demo{Guid.NewGuid().ToString("N")}")
             .RuleFor(u => u.Password, u => Guid.NewGuid().ToString("N"))
             .RuleFor(u => u.FirstName, u => $"Name{u.Random.Int(1, 10000)}")
             .RuleFor(u => u.LastName, u => $"LastName{u.Random.Int(1, 10000)}")
             .RuleFor(u => u.Email, u => $"demo+{Guid.NewGuid().ToString("N")}@test.com")
             .RuleFor(u => u.Phone, u => u.Phone.ToString())
             .RuleFor(u => u.UserStatus, u => (int)u.PickRandom<UserStatus>());
    }
}
