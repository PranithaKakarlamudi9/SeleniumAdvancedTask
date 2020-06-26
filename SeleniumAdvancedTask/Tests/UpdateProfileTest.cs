using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using NUnit.Framework;
using OpenQA.Selenium;
using SeleniumAdvancedTask.Global;
using SeleniumAdvancedTask.Pages;

namespace SeleniumAdvancedTask.Tests
{
    [TestFixture,Description("Test Update functionality in profile page")]
    class UpdateProfileTest:Base
    {
       

        [Test, Order(1), Description("Test Update availability")]
        public void TestUpdateAvailability()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.PopulateValues();          
            UpdateProfile.UpdateAvailability();
            Thread.Sleep(1000);
            String expextedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Availability updated";
            Assert.AreEqual(expextedMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();


        }

        [Test, Order(2), Description("Test Update Hours")]
        public void TestUpdateHours()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.PopulateValues();       
            UpdateProfile.UpdateHours();
            Thread.Sleep(1000);
            String expextedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = " Availability updated";
            Assert.AreEqual(expextedMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [Test, Order(3), Description("Test Update EarnTarget")]
        public void TestUpdateEarnTarget()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.PopulateValues();
            UpdateProfile.UpdateEarnTarget();
            Thread.Sleep(1000);
            String expextedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Availability updated";
            Assert.AreEqual(expextedMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }

        [Test, Order(4), Description("Test Add Description")]
        public void TestUpdateDescription()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.UpdateDescription();
            Thread.Sleep(1000);
            String expextedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Description has been saved successfully";
            Assert.AreEqual(expextedMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();

        }

        [Test, Order(5), Description("Test Update Language")]

        public void TestUpdateLanguage()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.UpdateLanguage();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Hindi has been updated to your languages";
            Assert.AreEqual(expextedAddMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();

        }

        [Test, Order(6), Description("Test Update Skills")]
        public void TestUpdateSkills()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.UpdateSkills();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualAddMessage = "Java has been updated to your skills";
            Assert.AreEqual(expextedAddMessage, actualAddMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();

        }
        [Test, Order(7), Description("Test Update Education")]
        public void TestUpdateEducation()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.UpdateEducation();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Education as been updated";
            Assert.AreEqual(expextedAddMessage, actualMessage);
        }

        [Test, Order(8), Description("Test Update Certifications")]
        public void TestUpdateCertifications()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            UpdateProfile.UpdateCeritfications();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Foundation level has been updated to your certification";
            Assert.AreEqual(expextedAddMessage, actualMessage);
        }
        [Test, Order(9), Description("Test Change Password")]
        public void TestChangePassword()
        {
            ProfilePage UpdateProfile = new ProfilePage();
            Common CommonObj = new Common();
            CommonObj.ChangePassword();
            Thread.Sleep(1000);
            String expextedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;        
            String actualMessage = "Password Changed Successfully";
            Assert.AreEqual(expextedMessage, actualMessage);
        }

    }
}

   
