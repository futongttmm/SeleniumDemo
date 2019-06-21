using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFirst.PageObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        static void Main(string[] args)
        {


        }

        [SetUp]
        public void Initialize()
        {
            Properties.Driver = new ChromeDriver();
            Properties.Driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            //Properties.Driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void ExecuteTest()
        {
            LoginPage loginPage = new LoginPage();
            EAPage page = LoginPage("Futong", "123456");


            /*
            //how to find the right element???
            //SeleniumFirst.SeleniumSetMethod.EnterText("fakebox-input", "ABCDEFG", "Id");

            //Title
            SeleniumFirst.SeleniumSetMethod.SelectDropDown("TitleId", "Mr.", Element.Id);
            //Initial
            SeleniumFirst.SeleniumSetMethod.EnterText("Initial", "Futong", Element.Name);
            //check whether the input is what we expected
            Console.WriteLine(SeleniumFirst.SeleniumGetMethod.GetText("TitleId", Element.Id));
            Console.WriteLine(SeleniumFirst.SeleniumGetMethod.GetText("Initial", Element.Name));

            //Button
            SeleniumFirst.SeleniumSetMethod.Click("Save", Element.Name);
            */
            
        }

        private EAPage LoginPage(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        [TearDown]
        public void CleanUp()
        {
            Properties.Driver.Close();
        }
    }
}
