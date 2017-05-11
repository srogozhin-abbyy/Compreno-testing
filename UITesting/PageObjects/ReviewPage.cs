using System;
using System.Collections.Generic;
using System.Linq;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;
using Protractor;

namespace ComprenoTesting.UITesting.PageObjects
{
	public class ReviewPage
	{
		private string url { get; }
		private NgWebDriver driver { get; }

		private NgWebElement fullText { get; }
		private NgWebElement docTextContainer { get; }
		public List<Entity> Entities { get; }
		
		public ReviewPage(string url, NgWebDriver driver)
		{
			this.url = url;
			this.driver = driver;

			driver.Url = url;
			Entities = driver.FindElements(By.ClassName("inline-edit")).Select(i => new Entity(i)).ToList();
			docTextContainer = driver.FindElement(By.ClassName("doc-text_container"));
			fullText = driver.FindElement(By.Id("full-text"));
		}

		public void FillFields(string text)
		{
			foreach (var entity in Entities)
			{
				entity.Text = "test";
			}
		}

		public void FillFieldByDragAndDrop(Entity entity)
		{
			if(driver.WrappedDriver.GetType() != typeof(OpenQA.Selenium.Firefox.FirefoxDriver))
				throw new Exception("Drag and drop only supported in FirefoxDriver");
			entity.ActivateInput();
			Actions actions = new Actions(driver);

			//Double clicking in the middle of text container will select a word
			int x = docTextContainer.Size.Width / 2;
			int y = docTextContainer.Size.Height / 2;
			int offset = 100;
			actions.MoveToElement(docTextContainer, x, y).ClickAndHold().MoveByOffset(offset, offset).Release().Perform();
			System.Threading.Thread.Sleep(1000);
			entity.PressEnter();
		}
	}

	public class Entity
	{
		internal NgWebElement element { get; }
		private NgWebElement entityField;

		public Entity(NgWebElement element)
		{
			this.element = element;
		}

		public string Text
		{
			get
			{
				return element.FindElement(By.ClassName("entity-value-text")).Text;
			}
			set
			{
				this.ActivateInput();
				
				//Input text
				entityField.SendKeys(value);
				PressEnter();
			}
		}

		public NgWebElement ActivateInput()
		{
			//Clicking opens input field
			element.Click();
			entityField = element.FindElement(By.TagName("input"));
			return entityField;
		}

		public void PressEnter()
		{
			entityField.SendKeys(Keys.Return);
		}
	}
}
