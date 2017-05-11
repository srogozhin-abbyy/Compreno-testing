using ComprenoTesting.UITesting.PageObjects;
using NUnit.Framework;

namespace ComprenoTesting.UITesting
{
	/// <summary>
	/// Summary description for UnitTest1
	/// </summary>
	[TestFixture]
	public class ReviewTest: TestBase
	{
		private ReviewPage reviewPage;

		public ReviewTest()
		{
			var loginPage = new LoginPage(baseUrl, ngDriver);
			loginPage.Login(AdminEmail, AdminPassword);
			reviewPage = new ReviewPage("http://devata.abbyyusa.com/validate/preview/590b42098b32a97b727e834b", ngDriver);
			//reviewPage = new ReviewPage("http://66.6.124.181/validate/preview/59079263bc18712c074ac85d", ngDriver);
		}

		[Test]
		public void TestManualInput()
		{
			var entity = reviewPage.Entities[0];
			var text = entity.Text;
			var testText = "This is a test entry";
			entity.Text = testText;
			Assert.AreEqual(text + testText, entity.Text, "Wrong field text");
		}

		[Test]
		public void TestFillBySelection()
		{
			var entity = reviewPage.Entities[0];
			var oldText = entity.Text;
			reviewPage.FillFieldByDragAndDrop(entity);
			Assert.AreNotEqual(oldText,entity.Text, "Field text not changed");
		}
	}
}
