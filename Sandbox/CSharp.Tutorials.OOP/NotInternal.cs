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
