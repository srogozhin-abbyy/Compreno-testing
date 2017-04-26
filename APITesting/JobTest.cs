using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Abbyy.ComprenoTesting.APITesting;
using NUnit.Framework;

using IO.Swagger.Model;
using IO.Swagger.Api;
using IO.Swagger.Client;

namespace Abbyy.ComprenoTesting.APITesting
{
	[TestFixture]
	public class JobTest: TestBase
	{
		private ApiClient client;
		private ContainerApi containerApi;
		private JobApi jobApi;

		public JobTest() : base(UserRole.Admin)
		{
			client = new ApiClient(baseUrl + "/nextapi");
			Dictionary<string, string> authorization = 
				new Dictionary<string, string> { {"Authorization", token}};
			Configuration configuration = new Configuration(
			apiClient: client,
			defaultHeader: authorization);
			jobApi = new JobApi(configuration);
		}

		[Test]
		public void FindOne_Ok()
		{
			var job = jobApi.JobFindOne("");
			Console.WriteLine(job.OrganizationId);
		}
	}
}
