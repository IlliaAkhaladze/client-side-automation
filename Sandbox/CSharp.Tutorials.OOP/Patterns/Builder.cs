namespace CSharp.Tutorials.OOP.Patterns
{
	public class Dog
	{
		public string Name { get; set; }
		public int Age { get; set; }
		public int Height { get; set; }
		public string Parrent { get; set; }
		public bool IsAlive { get; set; }
		public int Count { get; set; }
	}

	public class BuilderDog
	{
		private static Dog _dog;

		public static BuilderDog AddName(
			string name)
		{
			_dog = new Dog();
			_dog.Name = name;
			return new BuilderDog();
		}

		public BuilderDog AddAge(int age)
		{
			_dog.Age = age;
			return this;
		}

		public BuilderDog AddHeight(int height)
		{
			_dog.Height = height;
			return this;
		}

		public BuilderDog AddParrent(string parent)
		{
			_dog.Parrent = parent;
			return this;
		}

		public BuilderDog AddIsAlive(bool isAlive)
		{
			_dog.IsAlive = isAlive;
			return this;
		}

		public BuilderDog AddCount(int count)
		{
			_dog.Count = count;
			return this;
		}

		public Dog Build()
		{
			return _dog;
		}
	}
}
