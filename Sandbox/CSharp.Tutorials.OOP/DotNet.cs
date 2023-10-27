using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp.Tutorials.OOP
{
	public class DotNet
	{
		// 
		public DotNet()
		{
			List<string> list = new List<string>();


			object obj = new object();
			obj = "ddd";
			obj = 1;
			obj = true;

			if (true)
			{

			}else
			{

			}

			if (true)
			{

			}

			if(true)
			{

			}

			IEnumerable<string> values = new List<string>();

			var elemst = new[] { 1, 2, 3, 4 };
			elemst.ToList().ForEach(x => { Console.WriteLine(x); });

			for (int i = 0; i < elemst.Length ; i++)
			{
				Console.WriteLine($"Printr: {elemst[i]}.");
			}

			for(; ; )
			{

			}

			while(true)
			{

			}

			do 
			{ 

			} while(true);

			try
			{

			}
			catch (Exception ex)
			{
				Console.WriteLine("Smth looks bad.");
			}
			finally 
			{
				Console.WriteLine();
			}


			foreach (var elem in elemst)
			{
				Console.WriteLine($"Printr: {elemst}.");
			}
		}

		public void DemoSwitch(SwithType swithType)
		{
			try
			{
				switch (swithType)
				{
					case SwithType.Default:
						Console.WriteLine("Default");
						break;
					case SwithType.First:
						Console.WriteLine("First");
						break;
					case SwithType.Last:
						Console.WriteLine("last");
						break;
					default:

						break;
				}
			}
			catch (Exception ex)
			{
				Console.WriteLine(ex);
			}
		}

		public void Init(StringParent stringParent)
		{
			Console.WriteLine(stringParent.Name);
		}

		public void Demo()
		{
			Init(new StringParent());
			Init(new StringChild());
			Init(new StringChinlLevel2());
		}
	}

	public enum SwithType
	{
		Default, 
		First,
		Last,
		OneMore
	}

	public class StringParent
	{
		public string Name { get; set; }
	}

	public class StringChild : StringParent
	{
	}

	public class StringChinlLevel2 : StringChild
	{

	}
}
