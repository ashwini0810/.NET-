using NUnit.Framework;
using Ocelot.Infrastructure;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;




namespace TestProject3_Team4
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;
        private string baseUrl = "http://localhost:5232/";

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Login()
        {
            driver.Navigate().GoToUrl(baseUrl);

            IWebElement usernameField = driver.FindElement(By.Id("txtusername"));
            IWebElement password = driver.FindElement(By.Id("txtpwd"));
            usernameField.SendKeys("password");
            password.SendKeys("password");
            Thread.Sleep(10000);

            IWebElement loginButton = driver.FindElement(By.XPath("//div[@class=\"card-footer\"]//a[text()=\"Login\"]"));

            loginButton.Click();
            Thread.Sleep(5000);
            //driver.Navigate().GoToUrl("http://localhost:5232/Login/Authentication");

            IWebElement usernameInput = driver.FindElement(By.XPath("//input[@placeholder='Enter the user name']"));
            IWebElement otpInput = driver.FindElement(By.XPath("//input[@placeholder='Enter verification code']"));

            // Replace these values with actual ones
            usernameInput.SendKeys("your_username");
            otpInput.SendKeys("received_otp_code");

            // Click the Verify button
            IWebElement verifyButton = driver.FindElement(By.XPath("//button[text()='VERIFY']"));
            verifyButton.Click();
            System.Threading.Thread.Sleep(50000);
        }
        

        [TearDown]
        public void TearDown()
        {
            driver.Quit();
        }
    }
}
