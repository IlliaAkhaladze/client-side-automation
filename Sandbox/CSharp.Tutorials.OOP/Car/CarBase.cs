using System;

namespace CSharp.Tutorials.OOP.Car
{
	public abstract class CarBase
	{
		public virtual string Brand()
		{
			string defaultBrand = "Default Brand";

			return defaultBrand;
		}

		public abstract DateTime DataCreation();

		protected new virtual string GetType()
		{
			var guid = Guid.NewGuid();
			Console.WriteLine($"[CarBase::GetType]{guid}");

			return guid.ToString();
		}
	}
}
