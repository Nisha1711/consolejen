using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using OpenQA.Selenium.Support.UI;
using System;

namespace ConsoleAppJen
{
    [TestFixture]
    public class BrowserTest : Hooks
    {
       

       
       [Test]
        public void Test2()
        {
            SelectElement oSelect = new SelectElement(Driver.FindElement(By.Id("TitleId")));
            oSelect.SelectByIndex(1);
            Driver.FindElement(By.Id("Initial")).SendKeys("T");
            Driver.FindElement(By.Id("FirstName")).SendKeys("ABC");
            Driver.FindElement(By.Id("MiddleName")).SendKeys("GHF");
            IWebElement radioBtn = Driver.FindElement(By.Name("Male"));
            radioBtn.Click();
            Driver.FindElement(By.Name("Save")).Click();

        }
    } }
