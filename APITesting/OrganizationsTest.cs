using NUnit.Framework;

using IO.Swagger.Api;

namespace ComprenoTesting.APITesting
{
	[TestFixture]
	public class OrganizationsTest: TestBase
	{
		private OrganizationApi organizationApi { get; }

		public OrganizationsTest(): base(UserRole.Admin)
		{
			organizationApi = new OrganizationApi(Configuration);
		}

		[Test]
		[Category("APIBasic")]
		public void Organizations_Get_Stats_Ok()
		{
			var stats = organizationApi.OrganizationStats();
		}
	}
}
