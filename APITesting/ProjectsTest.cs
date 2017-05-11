using System.Collections.Generic;
using NUnit.Framework;

using IO.Swagger.Api;
using IO.Swagger.Model;

namespace ComprenoTesting.APITesting
{
	[TestFixture]
	public class ProjectsTest: TestBase
	{
		private IProjectApi projectApi { get; }

		public ProjectsTest(): base(UserRole.Admin)
		{
			projectApi = new ProjectApi(Configuration);
		}

		[Test]
		[Category("APIBasic")]
		public void Projects_GetDetailed_Ok()
		{
			var projects = projectApi.ProjectDetailed();
		}

		[Test]
		[Category("APIBasic")]
		public void Projects_GetByRegexp_Ok()
		{
			List<Project> projects = Helper.GetProjectsByFilter("filter[where][name][regexp]=/(?:)/i");
			Assert.IsTrue(projects.Count > 0, "No projects loaded");
		}
	}
}
