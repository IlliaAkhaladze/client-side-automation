using System;

namespace RestSharp.Automation.Model.Domain.PetStore
{
	public class PostRequest
	{
		public int Id { get; set; }
		public int PetId { get; set; }
		public int Quantity { get; set; }
		public DateTime ShipDate { get; set; }
		public string Status { get; set; }
		public bool Complete { get; set; }
	}
}
