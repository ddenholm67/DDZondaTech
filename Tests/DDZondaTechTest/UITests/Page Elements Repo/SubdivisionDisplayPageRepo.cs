using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UITests.Page_Elements
{
    public class SubdivisionDisplayPageRepo
    {
        public const string StatusCodeFilterDropdown = "/html/body/div/div/div/div[1]/div[1]/button"; //Xpath is extremely volatile
        public const string SubdivisionTable = "/html/body/div/div/div/table";
        public const string PageNumber = "/html/body/div/div/div/div[2]/span/div";
        public const string LeftArrow = "/html/body/div/div/div/div[2]/button[1]";
        public const string RightArrow = "/html/body/div/div/div/div[2]/button[2]";
        public const string ShowDropDown = "/html/body/div/div/div/div[2]/select";
        public const string ShowDropDown10 = "/html/body/div/div/div/div[2]/select/option[1]";
        public const string ShowDropDown20 = "/html/body/div/div/div/div[2]/select/option[2]";
        public const string ShowDropDown30 = "/html/body/div/div/div/div[2]/select/option[3]";
        public const string ShowDropDown40 = "/html/body/div/div/div/div[2]/select/option[4]";
        public const string ShowDropDown50 = "/html/body/div/div/div/div[2]/select/option[5]";
    }
}
