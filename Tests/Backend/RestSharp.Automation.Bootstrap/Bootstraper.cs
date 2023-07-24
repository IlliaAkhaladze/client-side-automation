using System;

using Autofac;

using Automation.Common.Environment;

using Microsoft.Extensions.Configuration;

using RestSharp.Automation.Model.Platform.Communication;
using RestSharp.Automation.Platform.Communication;

using Serilog;
using Serilog.Events;
using RestSharp.Automation.Domain.PetStore;
using RestSharp.Automation.Model.Domain.PetStore;

namespace RestSharp.Automation.Bootstrap
{
	public class Bootstraper
	{
		private ContainerBuilder _builder;

		public ContainerBuilder Builder => _builder ??= new ContainerBuilder();

		public void ConfigureServices(IConfigurationBuilder configurationBuilder)
		{
			var configurationRoot = configurationBuilder.Build();
			Builder.Register<ILogger>((c, p) => new LoggerConfiguration()
				.WriteTo.File(
					$"Logs/log_{DateTime.UtcNow:yyyy_MM_dd_hh_mm_ss}.txt",
					LogEventLevel.Verbose,
					"{Timestamp:dd-MM-yyyy HH:mm:ss.fff} [{Level:u3}] {Message:lj}{NewLine}{Exception}")
				.CreateLogger())
				.SingleInstance();

			// Configurations
			var envrConfig = new EnvironmentConfiguration();
			configurationRoot.Bind("EnvironmentConfiguration", envrConfig);
			Builder.Register(p => envrConfig)
				.AsImplementedInterfaces()
				.SingleInstance();

			// Api Clients
			Builder.RegisterType<PetStoreApiClient>().As<IPetStoreApiClient>().SingleInstance();
			Builder.RegisterType<Client>().As<IClient>().InstancePerDependency();
			Builder.RegisterType<RestClient>().As<IRestClient>().InstancePerDependency();

			// Logic Steps

			// Logic Context
		}
	}
}
