using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace HomeWork.Pages
{
    public class YahooMailBox : BasePage
    {
        const string WriteButtonLocator = "//*[@id='app']/div[2]/div/div[1]/nav/div/div[1]/a";

        public IWebElement WriteButton { get; private set; }

        public YahooMailBox(IWebDriver driver) : base(driver) { }

        public void GoToWriteLetterPage()
        {
            WriteButton = FindElement(By.XPath(WriteButtonLocator));

            WriteButton.Click();
        }

    }
}
