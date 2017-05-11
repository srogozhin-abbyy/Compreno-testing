using NUnit.Framework;

using IO.Swagger.Api;
using IO.Swagger.Model;


namespace ComprenoTesting.APITesting
{
	[TestFixture]
	class UsersTest: TestBase
	{
		private readonly IUserApi userApi;

		public UsersTest(): base(UserRole.Admin)
		{
			userApi = new UserApi(Configuration);
		}

		[Test]
		[Category("APIBasic")]
		public void Users_GetMe_Ok()
		{
			User user = ((Newtonsoft.Json.Linq.JObject)userApi.UserMe()).ToObject<User>();
		}

		[Test]
		[Category("APIBasic")]
		public void Users_Login_Ok()
		{
			var credentials = Helper.Login(AdminUsername, AdminPassword);
			Assert.IsNotNull(credentials.id);
			Assert.AreEqual("abbyyadmin@abbyyusa.com", credentials.user.Email);
		}
	}
}
