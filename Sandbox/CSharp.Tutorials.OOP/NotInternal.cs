using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp.Tutorials.OOP
{
	public class NotInternal
	{
		private Appartment _appartment;
		public NotInternal()
		{
			_appartment = new Appartment();
		}

		public Appartment GetAppartment()
		{
			return _appartment;
		}
	}
}
