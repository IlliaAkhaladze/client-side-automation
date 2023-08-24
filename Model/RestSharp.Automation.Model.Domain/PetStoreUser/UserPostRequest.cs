using Newtonsoft.Json;

namespace RestSharp.Automation.Model.Domain.PetStoreUser
{
	public class UserPostRequest
	{
		[JsonProperty("username")]
		public string UserName { get; set; }

		[JsonProperty("password")]
		public string Password { get; set; }
	}
}
