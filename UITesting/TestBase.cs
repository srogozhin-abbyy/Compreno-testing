using System;
using System.Configuration;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace Abbyy.ComprenoTesting.UITesting
{
	[TestFixture]
	public abstract class TestBase
	{
		protected IWebDriver driver;
		protected WebDriverWait wait5seconds;
		protected string baseUrl;
		
		public TestBase()
		{
			driver = new ChromeDriver();
			wait5seconds = new WebDriverWait(driver, TimeSpan.FromSeconds(5));
			baseUrl = ConfigurationManager.AppSettings["url"];
		}

		~TestBase()
		{
			//driver.Dispose();
		}
	}
}
