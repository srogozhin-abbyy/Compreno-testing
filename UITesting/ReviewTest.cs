using System;
using System.Text;
using System.Collections.Generic;
using NUnit.Framework;

using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Abbyy.ComprenoTesting.UITesting
{
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestFixture]
	public class ReviewTest: TestBase
	{
		public ReviewTest()
		{
			//
			// TODO: Add constructor logic here
			//
		}

		private TestContext testContextInstance;

		/// <summary>
		///Gets or sets the test context which provides
		///information about and functionality for the current test run.
		///</summary>
		public TestContext TestContext
		{
			get
			{
				return testContextInstance;
			}
			set
			{
				testContextInstance = value;
			}
		}

		#region Additional test attributes
		//
		// You can use the following additional attributes as you write your tests:
		//
		// Use ClassInitialize to run code before running the first test in the class
		// [ClassInitialize()]
		// public static void MyClassInitialize(TestContext testContext) { }
		//
		// Use ClassCleanup to run code after all tests in a class have run
		// [ClassCleanup()]
		// public static void MyClassCleanup() { }
		//
		// Use TestInitialize to run code before running each test 
		// [TestInitialize()]
		// public void MyTestInitialize() { }
		//
		// Use TestCleanup to run code after each test has run
		// [TestCleanup()]
		// public void MyTestCleanup() { }
		//
		#endregion

		[Test]
		public void TestManualInput()
		{
			LoginTest.Login(driver, baseUrl, "abbyyadmin@abbyyusa.com", "abbyydemo1");
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("main-menu")));
			/*driver.Url = new Uri(new Uri(baseUrl), "sampling").ToString();
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("dropdown-button")));
			driver.
				FindElement(By.CssSelector("sampling-filter")).
				FindElement(By.ClassName("dropdown-button")).Click();
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("sampling-filter-show-document-stage")));
			driver.
				FindElement(By.Id("sampling-filter-show-document-stage")).
				FindElement(By.XPath("//label[@for = 'docStage_2']")).
				Click();

			driver.
				FindElement(By.Id("center")).
				FindElement(By.XPath("//a[contains(@href, 'validate')]")).
				Click();*/
			
			driver.Url = "http://devata.abbyyusa.com/validate/preview/58d1745c4af40a7aed40a442";
			wait5seconds.Until(ExpectedConditions.ElementIsVisible(By.XPath("//div[@data-status = 'warning']")));
			var element = driver.FindElement(By.XPath("//div[@data-status = 'warning']"));
			element.Click();
			element.Click();
			element.SendKeys("jajajajajaja");
		}

		[Test]
		public void SelectStage_Ok()
		{
			LoginTest.Login(driver, baseUrl, "abbyyadmin@abbyyusa.com", "abbyydemo1");
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("main-menu")));
			driver.Url = new Uri(new Uri(baseUrl), "sampling").ToString();
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.ClassName("dropdown-button")));
			driver.
				FindElement(By.CssSelector("sampling-filter")).
				FindElement(By.ClassName("dropdown-button")).Click();
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.Id("sampling-filter-show-document-stage")));

			var StageSelect = new SelectElement(driver.
				FindElement(By.Id("sampling-filter-show-document-stage")));

			StageSelect.SelectByText("Ready to Validate");

			StageSelect.SelectedOption.Click();
		}
	}
}
