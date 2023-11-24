using OpenQA.Selenium;
using UITests.Page_Elements;

namespace UITests
{
    public class SubdivisionDisplayPage
    {
        private IWebDriver driver;

        private By statusCodeFilterDropDownLocator = By.XPath(SubdivisionDisplayPageRepo.StatusCodeFilterDropdown);
       

        public SubdivisionDisplayPage(IWebDriver driver) 
        {
            this.driver = driver;
        }

        public void ClickStatusCodeFilterDropDown()
        {
            driver.FindElement(statusCodeFilterDropDownLocator).Click();
        }


    }
}