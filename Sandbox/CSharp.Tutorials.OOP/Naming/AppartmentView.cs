using System;

namespace CSharp.Tutorials.OOP.Naming
{
	public class AppartmentView
	{
		public Appartment Appartment { get; set; }
		public string Id { get; set; }
		public string Value { get; set; }
		public int Count { get; set; }
		public TimeSpan Timeout { get; } = default;
	}
}
