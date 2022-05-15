using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Edge;
using System.Threading;

namespace HomeWork.Pages
{
    public class LogOut : BasePage
    {

        const string ProfileImageLocator = "//img[@class='_yb_ufven']";
        const string SignOutLinkLocator = "//a[@class='_yb_1gciy _yb_1nhpp _yb_y12qr _yb_1399w _yb_m7v3m']";

        public IWebElement ProfileImage { get; private set; }
        public IWebElement SignOutLink { get; private set; }


        public LogOut(IWebDriver driver) : base(driver)
        {
            ProfileImage = FindElement(By.XPath(ProfileImageLocator));
            ProfileImage.Click();

            SignOutLink = FindElement(By.XPath(SignOutLinkLocator));
            //SignOutLink.Click();
        }

    }
}
