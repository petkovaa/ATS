// Generated by Selenium IDE
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Remote;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium.Interactions;
using NUnit.Framework;
[TestFixture]
public class Login {
  private IWebDriver driver;
  public IDictionary<string, object> Vars {get; private set;}
  private IJavaScriptExecutor js;
  [SetUp]
  public void SetUp() {
    driver = new ChromeDriver();
    js = (IJavaScriptExecutor)driver;
    Vars = new Dictionary<string, object>();
  }
  [TearDown]
  protected void TearDown() {
    driver.Quit();
  }
  [Test]
  public void Frfrf() {
    driver.Navigate().GoToUrl("https://www.kaldata.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(2576, 1066);
    driver.FindElement(By.CssSelector("#menu-item-114371 > a")).Click();
    driver.FindElement(By.Id("elUserSignIn")).Click();
    driver.FindElement(By.LinkText("Вход")).Click();
    driver.FindElement(By.Id("auth")).Click();
    driver.FindElement(By.Id("auth")).SendKeys("AleksandraP");
    driver.FindElement(By.Id("password")).Click();
    driver.FindElement(By.Id("password")).SendKeys("!@#$%^&*()_+");
    driver.FindElement(By.CssSelector(".ipsFieldRow:nth-child(3) .ipsFieldRow_label")).Click();
    driver.FindElement(By.Id("elSignIn_submit")).Click();
    driver.FindElement(By.Id("elUserLink")).Click();
    {
      var element = driver.FindElement(By.LinkText("Изход"));
      Actions builder = new Actions(driver);
      builder.MoveToElement(element).Perform();
    }
    {
      var element = driver.FindElement(By.TagName("body"));
      Actions builder = new Actions(driver);
    }
    Assert.That(driver.FindElement(By.LinkText("Изход")).Text, Is.EqualTo("Изход"));
  }
}
