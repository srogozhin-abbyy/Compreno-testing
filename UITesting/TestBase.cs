using System;
using System.Configuration;

using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Protractor;

namespace ComprenoTesting.UITesting
{
	[TestFixture]
	public abstract class TestBase
	{
		private readonly IWebDriver driver;
		protected readonly NgWebDriver ngDriver;

		/// <summary>
		/// Data in .config files
		/// </summary>
		protected readonly string baseUrl;
		protected readonly Uri baseUri;
		protected readonly string AdminEmail;
		protected readonly string AdminUsername;
		protected readonly string AdminPassword;
		protected readonly string TestProjectId;

		public TestBase()
		{
			ChromeOptions options = new ChromeOptions();
			options.AddArgument("--start-maximized");
			driver = new ChromeDriver(options);
			
			// Protractor only supports Firefox 47.0.1
			// Marionette driver not available in Firefox 47 - using legacy
			// http://www.protractortest.org/#/browser-support
			/*FirefoxOptions options = new FirefoxOptions();
			options.UseLegacyImplementation = true;
			driver = new FirefoxDriver(options);*/
			
			ngDriver = new NgWebDriver(driver);
			//https://github.com/angular/protractor/issues/117
			ngDriver.Manage().Timeouts().AsynchronousJavaScript = TimeSpan.FromSeconds(15);

			baseUrl = ConfigurationManager.AppSettings["url"];
			baseUri = new Uri(baseUrl);
			AdminEmail = ConfigurationManager.AppSettings["AdminEmail"];
			AdminUsername = ConfigurationManager.AppSettings["AdminUsername"];
			AdminPassword = ConfigurationManager.AppSettings["AdminPassword"];
			TestProjectId = ConfigurationManager.AppSettings["TestProjectId"];
		}

		~TestBase()
		{
			driver.Dispose();
		}
	}
}
