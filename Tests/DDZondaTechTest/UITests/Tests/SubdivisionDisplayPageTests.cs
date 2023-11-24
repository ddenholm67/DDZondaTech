using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Tests
{
    [TestFixture]
    public class SubDivisionDisplayPageTests
    {
        private IWebDriver driver;
        private SubdivisionDisplayPage subdivisionPage;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("Http://localhost:3000");
            subdivisionPage = new SubdivisionDisplayPage(driver);
        }

        [Test]
        public void ClickDropDown()
        {
            subdivisionPage.ClickStatusCodeFilterDropDown();
        
            Thread.Sleep(7000);

        }

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
