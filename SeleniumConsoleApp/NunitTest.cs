using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConsoleApp
{
    class NunitTest
    {
        IWebDriver driver;

        [TearDown]
        public void EndTest()
        {
            //driver.Close();
        }

        [Test]
        public void OpenAppTest()
        {
            driver.Url = "http://toolsqa.com/selenium-webdriver/c-sharp/set-up-selenium-webdriver-with-visual-studio-in-c/";
        }

        [SetUp]
        public void Initialize()
        {
            driver = new ChromeDriver();
        }
    }
}
