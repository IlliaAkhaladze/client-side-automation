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
				.RuleFor(u => u.ShipDate, u => u.Date.Past())
				.RuleFor(u => u.Status, u => PetStatus.Available.ToString())
				.RuleFor(u => u.Complete, true);
	}
}
