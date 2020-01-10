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
public class Registration {
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
  public void Httpswwwkaldatacom() {
    driver.Navigate().GoToUrl("https://www.kaldata.com/");
    driver.Manage().Window.Size = new System.Drawing.Size(2576, 1066);
    driver.FindElement(By.CssSelector(".td-header-sp-top-menu")).Click();
    driver.FindElement(By.CssSelector("#menu-item-114371 > a")).Click();
    driver.FindElement(By.CssSelector("li:nth-child(3) > .ipsButton")).Click();
    driver.FindElement(By.Id("elInput_username")).Click();
    driver.FindElement(By.Id("elInput_username")).SendKeys("Aleksandra");
    driver.FindElement(By.CssSelector("#form_email_address > .ipsFieldRow_label")).Click();
    driver.FindElement(By.Id("elInput_username")).Click();
    driver.FindElement(By.Id("elInput_username")).SendKeys("AleksandraP12");
    driver.FindElement(By.Id("elInput_email_address")).Click();
    driver.FindElement(By.Id("elInput_email_address")).SendKeys("003-sar11@unibit.bg");
    driver.FindElement(By.Id("elInput_password")).Click();
    driver.FindElement(By.Id("elInput_password")).SendKeys("!@#$%^&*()_+");
    driver.FindElement(By.Id("elInput_password_confirm")).Click();
    driver.FindElement(By.Id("elInput_password_confirm")).SendKeys("!@#$%^&*()_+");
    driver.FindElement(By.Id("check_b464c43ac63629a39e2eff12af3e1089")).Click();
    driver.FindElement(By.CssSelector(".ipsButton_primary")).Click();
  }
}
