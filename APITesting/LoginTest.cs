using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using NUnit.Framework;

using Abbyy.ComprenoTesting.ComprenoClient.Models;

namespace Abbyy.ComprenoTesting.APITesting
{
	[TestFixture]
	public class LoginTest: TestBase
	{
		[Test]
		public void Login_Ok()
		{
			var credentials = client.Login(ConfigurationManager.AppSettings["AdminUsername"], ConfigurationManager.AppSettings["AdminPassword"]);
			Assert.IsNotNull(credentials.id);
			Assert.AreEqual("abbyyadmin@abbyyusa.com", credentials.user.email);
		}
	}
}
