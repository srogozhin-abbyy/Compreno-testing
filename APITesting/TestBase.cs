using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using ComprenoTesting.ComprenoHelper;
using ComprenoTesting.ComprenoHelper.Models;

using IO.Swagger.Client;

namespace ComprenoTesting.APITesting
{
	[TestClass]
	public abstract class TestBase
	{	
		protected Helper Helper { get; }
		private ApiClient apiClient { get; }
		protected string Token { get; }
		private Dictionary<string, string> authorization { get; }
		protected Configuration Configuration { get;}


		/// <summary>
		/// Data in .config files
		/// </summary>
		protected string BaseUrl { get; }
		protected string AdminEmail { get; }
		protected string AdminUsername { get; }
		protected string AdminPassword { get; }
		protected string TestProjectId { get; }

		/// <summary>
		/// Basic setup
		/// </summary>
		public TestBase()
		{
			BaseUrl = System.Configuration.ConfigurationManager.AppSettings["url"];
			AdminEmail = System.Configuration.ConfigurationManager.AppSettings["AdminEmail"];
			AdminUsername = System.Configuration.ConfigurationManager.AppSettings["AdminUsername"];
			AdminPassword = System.Configuration.ConfigurationManager.AppSettings["AdminPassword"];
			TestProjectId = System.Configuration.ConfigurationManager.AppSettings["TestProjectId"];

			Helper = new Helper(BaseUrl);

			apiClient = new ApiClient(BaseUrl + "/nextapi");
		}

		/// <summary>
		/// Initialize client with specific user role
		/// Authenticate and get token for specific role
		/// Calls base constructor
		/// </summary>
		/// <param name="role">User role</param>
		public TestBase(UserRole role): this()
		{
			Credentials credentials;
			switch (role)
			{
				case UserRole.Admin:
				default:
					credentials = Helper.Login
					(
						System.Configuration.ConfigurationManager.AppSettings["AdminUsername"],
						System.Configuration.ConfigurationManager.AppSettings["AdminPassword"]
					);
					break;
			}

			Token = credentials.id;
			authorization = new Dictionary<string, string> { { "Authorization", Token } };
			Configuration = new Configuration(
				apiClient: apiClient,
				defaultHeader: authorization);

		}
	}

	public enum UserRole
	{
		Admin,
		QC,
		Reviewer
	}
}
