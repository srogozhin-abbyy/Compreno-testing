using System;

using NUnit.Framework;

namespace ComprenoTesting.UITesting
{
	[TestFixture]
	public class LoginTest: TestBase
	{
		private PageObjects.LoginPage loginPage;

		[SetUp]
		public void SetUp()
		{
			loginPage = new PageObjects.LoginPage(baseUrl, ngDriver);
		}

		[Test]
		public void Login_Ok()
		{
			LoginAdmin();
			Assert.AreEqual(new Uri(new Uri(baseUrl), "dashboard/projects"), ngDriver.Url, "Dashboard not loaded");
		}

		[Test]
		public void Login_NotEmail()
		{
			loginPage.Login("notemail", "notpassword");
			Assert.IsTrue(loginPage.IsEmailFieldWarning(), "Warning not shown");
		}

		public void LoginAdmin()
		{
			loginPage.Login(AdminEmail, AdminPassword);
		}
	}
}
