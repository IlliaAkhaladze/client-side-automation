using System;

namespace CSharp.Tutorials.OOP
{
	public class OOP
	{

	}

	// incapsulation

	public class Incaplulation
	{
		public int Name { get; set; }
		private string _name;
		protected string ProtValue;

		public Incaplulation()
		{

		}
	}

	public interface IIncaplulation
	{
		public void SetValue(string value);
	}

	public interface IIncaplulation2
	{
		public void SetValue(string value);
	}

	public class IncapsulationChild// : IIncaplulation2, IIncaplulation
	{
		public string GetValue()
		{
			throw new NotImplementedException();
		}

		//public void IIncaplulation2.SetValue(string value)
		//{
		//	throw new NotImplementedException();
		//}

		//public void IIncaplulation.SetValue(string value)
		//{
		//	throw new NotImplementedException();
		//}
	}

	public class MyClass
	{
		public MyClass()
		{
			IIncaplulation2 inc = (IIncaplulation2)new IncapsulationChild();
			inc.SetValue("1");
		}
	}
}
