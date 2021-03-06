﻿using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace FrameworkCore
{
    public class ChromeSession : IDriverSession
    {
        IWebDriver IDriverSession.GetDriver()
        {
            return new ChromeDriver(GetChromeOptions());
        }

        private ChromeOptions GetChromeOptions()
        {
            ChromeOptions options = new ChromeOptions();
            //Debugging statements for handling headless testing
            //options.AddArgument("--headless");
            //options.AddArgument("--window-size=1280,1024");
            return options;
        }
    }
}
