using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace ConsoleAppJen
{ [TestFixture]
    public class Hooks : Base
    {
       
        public enum BrowerType
        {
            Chrome,
            Firefox,
            IE
        }
        string t = "admin", v="admin";
        string t1 = "admin1", v1 = "admin1";
        string t2 = "admin2", v2 = "admin2";

        private BrowerType _browserType;

        [OneTimeSetUp]
        public void InitializeTest()
        {
           
            var browserType = TestContext.Parameters.Get("Browser", "IE");
            _browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType);
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
            {
                Driver = new ChromeDriver();
                Login(t,v);
            }

            else if (browserType == BrowerType.Firefox)
            {
                Driver = new FirefoxDriver();
                Login(t1, v1);
            }
            else if (browserType == BrowerType.IE)
            {
                Driver = new InternetExplorerDriver();
                Login(t2, v2);
            } }

          public  void Login(String t,String v)
            {
                Driver.Navigate().GoToUrl("http://executeautomation.com/demosite/Login.html");
                Driver.FindElement(By.Name("UserName")).SendKeys(t);
                Driver.FindElement(By.Name("Password")).SendKeys(v);
                Driver.FindElement(By.XPath("/html/body/form/p[3]/input")).Click();
            }
        
    }
    }


