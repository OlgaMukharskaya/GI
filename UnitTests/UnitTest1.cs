using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using HomeWork.Pages;
using System.Threading;


namespace UnitTests
{
    [TestClass]
    public class UnitTest1
    {
        WebDriver driver = null;

        [TestInitialize]

        public void Initialize()
        {
            driver = new ChromeDriver();
            driver.Url = "https://yahoo.com";
            driver.Manage().Window.Maximize();

        }

        [TestMethod]
        public void YahooMailTest()
        {
            YahooHome homePage = new YahooHome(driver);
            Assert.IsTrue(homePage.SignInButtonDisplayed());
            homePage.GoToStartPage();

            YahooLoginUsername loginUsername = new YahooLoginUsername(driver);
            Assert.IsTrue(loginUsername.CkeckUsernamePageAppears());
            Assert.IsTrue(loginUsername.GetWrongNameError());
            loginUsername.GotoPasswordOlgaM();

            YahooLoginPassword loginPassword = new YahooLoginPassword(driver);
            Assert.IsTrue(loginPassword.CkeckPasswordPageAppears());
            Assert.IsTrue(loginPassword.GetWrongPasswordError());
            loginPassword.GoToMailBoxOlgaM();

            YahooMailBox mailBox = new YahooMailBox(driver);
            mailBox.GoToWriteLetterPage();

            YahooWriteLetter writeLetter = new YahooWriteLetter(driver);
            Assert.IsTrue(writeLetter.WriteletterPageAppears());
            writeLetter.WriteLetterFromVolhaToOlga();
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }

    }
}
