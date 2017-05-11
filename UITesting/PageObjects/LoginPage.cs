using OpenQA.Selenium;
using Protractor;

namespace ComprenoTesting.UITesting.PageObjects
{
	/// <summary>
	/// Login page
	/// </summary>
	public class LoginPage
	{
		private string url { get; }
		private NgWebDriver driver { get; }

		private NgWebElement emailField;
		private NgWebElement passwordField;
		private NgWebElement loginButton;

		public LoginPage(string url, NgWebDriver driver)
		{
			this.url = url;
			this.driver = driver;

			driver.Url = url;
			emailField = driver.FindElement(By.Id("email"));
			passwordField = driver.FindElement(By.Id("password"));
			loginButton = driver.FindElement(By.TagName("button"));
		}

		public LoginPage TypeEmail(string email)
		{
			emailField.SendKeys(email);
			return this;
		}

		public LoginPage TypePassword(string password)
		{
			passwordField.SendKeys(password);
			return this;
		}

		public void ClickLogin()
		{
			loginButton.Click();
		}

		public void Login(string email, string password)
		{
			TypeEmail(email);
			TypePassword(password);
			ClickLogin();
			driver.WaitForAngular();
		}

		/// <summary>
		/// Is email field showing a warning
		/// </summary>
		/// <returns>True if CSS style is invalid</returns>
		public bool IsEmailFieldWarning()
		{
			return emailField.GetAttribute("class").Contains("invalid");
		}
	}
}
