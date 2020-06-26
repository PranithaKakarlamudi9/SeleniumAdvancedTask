using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvancedTask.Global;
using SeleniumAdvancedTask.Pages;

namespace SeleniumAdvancedTask.Tests
{
    [TestFixture,Description("Test Registration")]
   
    class RegistrationTest:Base
    {
        [Test, Description("Test registraion method")]
        public void TestRegistration()
        {
            RegistrationPage registeration = new RegistrationPage();
            registeration.Register();
            String expectedConfirmationMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualConfirmationMessage = "Registration Successful";
            Assert.AreEqual(expectedConfirmationMessage,actualConfirmationMessage);
        }
    }
}
