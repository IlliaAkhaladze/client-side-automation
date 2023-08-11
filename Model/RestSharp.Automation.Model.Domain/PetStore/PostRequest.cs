using System;

namespace RestSharp.Automation.Model.Domain.PetStore
{
	public class PostRequest
	{
		public string Id { get; set; }
		public string PetId { get; set; }
		public int Quantity { get; set; }
		public DateTime ShipDate { get; set; }
		public string Status { get; set; }
		public bool Complete { get; set; }
	}
}
