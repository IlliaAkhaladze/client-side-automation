using System;

namespace CSharp.Tutorials.OOP.Car
{
	public class Car : CarBase, ICar
	{
		public Car()
		{

		}
		public override string Brand()
		{
			return $"Car";
		}

		public override DateTime DataCreation()
		{
			var dt = DateTime.Now;
			return dt;
		}

		string ICar.GetType()
		{
			throw new NotImplementedException();
		}
	}
}
