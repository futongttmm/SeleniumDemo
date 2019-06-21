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
        public static void EnterText(string element, string inputText, Element elementType)
        {
            if (elementType == Element.Id)
                Properties.Driver.FindElement(By.Id(element)).SendKeys(inputText);
            if (elementType == Element.Name)
                Properties.Driver.FindElement(By.Name(element)).SendKeys(inputText);
        }

        //Click button, checkbox, options, etc
        public static void Click(string element, Element elementType)
        {
            if (elementType == Element.Id)
                Properties.Driver.FindElement(By.Id(element)).Click();
            if (elementType == Element.Name)
                Properties.Driver.FindElement(By.Name(element)).Click();
        }

        //Selecting a drop down control
        public static void SelectDropDown(string element, string inputText, Element elementType)
        {
            if (elementType == Element.Id)
                new SelectElement(Properties.Driver.FindElement(By.Id(element))).SelectByText(inputText);
            if (elementType == Element.Name)
                new SelectElement(Properties.Driver.FindElement(By.Name(element))).SelectByText(inputText);
        }
    }
}
