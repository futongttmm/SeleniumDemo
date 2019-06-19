using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumSetMethod
    {
        //Enter text
        public static void EnterText(IWebDriver driver, string element, string inputText, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).SendKeys(inputText);
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).SendKeys(inputText);
        }

        //Click button, checkbox, options, etc
        public static void Click(IWebDriver driver, string element, string elementType)
        {
            if (elementType == "Id")
                driver.FindElement(By.Id(element)).Click();
            if (elementType == "Name")
                driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(IWebDriver driver, string element, string inputText, string elementType)
        {
            if (elementType == "Id")
                new SelectElement(driver.FindElement(By.Id(element))).SelectByText(inputText);
            if (elementType == "Name")
                new SelectElement(driver.FindElement(By.Name(element))).SelectByText(inputText);
        }
    }
}
