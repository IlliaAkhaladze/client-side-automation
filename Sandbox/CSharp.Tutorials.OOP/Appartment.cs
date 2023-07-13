using System;

namespace CSharp.Tutorials.OOP
{
	public class Appartment
	{
		public string Name { get; private set; }
		private string _name;

		static Appartment()
		{

		}

		public Appartment()
		{

		}

		public Appartment(int count, string name)
		{

		}

		public void PrintSmth()
		{
			Console.WriteLine("I am print.");
		}

		public static void Voice()
		{
			Console.WriteLine("Hi!!");
		}
	}

	public class Appartment2 : Appartment
	{
		public Appartment2()
		{
			PrintSmth();
		}
	}
}