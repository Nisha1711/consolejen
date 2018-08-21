using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using System;

namespace ConsoleAppJen
{ [TestFixture]
    public class Hooks : Base
    {
        


        //Enum for browserType
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
            //Get the value from NUnit-console --params 
            //e.g. nunit3-console.exe --params:Browser=Firefox \SeleniumNUnitParam.dll
            //If nothing specified, test will run in Chrome browser
            var browserType = TestContext.Parameters.Get("Browser", "Chrome");
            //Parse the browser Type, since its Enum
            _browserType = (BrowerType)Enum.Parse(typeof(BrowerType), browserType);
            //Pass it to browser
            ChooseDriverInstance(_browserType);
        }

        private void ChooseDriverInstance(BrowerType browserType)
        {
            if (browserType == BrowerType.Chrome)
                Driver = new ChromeDriver();
            else if (browserType == BrowerType.Firefox)
            {
                //FirefoxDriverService service = FirefoxDriverService.CreateDefaultService();
                //service.FirefoxBinaryPath = @"C:\Program Files (x86)\Mozilla Firefox\firefox.exe";
                //service.HideCommandPromptWindow = true;
                //service.SuppressInitialDiagnosticInformation = true;
                Driver = new FirefoxDriver();
            }
            else if (browserType == BrowerType.IE)
            {
                Driver = new InternetExplorerDriver();
            }
        }
    }
}

