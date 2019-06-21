using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    class SeleniumGetMethod
    {
        public static string GetText(string element, Element elementType)
        {
            if (elementType == Element.Id)
                //return driver.FindElement(By.Id(element)).Text;  //Text property returns only inner text
                return Properties.Driver.FindElement(By.Id(element)).GetAttribute("value");  //value is an attribute in DOM, and we can using this value to actually get the value which we typed in the textbox in the initial
                //Only if you have a control with Inner Text, you can use Text property to get text
            if (elementType == Element.Name)
                return Properties.Driver.FindElement(By.Name(element)).GetAttribute("value");
            else
                return String.Empty;
        }
        
        public static string GetTextFromDropDownList(string element, Element elementType)
        {
            if (elementType == Element.Id)
                return new SelectElement(Properties.Driver.FindElement(By.Id(element))).AllSelectedOptions.SingleOrDefault().Text;
            if (elementType == Element.Name)
                return new SelectElement(Properties.Driver.FindElement(By.Name(element))).AllSelectedOptions.SingleOrDefault().Text;
            else
                return String.Empty;
        }
    }
}
