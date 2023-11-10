using Bogus;
using RestSharp.Automation.Model.Domain.PetStoreUser;
using System;
using System.Collections.Generic;

namespace RestSharp.Automation.TestData.Storage.PetStore
{
    public class UserRequestStorage
    {
        public static Dictionary<string, UserPostRequest> Requests =>
            new Dictionary<string, UserPostRequest>
            {
                { "Demo", Demo },

            };
        private static UserPostRequest Demo =>
            new Faker<UserPostRequest>()
                .RuleFor(u => u.UserName, u => $"Demo{Guid.NewGuid().ToString("N")}")
                .RuleFor(u => u.Password, u => "password1234");
    }
}
