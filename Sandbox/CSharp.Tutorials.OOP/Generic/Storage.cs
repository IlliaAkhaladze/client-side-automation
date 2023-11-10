using System;

namespace CSharp.Tutorials.OOP.Generic
{
	public class Storage<T> where T : class
	{
		public virtual string Name => "DefaultStorage";
	}

	public class Print
	{
		public void PrintToConcole<T>(T storage)
		{
			Console.WriteLine($"Storage [{storage}].");
		}
	}

	public class Printos
	{

		public void PrintToConcole(Storage<CatStorage> storage)
		{
			Console.WriteLine($"Storage [{storage}].");
			//Console.WriteLine($"StorageName [{storage.Name}], Type [{storage}], [{storage.Value}].");
			//Console.WriteLine($"Type [{storage}], value [{storage.Value}].");
		}

		public void PrintToConcole(Storage<DogStorage> storage)
		{
			Console.WriteLine($"Storage [{storage}].");
			//Console.WriteLine($"StorageName [{storage.Name}], Type [{storage}], [{storage.Value}].");
		}
	}

	public class CatStorage : Storage<CatStorage>
	{
		public CatStorage()
		{

		}
	}

	public class DogStorage : Storage<DogStorage>
	{
		public override string Name => $"{base.Name} - DogStorage";
		public DogStorage()
		{
		}
	}
}
