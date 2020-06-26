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
    [TestFixture,Description("test Add ShareSkill functionality")]
    class AddShareSkillTest:Base
    {
        [Test]
        public void TestAddShareSkill()
        {
            
            ProfilePage profilePage = new ProfilePage();
            profilePage.ClickShareSkill();
            ShareSkillPage skillPage = new ShareSkillPage();
            skillPage.ReadExcelAddShareSkill();
            skillPage.AddShareSkill();
            driver.WaitForElement(By.XPath("//tbody/tr[1]/td[3]"));
            String expextedTitle = "Seleinium with Csharp";
            String actualTitle = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(expextedTitle, actualTitle);
            
        }
    }
}
