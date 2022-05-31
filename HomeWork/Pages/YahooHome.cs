using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;

namespace HomeWork.Pages
{
    public class YahooHome : BasePage
    {
        const string SignInButtonLocator = "_yb_oqe7g";

        public IWebElement SignInButton { get; set; }


        public YahooHome(IWebDriver driver) : base(driver) { }
        
        public void GoToStartPage()
        {
            SignInButton = FindElement(By.ClassName(SignInButtonLocator));

            SignInButton.Click();

        }

        public bool SignInButtonDisplayed()
        {
            var signInButton = FindElement(By.ClassName(SignInButtonLocator));
            return signInButton != null;
        }
    }
}
