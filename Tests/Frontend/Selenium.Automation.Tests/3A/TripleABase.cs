using System;

using Autofac;

using Selenium.Automation.Tests.Hooks;

namespace Selenium.Automation.Tests._3A
{
	public class TripleABase : IDisposable
	{
		protected IContainer Container { get; set; }

		public TripleABase()
		{
			var containerBuilder = TestDependencies.CreateContainerBuilder();
			Container = containerBuilder.Build();
		}

		public void Dispose()
		{
			Container.Dispose();
		}
	}
}
