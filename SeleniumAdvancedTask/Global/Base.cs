using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.IO;
using System.Text;
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.IE;
using SeleniumAdvancedTask.Pages;

namespace SeleniumAdvancedTask.Global
{
    class Base
    {
        //Defining driver
        public static IWebDriver driver { get; set; }
        bool registeredUser = true;

        #region access path
        //path to website,reports, test data and screenshots
        public static String BaseUrl = "http://192.168.99.100:5000";
        public static String ReportsPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\Reports\\");
        public static String TestDataPath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory + "..\\..\\TestData\\MarsTestData.xlsx");
       
        
        #endregion

        #region reports
        public ExtentTest test;
        public static ExtentReports extent;
        public static ExtentHtmlReporter htmlReporter;
        #endregion

        //Initialising browser
        public void Intialise(String browser)
        {

            switch (browser)
            {
                case "Chrome":
                    driver = new ChromeDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(BaseUrl);
                    break;
                case "Firefox":
                    driver = new FirefoxDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(BaseUrl);
                    break;
                case "IE":
                    driver = new InternetExplorerDriver();
                    driver.Manage().Window.Maximize();
                    driver.Navigate().GoToUrl(BaseUrl);
                    break;
            }
        }

        
        #region Test setup and teardown
        [OneTimeSetUp]
        public void TestOneTimeSetUP()
        {

            extent = new ExtentReports();
            htmlReporter = new ExtentHtmlReporter(ReportsPath);
            htmlReporter.Config.Theme = AventStack.ExtentReports.Reporter.Configuration.Theme.Dark;
            extent.AttachReporter(htmlReporter);
            Intialise("Chrome");

            //checkuser is registered or not
            if (registeredUser == true)
            {
                LoginPage login = new LoginPage();
                login.LogIn();
            }
            else
            {
                RegistrationPage registration = new RegistrationPage();
                registration.Register();
            }


        }
        [SetUp]
        public void BeforeTest()
        {
            
            test = extent.CreateTest(TestContext.CurrentContext.Test.Name);
        }

        [TearDown]
        public void AfterTest()
        {
            var status = TestContext.CurrentContext.Result.Outcome.Status;
            var stacktTrace = TestContext.CurrentContext.Result.StackTrace;
          

            if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Log(Status.Pass, "Test Passed");
               
                
            }

            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Log(Status.Fail, "Test Passed");
              
            }

            else if (status == NUnit.Framework.Interfaces.TestStatus.Passed)
            {
                test.Log(Status.Skip, "Test Skipped");
               
            }

        }
        

        [OneTimeTearDown]
        public void TearDown()
        {
          
            extent.Flush();
            driver.Close();
        }
        #endregion
    }
}


