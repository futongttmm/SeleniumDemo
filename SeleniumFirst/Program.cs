using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class Program
    {
        IWebDriver driver = new ChromeDriver();
        static void Main(string[] args)
        {


        }

        [SetUp]
        public void Initialize()
        {
            //driver.Navigate().GoToUrl("http://www.executeautomation.com/demosite/index.html?UserName=&Password=&Login=Login");
            driver.Navigate().GoToUrl("http://www.google.com");
            //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [Test]
        public void ExecuteTest()
        {
            //how to find the right element???
            SeleniumFirst.SeleniumSetMethod.EnterText(driver, "fakebox-input", "ABCDEFG", "Id");

            /*
            //Title
            SeleniumFirst.SeleniumSetMethod.SelectDropDown(driver, "TitleId", "Mr.", "Id");
            //Initial
            SeleniumFirst.SeleniumSetMethod.EnterText(driver, "Initial", "Futong", "Name");
            //check whether the input is what we expected
            Console.WriteLine(SeleniumFirst.SeleniumGetMethod.GetText(driver, "TitleId", "Id"));
            Console.WriteLine(SeleniumFirst.SeleniumGetMethod.GetText(driver, "Initial", "Name"));

            //Button
            SeleniumFirst.SeleniumSetMethod.Click(driver, "Save", "Name");
            */
        }

        [TearDown]
        public void CleanUp()
        {
            driver.Close();
        }
    }
}
