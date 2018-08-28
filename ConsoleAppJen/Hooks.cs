using NUnit.Framework;
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
        private BrowerType _browserType;

        [OneTimeSetUp]
        public void InitializeTest()
        {
           
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            _browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType);
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowerType.Firefox)
            {
                Driver = new FirefoxDriver();
            }
            else if (browserType == BrowerType.IE)
            {
                Driver = new InternetExplorerDriver();
            }
        }
    }
}

