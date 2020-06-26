using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using AventStack.ExtentReports.Model;
using NUnit.Framework;
using OpenQA.Selenium;
using RazorEngine.Compilation.ImpromptuInterface.Dynamic;
using SeleniumAdvancedTask.Global;
using SeleniumAdvancedTask.Pages;

namespace SeleniumAdvancedTask.Tests
{
    [TestFixture,Description("test delete functionality of profile page")]
    class DeleteProfileTest:Base
    {
       
       
       [NUnit.Framework.Test,Order(1),Description("Test Delete language")]

        public void TestDeleteLanguage()
        {
            ProfilePage DeleteProfile = new ProfilePage();
            DeleteProfile.DeleteLanguage();
            Thread.Sleep(1000);
            String expectedDeleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Assert.IsTrue(expectedDeleteMessage.Contains(" has been deleted"));

        }

        [NUnit.Framework.Test, Order(2), Description("Test Delete Skills")]
        public void TestDeleteSkills()
        {
            ProfilePage DeleteProfile = new ProfilePage();
            DeleteProfile.DeleteSkills();
            Thread.Sleep(1000);
            String expectedDeletedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Assert.IsTrue(expectedDeletedMessage.Contains(" has been deleted"));

        }
        [NUnit.Framework.Test, Order(3), Description("Test Delete Education")]
        public void TestDeleteEducation()
        {
            ProfilePage DeleteProfile = new ProfilePage();
            DeleteProfile.DeleteEducation();
            Thread.Sleep(1000);
            String expectedDeleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Education entry successfully removed";
            
            Assert.AreEqual(expectedDeleteMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [NUnit.Framework.Test, Order(1), Description("Test Delete certifications")]
        public void TestDeleteCertifications()
        {
            ProfilePage DeleteProfile = new ProfilePage();
            DeleteProfile.DeleteCertifications();
            Thread.Sleep(1000);
            String expectedDeleteMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Foundation level has been deleted from your certification";
            Assert.AreEqual(expectedDeleteMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

    }
}
