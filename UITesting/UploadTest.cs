using System;
using System.Windows.Forms;

using NUnit.Framework;
using OpenQA.Selenium;

namespace ComprenoTesting.UITesting
{
	[TestFixture]
	public class UploadTest: TestBase
	{
		[Test]
		public void Upload_Ok()
		{
			//LoginTest.Login(ngDriver, baseUrl, "abbyyadmin@abbyyusa.com", "abbyydemo1");
			ngDriver.Url = new Uri(baseUri, "upload").ToString();
			ngDriver.FindElement(By.Id("drop-zone")).Click();
			// File upload dialog, Selenium can't control that
			var path = "test.pdf";
			SendKeys.SendWait(path + "~");
			System.Threading.Thread.Sleep(2000);
			/*Assert.IsTrue(ngDriver.FindElements(
				By.XPath(String.Format("//div[@class = 'file-name']", path))).Count == 1,
				"File not uploaded");*/
			ngDriver.FindElement(By.ClassName("select2-selection__rendered")).Click();
			System.Threading.Thread.Sleep(2000);
			ngDriver.FindElement(By.XPath("//input[@class = 'select2-search__field']")).Click();
			System.Threading.Thread.Sleep(2000);
			ngDriver.FindElement(By.XPath("//input[@class = 'select2-search__field']")).SendKeys("Stas Test Project");
			System.Threading.Thread.Sleep(2000);
			ngDriver.FindElement(By.XPath("//li[@class = 'select2-results__option']")).Click();
		}
	}
}
