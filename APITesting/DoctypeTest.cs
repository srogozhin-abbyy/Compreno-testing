using System.Collections.Generic;

using Newtonsoft.Json.Linq;

using NUnit.Framework;

using IO.Swagger.Api;
using IO.Swagger.Model;

namespace ComprenoTesting.APITesting
{
	[TestFixture]
	public class DoctypeTest: TestBase
	{
		private DoctypeApi doctypeApi { get; }

		public DoctypeTest(): base(UserRole.Admin)
		{
			doctypeApi = new DoctypeApi(Configuration);
		}

		[Test]
		public void Doctypes_GetDetailed_Ok()
		{
			//var doctypes = getDoctypesFromResponse(doctypeApi.DoctypeDetailed());
			//ToDo: why can't this response deserialize into Doctypes?
			var doctypes = doctypeApi.DoctypeDetailed();
			Assert.IsTrue(doctypes.Count > 0, "No doctypes loaded");
		}

		[Test]
		public void Doctypes_GetSimplified_Ok()
		{
			var doctypes = getDoctypesFromResponse(doctypeApi.DoctypeSimplified());
			Assert.IsTrue(doctypes.Count > 0, "No doctypes loaded");
		}

		private List<Doctype> getDoctypesFromResponse(List<object> response)
		{
			var doctypes = new List<Doctype> { };
			foreach (var jobject in response)
			{
				var doctype = ((JObject)jobject).ToObject<Doctype>();
				doctypes.Add(doctype);
			}
			return doctypes;
		}
	
	}
}
