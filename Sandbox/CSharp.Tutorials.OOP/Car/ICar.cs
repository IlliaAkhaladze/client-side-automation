using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tutorials.OOP.Car
{
	public interface ICar
	{
		string Brand();
		string GetType();
		DateTime DataCreation();
	}
}
