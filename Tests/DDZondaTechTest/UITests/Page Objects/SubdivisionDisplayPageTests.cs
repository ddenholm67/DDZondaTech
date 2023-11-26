using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using UITests.Page_Elements;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace UITests.Tests
{
    
    public class SubDivisionDisplayPageTests
    {
        private IWebDriver driver;
       
        public SubDivisionDisplayPageTests()
        {
            driver = new ChromeDriver();
        }

        public void NavigateTo(string url)
        {
            driver.Navigate().GoToUrl(url);
        }

        public bool CorrectRowCount(int rowCount)
        {
            IWebElement table = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.SubdivisionTable));

            IReadOnlyCollection<IWebElement> rows = table.FindElements(By.TagName("tr"));

            var actualRowCount = rows.Count() - 1; //Minus Header

            return actualRowCount == rowCount;
        }

        public bool PageNumberCorrect(string pageNumber)
        {
            IWebElement actualPageNumber = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.PageNumber));

            var pageText = actualPageNumber.Text;

            return pageText == pageNumber;
        }

        public bool IsLeftArrowEnabled()
        {
            IWebElement leftArrow = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.LeftArrow));

            return leftArrow.Enabled;
        }

        public void ClickShowDropdown()
        {
            IWebElement showDropdown = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.ShowDropDown));

            showDropdown.Click();
        }

        public void ClickShowDropdownElement(string element)
        {
            IWebElement showDropdownElement;

            switch (element)
            {
                case "Show 10":
                    showDropdownElement = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.ShowDropDown10));
                    showDropdownElement.Click();
                    break;

                case "Show 20":
                    showDropdownElement = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.ShowDropDown20));
                    showDropdownElement.Click();
                    break;

                case "Show 50":
                    showDropdownElement = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.ShowDropDown50));
                    showDropdownElement.Click();
                    break;

                default:
                    Console.WriteLine("Invalid Element!");
                    break;
            } 
        }

        public bool IsShowDropDownTextCorrect(string text)
        {
            IWebElement showDropdown = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.ShowDropDown));

            var showDropdownText = showDropdown.Text;

            return showDropdownText == text;
        }

        public void ClickRightArrow()
        {
            IWebElement rightArrow = driver.FindElement(By.XPath(SubdivisionDisplayPageRepo.RightArrow));

            rightArrow.Click();
        }
    }
}
