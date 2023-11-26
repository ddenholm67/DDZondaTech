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

namespace UITests.Tests
{
    [Binding]
    public class SpecflowTests
    {
        private SubDivisionDisplayPageTests subDivisionDisplayPageTests;

        [Given(@"I am a user")]
        public void GivenIAmAUser()
        {
            subDivisionDisplayPageTests = new SubDivisionDisplayPageTests();
        }

        [When(@"I visit ""([^""]*)""")]
        public void WhenIVisit(string url)
        {
            subDivisionDisplayPageTests.NavigateTo(url);
        }

        [Then(@"I am presented with ""([^""]*)"" results")]
        public void ThenIAmPresentedWithResults(int resultCount)
        {
            Assert.IsTrue(subDivisionDisplayPageTests.CorrectRowCount(resultCount));
        }

        [Then(@"I am told I am on page ""([^""]*)""")]
        public void ThenIAmToldIAmOnPage(string pageNumber)
        {
            Assert.IsTrue(subDivisionDisplayPageTests.PageNumberCorrect(pageNumber));
        }

        [Then(@"the left arrow is disabled")]
        public void ThenTheLeftArrowIsDisabled()
        {
            Assert.IsFalse(subDivisionDisplayPageTests.IsLeftArrowEnabled());
        }

        [When(@"I click the ""([^""]*)"" dropdown and select ""([^""]*)""")]
        public void WhenIClickTheDropdownAndSelect(string show, string element)
        {
            subDivisionDisplayPageTests.ClickShowDropdown();
            subDivisionDisplayPageTests.ClickShowDropdownElement(element);
        }

        [Then(@"the ""([^""]*)"" dropdown UI is updated to say ""([^""]*)""")]
        public void ThenTheDropdownUIIsUpdatedToSay(string show, string text)
        {
            Assert.IsTrue(subDivisionDisplayPageTests.IsShowDropDownTextCorrect(text));
        }

        [When(@"I click the right arrow once")]
        public void WhenIClickTheRightArrowOnce()
        {
            subDivisionDisplayPageTests.ClickRightArrow();
        }


        [Then(@"the right arrow is disabled")]
        public void ThenTheRightArrowIsDisabled()
        {
            throw new PendingStepException();
        }

    }
}
