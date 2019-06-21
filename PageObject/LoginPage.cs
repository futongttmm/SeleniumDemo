using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst.PageObject
{
    class LoginPage
    {

        public LoginPage()
        {
            PageFactory.InitElements(Properties.Driver, this);
        }

        [FindsBy(How = How.Name, Using = "UserName")]
        public IWebElement txtUserName { get; set; }

        [FindsBy(How = How.Name, Using = "Password")]
        public IWebElement txtPassword { get; set; }

        [FindsBy(How = How.Name, Using = "Login")]
        public IWebElement btnLogin { get; set; }

        public EAPage Login(string name, string password)
        {
            LoginPage login = new LoginPage();

            login.txtUserName.SendKeys(name);
            login.txtPassword.SendKeys(password);
            login.btnLogin.Click();

            return new EAPage();
        }
    }
}
