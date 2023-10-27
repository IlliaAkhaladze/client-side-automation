namespace CSharp.Tutorials
{
	public interface IAnimal
	{
		void Voice();
		void Voice(string type);
		void Voice(int id);
		void Voice(int id, string type);
	}

	public class Animal : IAnimal
	{
		public virtual void Voice()
		{
			Console.WriteLine("Default voice");
		}

		public void Voice(string type)
		{
			Console.WriteLine($"Void with {type} type.");
		}

		public void Voice(int id)
		{
			Console.WriteLine($"Void with {id} id.");
		}

		public void Voice(int id, string type)
		{
			Console.WriteLine($"Void with {id} id, {type} type.");
		}
	}

	public class Rabbit : Animal
	{

	}

	public class Dog : Animal
	{
		public override void Voice()
		{
			base.Voice();
			Console.WriteLine("Gav - Gav");
		}
	}

	public class Cat : Animal
	{
		public override void Voice()
		{
			base.Voice();
			Console.WriteLine("May - may");
		}
	}

	internal class Program
	{

		static void Main(string[] args)
		{
			Dog dog = new Dog();
			dog.Voice("type1");
			dog.Voice(1, "type1");
			dog.Voice(1);

			Cat cat = new Cat();
			cat.Voice();

			Rabbit rab = new Rabbit();
			rab.Voice();
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