using System.Collections.Generic;

using Bogus;

using RestSharp.Automation.Model.Domain.PetStore;

namespace RestSharp.Automation.TestData.Storage.PetStore
{
	public static class PetStoreRequestStorage
	{
		public static Dictionary<string, PostRequest> Requests =>
			new Dictionary<string, PostRequest> 
			{
				{ "Default", Default },
			};

		public static PostRequest Default =>
			new Faker<PostRequest>()
				.RuleFor(u => u.Id, u => $"{u.Random.Int(5000, 10000)}")
				.RuleFor(u => u.PetId, u => $"{u.Random.Int(5000, 10000)}")
				.RuleFor(u => u.Quantity, u => u.Random.Int(5000, 10000))
				.RuleFor(u => u.ShipDate, u => u.Date.Past())
				.RuleFor(u => u.Status, PetStatus.Available.ToString())
				.RuleFor(u => u.Complete, true);
	}
}
