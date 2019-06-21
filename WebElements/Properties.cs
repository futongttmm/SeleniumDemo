using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumFirst
{
    public enum Element
    {
        Id, Name
    }
    class Properties
    {
        public static IWebDriver Driver { get; set; }
    }
}
