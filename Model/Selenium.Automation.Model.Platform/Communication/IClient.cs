using System.Threading.Tasks;

using RestSharp;

namespace Selenium.Automation.Model.Platform.Communication
{
	public interface IClient
	{
		Task<IRestResponse> ExecuteAsync(IRestRequest request);
		void SetBaseUri(string baseUri);
		void AddHttpBasicAuthenticator(string userName, string password);
	}
}
