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
    [TestFixture, Description("Test Add Profile")]
    class AddProfileTest : Base
    {
        
        [Test,Order(1),Description("Test Add availability")]
        public void TestAddAvailability()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.PopulateValues();
            driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[5]/span"));
            String AvailabilityText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[5]/span")).Text;
            if (AvailabilityText == "")
            {
                profileAddObj.AddAvailability();

            }
            String AvailabilityText2 = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[5]/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Availability")), AvailabilityText2);
        }

        [Test, Order(2), Description("Test Add Hours")]
        public void TestAddHours()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.PopulateValues();
            driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span"));
            String HoursText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span")).Text;
            if (HoursText =="")
            {
                profileAddObj.AddHours();

            }
            String HoursText2 = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[6]/div[@class='right floated content']/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Hours")), HoursText2);

        }

        [Test, Order(3), Description("Test Add EarnTarget")]
        public void TestAddEarnTarget()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.PopulateValues();
            Base.driver.WaitForElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span"));
            String EarnTargetText = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span")).Text;
            if (EarnTargetText =="")
            {
                profileAddObj.AddEarnTarget();

            }
            String EarnTargetText2 = Base.driver.FindElement(By.XPath("//div[@class='extra content']/descendant::div[8]/div[@class='right floated content']/span")).Text;
            Assert.AreEqual((ExcelLibrary.ReadData(2, "Earn Target")), EarnTargetText2);
        }

        [Test, Order(4), Description("Test Add Description")]
        public void TestAddDescription()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.AddDescription();
            Thread.Sleep(1000);
            String expextedMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            String actualMessage = "Description has been saved successfully";
            Assert.AreEqual(expextedMessage, actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();


        }

        [Test, Order(5), Description("Test Add Language")]

        public void TestAddLanguage()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.AddLanguage();
            Thread.Sleep(1000);          
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;         
            String actualMessage = "English has been added to your languages";
            Assert.AreEqual(expextedAddMessage,actualMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();

        }

        [Test, Order(6), Description("Test Add Skills")]
        public void TestAddSkills()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.AddSkills();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;            
            String actualAddMessage = "Selenium has been added to your skills";
            Assert.AreEqual(expextedAddMessage,actualAddMessage);
            driver.FindElement(By.XPath("//a[@class='ns-close']")).Click();
        }
        [Test, Order(7), Description("Test Add Education")]
        public void TestAddEducation()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.AddEducation();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;           
            String actualMessage = "Education has been added";
            Assert.AreEqual(expextedAddMessage,actualMessage);
        }

        [Test, Order(8), Description("Test Add Certifications")]
        public void TestAddCertifications()
        {
            ProfilePage profileAddObj = new ProfilePage();
            profileAddObj.AddCertifications();
            Thread.Sleep(1000);
            String expextedAddMessage = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;          
            String actualMessage = "ISTQB has been added to your certification";
            Assert.AreEqual(expextedAddMessage,actualMessage);
        }
  

    }
}
