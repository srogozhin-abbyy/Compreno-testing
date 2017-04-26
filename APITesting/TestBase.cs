using System;
using System.Configuration;
using Microsoft.VisualStudio.TestTools.UnitTesting;

using Abbyy.ComprenoTesting.ComprenoClient;
using Abbyy.ComprenoTesting.ComprenoClient.Models;

namespace Abbyy.ComprenoTesting.APITesting
{
	[TestClass]
	public abstract class TestBase
	{
		protected string baseUrl;
		protected Client client;
		protected string token;

		public TestBase()
		{
			baseUrl = ConfigurationManager.AppSettings["url"];
			client = new Client();
		}

		public TestBase(UserRole role): this()
		{
			Credentials credentials;
			switch (role)
			{
				case UserRole.Admin:
				default:
					credentials = client.Login
					(
						ConfigurationManager.AppSettings["AdminUsername"],
						ConfigurationManager.AppSettings["AdminPassword"]
					);
					break;
			}

			token = credentials.id;
		}


	}

	public enum UserRole
	{
		Admin,
		QC,
		Reviewer
	}
}
