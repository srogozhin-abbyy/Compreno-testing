using NUnit.Framework;

using IO.Swagger.Api;

namespace ComprenoTesting.APITesting
{
	[TestFixture]
	public class MarkupTest: TestBase
	{
		private MarkupApi markupApi { get; }
		private JobApi jobApi { get; }

		public MarkupTest(): base(UserRole.Admin)
		{
			jobApi = new JobApi(Configuration);
			markupApi = new MarkupApi(Configuration);
		}

		[Test]
		[Category("APIBasic")]
		public void Markups_GetByFilter_Ok()
		{
			var jobId = Helper.GetAJobId("Ready to Validate", TestProjectId);
			Helper.GetMarkupsByFilter(jobId);
		}
	}
}
