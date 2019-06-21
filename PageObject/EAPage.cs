using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.PageObject
{
    class EAPage
    {
        public EAPage()
        {
            PageFactory.InitElements(Properties.Driver, this);
        }

        //[FindsBy(How = How.Id, Using = "TitleId")]
        //public IWebElement ddlTitle { get; set; }

        [FindsBy(How = How.Name, Using = "Initial")]
        public IWebElement txtInitial { get; set; }

        [FindsBy(How = How.Name, Using = "FirstName")]
        public IWebElement txtFirstName { get; set; }

        [FindsBy(How = How.Name, Using = "MiddleName")]
        public IWebElement txtMiddleName { get; set; }

        [FindsBy(How = How.Name, Using = "Save")]
        public IWebElement btnSave { get; set; }

        public void FillOutForm(string initial, string firstName, string middleName)
        {
            EAPage eaPage = new EAPage();

            eaPage.txtInitial.SendKeys("initial");
            eaPage.txtFirstName.SendKeys("firstName");
            eaPage.txtMiddleName.SendKeys("middleName");
        }

    }
}
