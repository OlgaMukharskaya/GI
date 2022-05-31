using System;
using System.Collections.Generic;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using HomeWork.Pages;
using System.Threading;

namespace ConsoleApp5
{
    public class Program
    {
        static void Main(string[] args)
        {

            WebDriver driver = new ChromeDriver();

            driver.Url = "https://yahoo.com";
            //driver.Url = "https://mail.yahoo.com/?pspid=2023538075&activity=ybar-mail";
            driver.Manage().Window.Maximize();

            YahooHome yahooHome = new YahooHome(driver);

            YahooStart yahooStart = new YahooStart(driver);

            Thread.Sleep(3000); // Waiter

            YahooLoginUsername yahooLoginUsername = new YahooLoginUsername(driver);
            yahooLoginUsername.GoToPasswordPage("volhamautomation@yahoo.com");

            YahooLoginPassword yahooLoginPassword = new YahooLoginPassword(driver);
            yahooLoginPassword.GoToMailBoxPage("Aa2753331!");

            YahooMailBox yahooMail = new YahooMailBox(driver);

            YahooWriteLetter yahooWriteLetter = new YahooWriteLetter(driver);
            string currentTime = DateTime.Now.TimeOfDay.ToString();
            yahooWriteLetter.WriteLetter("olgamautomation@yahoo.com", currentTime, "Aturomation Test from VolhaM");

            LogOut logOut = new LogOut(driver);

            YahooHome yahooHome2 = new YahooHome(driver);

            ExitAccount exitAccount = new ExitAccount(driver);

            YahooLoginUsername yahooLoginUsername2 = new YahooLoginUsername(driver);
            yahooLoginUsername2.GoToPasswordPage("olgamautomation@yahoo.com");

            YahooLoginPassword yahooLoginPassword2 = new YahooLoginPassword(driver);
            yahooLoginPassword2.GoToMailBoxPage("Aa2753331!");

            IWebElement newLetter3 = driver.FindElement(By.XPath(string.Format("//span[(@title='{0}')]", currentTime)));
            newLetter3.Click();

            ReplyLetter replyLetter = new ReplyLetter(driver);
            replyLetter.Answer("My answer");

            LogOut logOut3 = new LogOut(driver);

            YahooHome yahooHome3 = new YahooHome(driver);

            ExitAccount exitAccount3 = new ExitAccount(driver);

            YahooLoginUsername yahooLoginUsername3 = new YahooLoginUsername(driver);
            yahooLoginUsername2.GoToPasswordPage("volhamautomation@yahoo.com");

            YahooLoginPassword yahooLoginPassword3 = new YahooLoginPassword(driver);
            yahooLoginPassword2.GoToMailBoxPage("Aa2753331!");


            IWebElement newLetter4 = driver.FindElement(By.XPath(string.Format("//span[(@title='{0}')]", currentTime)));
            newLetter3.Click();



            driver.Close();

        }
    }
}
