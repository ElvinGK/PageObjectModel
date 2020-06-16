﻿using OpenQA.Selenium;
using PageObjectModel.Utils.Drivers;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PageObjectModel.Utils.Selenium
{
    internal class DriverController
    {
        internal static DriverController Instance = new DriverController();
        internal IWebDriver WebDriver { get; set; }

        internal void StartChrome()
        {
            if (WebDriver != null) return;
            WebDriver = ChromeWebDriver.LoadChromeDriver();
        }

        internal void StopDriver()
        {
            if (WebDriver == null) return;
            try
            {
                WebDriver.Quit();
                WebDriver.Dispose();
            }
            catch(Exception e)
            {
                Debug.WriteLine(e,"WebDriver Stop error");
            }
            WebDriver = null;
            Console.WriteLine("Web driver stopped");
        }
    }
}
