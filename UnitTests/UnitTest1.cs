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
        public void SignInButtonOnHomePag()
        {
            Assert.IsNotNull(driver.FindElement(By.XPath("//a[@class='_yb_oqe7g']")).Displayed);
        }

        [TestMethod]
        public void ClickingSignInButtonOnHomePagNavigatestoMailStartPage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            Assert.IsTrue(driver.Url.Contains("https://mail.yahoo.com/?pspid"));
        }

        [TestMethod]
        public void EnterButtonIsDisplayedOnMailStartPage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            Assert.IsNotNull(driver.FindElement(By.XPath("/html/body/div[1]/a")).Displayed);
        }

        [TestMethod]
        public void ClickingEnterButtonOnMailStartPageNavigatesToLoginUsernamePage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            YahooStart yahooStart = new YahooStart(driver);
            Thread.Sleep(3000);
            Assert.IsTrue(driver.Url.Contains("https://login.yahoo.com/"));
        }

        [TestMethod]
        public void EnteringCorrectUsernameAndClickingNextButtonOnLoginUsernamePageNavigatesToLoginPasswordPage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            YahooStart yahooStart = new YahooStart(driver);
            YahooLoginUsername yahooLoginUsername = new YahooLoginUsername(driver);
            yahooLoginUsername.EnterUsername("volhamautomation@yahoo.com");

            Thread.Sleep(3000);
            Assert.IsTrue(driver.Url.Contains("https://login.yahoo.com/account/challenge/password"));
        }

        [TestMethod]
        public void EnteringWUsernameAndClickingNextButtonOnLoginUsernamePageNavigatesToLoginPasswordPage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            YahooStart yahooStart = new YahooStart(driver);
            YahooLoginUsername yahooLoginUsername = new YahooLoginUsername(driver);
            yahooLoginUsername.EnterUsername("volhamautomation@yahoo.com");

            Thread.Sleep(3000);
            Assert.IsNotNull(driver.FindElement(By.XPath("//div[@id='password-challenge']")).Displayed);
        }

        [TestMethod]
        public void EnteringWrongUsernameAndClickingNextButtonOnLoginUsernamePageThorwsAnError()
        {
            YahooHome yahooHome = new YahooHome(driver);
            YahooStart yahooStart = new YahooStart(driver);
            YahooLoginUsername yahooLoginUsername = new YahooLoginUsername(driver);
            yahooLoginUsername.EnterUsername("wrongusername999");

            Thread.Sleep(3000);
            Assert.IsNotNull(driver.FindElement(By.XPath("//p[@id='username-error']")).Displayed);
        }

        [TestMethod]
        public void EnteringCorrectPasswordAndClickingNextButtonOnLoginPasswordPageNavigatesToMailPage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            YahooStart yahooStart = new YahooStart(driver);
            YahooLoginUsername yahooLoginUsername = new YahooLoginUsername(driver);
            yahooLoginUsername.EnterUsername("volhamautomation@yahoo.com");
            YahooLoginPassword yahooLoginPassword = new YahooLoginPassword(driver);
            yahooLoginPassword.EnterPassword("Aa2753331!");
            Thread.Sleep(3000);
            Assert.IsTrue(driver.Url.Contains("mail.yahoo.com/d/folders"));
        }



        [TestMethod]
        public void ClickingWriteButtonOpensNewLetterCreatePage()
        {
            YahooHome yahooHome = new YahooHome(driver);
            YahooStart yahooStart = new YahooStart(driver);
            YahooLoginUsername yahooLoginUsername = new YahooLoginUsername(driver);
            yahooLoginUsername.EnterUsername("volhamautomation@yahoo.com");
            YahooLoginPassword yahooLoginPassword = new YahooLoginPassword(driver);
            yahooLoginPassword.EnterPassword("Aa2753331!");
            Thread.Sleep(3000);
            YahooMail yahooMail = new YahooMail(driver);
            Assert.IsTrue(driver.Url.Contains("https://mail.yahoo.com/d/compose/"));
        }


        [TestCleanup]
        public void CleanUp()
        {
            driver.Close();
        }

    }
}
