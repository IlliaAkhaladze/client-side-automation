using CSharp.Tutorials.OOP;
using CSharp.Tutorials.OOP.Car;
using CSharp.Tutorials.OOP.Generic;

namespace CSharp.Tutorials
{
	internal class Program
	{
		static void Main(string[] args)
		{
			Console.WriteLine("Hello, World!");
			//Calculator  calculator = new Calculator();
			//calculator.Plus();

			//CalculatorV2 calculatorV2 = new CalculatorV2();
			//calculatorV2.Plus();
			//calculatorV2.Plus(3, 7);
			var dogStorage = new Storage<DogStorage>();
			var catStorage = new Storage<CatStorage>();


			var print = new Print();
			Console.WriteLine($"Generic");
			print.PrintToConcole(dogStorage);
			print.PrintToConcole(catStorage);
			//print.PrintToConcole(dogStorage);


			Console.WriteLine($"Non Generic");
			Printos printos = new Printos();
			printos.PrintToConcole(dogStorage);
			printos.PrintToConcole(catStorage);



		}

		private static void Cover()
		{
			//var storageInt = new Storage<int>();
			//storageInt.Value = 1;

			//var storageString = new Storage<string>();
			//storageString.Value = "test";

			//Console.WriteLine($"Storage int has [{storageInt.Value}] value.");
			//Console.WriteLine($"Storage int has [{storageString.Value}] value.");
		}

		private static void ThrownEx()
		{
			throw new NotImplementedException();
		}

		private static void Construct()
		{
			//if (true == false)
			//{

			//}
			//if (true)
			//{

			//}

			//var myBool = true;
			//if (myBool)
			//{

			//}
			//else
			//{

			//}

			////string myString = "myString";
			////if(string.IsNullOrEmpty(myString) )
			////{

			////}else if (myString.Length > 10)
			////{

			////}

			////do
			////{

			////}
			////while(true) 
			////{
			////	Console.WriteLine();
			////}


			//while (true)
			//{

			//}

			//string[] abc = new string[] { "a", "b", "c" };

			//for (int i = 0; abc.Length > 10; i++)
			//{

			//}

			////var list = abc.ToList();
			//foreach (var item in abc)
			//{

			//}

			//try
			//{
			//	ThrownEx();
			//}
			//catch//()
			//{

			//}
			////catch (Exception ex)
			////{
			////	Console.WriteLine($"Exception: {ex}.");
			////}
			//catch (OutOfMemoryException ex)
			//{

			//}
			//catch (NotImplementedException ex)
			//{

			//}
		}
	}



	public class StorageBase
	{

	}



	public class Calculator
	{
		public Calculator()
		{

		}

		public Calculator(
			string calcNName)
		{

		}

		public void Print()
		{
		}

		public virtual void Plus()
		{
			Console.WriteLine($"Plus operation in Calculator");
		}

		public virtual void Plus(int x, int y)
		{
			Console.WriteLine($"Plus operation with [{x}] value1, [{y}] value2 in Calculator");
		}

		protected void Minus()
		{
			Console.WriteLine("Minus operation");
		}

	}

	public class CalculatorV2 : Calculator
	{
		public CalculatorV2()
		{

		}
		public CalculatorV2(string calcNName) 
			: base(calcNName)
		{
		}

		public override void Plus()
		{
			Console.WriteLine($"Plus operation in CalculatorV2");
		}

		public new void Plus(int x, int y)
		{
			Console.WriteLine($"Plus operation with [{x}] value1, [{y}] value2 in Calculator");
		}

		public void Minus()
		{
			base.Minus();
		}

	}

	public abstract class Birds
	{
		public abstract void Voice();
		public abstract bool IsFlying();

		public virtual void InGroup()
		{
			Console.WriteLine("Default behavior");
		}

		public bool RetirnsV()
		{
			return true;
		}

	}

	public class Gorobez : Birds
	{
		public override bool IsFlying()
		{
			throw new NotImplementedException();
		}

		public override void Voice()
		{
			Console.WriteLine("Gorobez voice.");
		}

		public override void InGroup()
		{
			Console.WriteLine("Default behavior");
		}
	}

	public class Sova : Birds
	{
		public override bool IsFlying()
		{
			throw new NotImplementedException();
		}

		public override void Voice() 
		{
			Console.WriteLine("Sova voice.");
		}
	}

	public class Pigvin : Birds
	{
		public override bool IsFlying()
		{
			throw new NotImplementedException();
		}

		public override void Voice()
		{
			Console.WriteLine("Pigvin voice.");
		}
	}
}