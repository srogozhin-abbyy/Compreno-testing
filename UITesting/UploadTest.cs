using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Abbyy.ComprenoTesting.UITesting
{
	[TestFixture]
	public class UploadTest: TestBase
	{
		[Test]
		public void Upload_Ok()
		{
			LoginTest.Login(driver, baseUrl, "abbyyadmin@abbyyusa.com", "abbyydemo1");
			wait5seconds.Until(ExpectedConditions.VisibilityOfAllElementsLocatedBy(By.TagName("main-menu")));
			driver.Url = new Uri(baseUri, "upload").ToString();
			driver.FindElement(By.Id("drop-zone")).Click();
			// File upload dialog, Selenium can't control that
			var path = "test.pdf";
			SendKeys.SendWait(path + "~");
			System.Threading.Thread.Sleep(2000);
			/*Assert.IsTrue(driver.FindElements(
				By.XPath(String.Format("//div[@class = 'file-name']", path))).Count == 1,
				"File not uploaded");*/
			driver.FindElement(By.ClassName("select2-selection__rendered")).Click();
			System.Threading.Thread.Sleep(2000);
			driver.FindElement(By.XPath("//input[@class = 'select2-search__field']")).Click();
			System.Threading.Thread.Sleep(2000);
			driver.FindElement(By.XPath("//input[@class = 'select2-search__field']")).SendKeys("Stas Test Project");
			System.Threading.Thread.Sleep(2000);
			driver.FindElement(By.XPath("//li[@class = 'select2-results__option']")).Click();
		}
	}
}
