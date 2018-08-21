using OpenQA.Selenium;
using NUnit.Framework;

namespace ConsoleAppJen
{

    [TestFixture]     //Base class
    public class Base
    { 

        public IWebDriver Driver { get; set; }

        }
    }