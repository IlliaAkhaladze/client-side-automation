using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tutorials.OOP.Car
{
		public interface IFordCar : ICanControl, ICanSecure
	{
		DateTime DataCreation();
	}

	public class FordCar : Car, IFordCar
	{
		public FordCar()
		{

		}

		public override string Brand()
		{
			return $"Ford";
		}

		public void Back()
		{
			Console.WriteLine($"Can move back");
		}

		public void Left()
		{
			Console.WriteLine($"Can move left");
		}

		public void Lock()
		{
			Console.WriteLine($"Can Lock.");
		}

		public void Move()
		{
			Console.WriteLine($"Can move move.");
		}

		public void Right()
		{
			LogMessage("right.");
		}

		public void UnLock()
		{
			LogMessage("UnLock");
		}

		private void LogMessage(string pathOfMessage)
		{
			Console.WriteLine($"Can {pathOfMessage}.");
		}
	}
}
