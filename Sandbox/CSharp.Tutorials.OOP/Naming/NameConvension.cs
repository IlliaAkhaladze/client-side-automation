using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;

using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace CSharp.Tutorials.OOP.Naming
{
	public interface IServiceProvider
	{

	}

	public class NameConvension
	{
		private readonly string _name;
		private const string DEFAULT = "DEFAULT";
		private readonly string[] _names;

		public readonly string Name;
		public const string MODE = "DEFAULT";
		public readonly string[] Names;
		public int GetCount { get; private set; }

		public NameConvension()
		{
		}

		public NameConvension(
			AppartmentView appartmentView,
			IServiceProvider serviceProvider)
		{
		}

		public void Proceed()
		{
		}

		public void Proceed(
			Appartment appartment,
			string id,
			string value,
			int count,
			TimeSpan timeout = default)
		{
			Console.WriteLine($"Args: [{appartment} appartment, {id} id, {value} value, {count} count, {timeout} timeout].");
			Console.WriteLine($"Args: [{JsonConvert.SerializeObject(appartment)}]");
		}
		
		public void Proceed(
			AppartmentView appartmentView)
		{
			Console.WriteLine($"Args: [{appartmentView.Appartment} appartment, {appartmentView.Id} id, {appartmentView.Value} value, {appartmentView.Count} count, {appartmentView.Timeout} timeout].");
			Console.WriteLine($"Args: [{JsonConvert.SerializeObject(appartmentView.Appartment)}]");
		}

		public bool IsChecked()
		{ 
			return true; 
		}

		public Appartment GetAppartment() 
		{
			return GetAppartment();
		}

		public void SetValue(
			string value, 
			Appartment appartment)
		{

		}

		private void ProceedInternal(
			AppartmentView appartmentView)
		{
			Console.WriteLine($"Args: [{appartmentView.Appartment} appartment, {appartmentView.Id} id, {appartmentView.Value} value, {appartmentView.Count} count, {appartmentView.Timeout} timeout].");
			Console.WriteLine($"Args: [{JsonConvert.SerializeObject(appartmentView.Appartment)}]");
		}

		private bool IsCheckedInternal()
		{
			return true;
		}

		private Appartment GetAppartmentInternal()
		{
			return GetAppartment();
		}

		private void SetValueInternal(
			string value,
			Appartment appartment)
		{

		}

	}
}
