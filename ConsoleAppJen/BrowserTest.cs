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
    public class BrowserTEst : Hooks
    {



        [Test]
        public void Test1()
        {

            Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
            Driver.FindElement(By.Name("UserName")).SendKeys("admin");
            Driver.FindElement(By.Name("Password")).SendKeys("admin");
            Driver.FindElement(By.XPath("/html/body/form/p[3]/input")).Click();
        }


        [Test]
        public void Test2()
        {
            SelectElement oSelect = new SelectElement(Driver.FindElement(By.Id("TitleId")));
            oSelect.SelectByIndex(1);
            Driver.FindElement(By.Id("FirstName")).SendKeys("Nisha");

        }
    }
}