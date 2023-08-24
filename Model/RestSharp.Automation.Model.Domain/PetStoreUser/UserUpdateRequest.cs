using Newtonsoft.Json;

namespace RestSharp.Automation.Model.Domain.PetStoreUser
{
	public class UserUpdateRequest : UserPostRequest
	{
		[JsonProperty("firstName")]
		public string FirstName { get; set; }
		[JsonProperty("lastName")]
		public string LastName { get; set; }
		[JsonProperty("email")]
		public string Email { get; set; }
		[JsonProperty("phone")]
		public string Phone { get; set; }
		[JsonProperty("userStatus")]
		public int UserStatus { get; set; }
	}
}