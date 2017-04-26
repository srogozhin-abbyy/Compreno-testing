using System;
using System.Configuration;

//using Microsoft.VisualStudio.TestTools.UnitTesting;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Abbyy.ComprenoTesting.UITesting
{
	[TestFixture]
	public class LoginTest: TestBase
	{

		[Test]
		public void Login_Ok()
		{
			LoginAdmin();
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("main-menu")));
			Assert.AreEqual(new Uri(new Uri(baseUrl), "dashboard/projects"), driver.Url, "Dashboard not loaded");
		}

		[Test]
		public void Login_NotEmail()
		{
			Login("yeah", "yeah");
			Assert.IsTrue(driver.FindElement(By.Id("email")).GetAttribute("class").Contains("invalid"), "Warning not shown");
		}

		private void Login(string email, string password)
		{
			Login(driver, baseUrl, email, password);
		}

		public void LoginAdmin()
		{
			Login(ConfigurationManager.AppSettings["AdminLogin"], ConfigurationManager.AppSettings["AdminPassword"]);
		}

		public static void Login(IWebDriver driver, string url, string email, string password)
		{
			driver.Url = url;
			driver.FindElement(By.Id("email")).SendKeys(email);
			driver.FindElement(By.Id("password")).SendKeys(password);
			driver.FindElement(By.TagName("button")).Click();
		}
	}
}
