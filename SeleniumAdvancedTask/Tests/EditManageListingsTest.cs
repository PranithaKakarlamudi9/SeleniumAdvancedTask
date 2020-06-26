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
    [TestFixture,Description("tests Edit Manage listings functionality")]
    class EditManageListingsTest:Base
    {
        [Test,Description("Tests Edit ManageListings" )]
        public void TestEditManageListings()
        {          
           ProfilePage profilePage = new ProfilePage();
            profilePage.ClickManageListings();
            ManageListingsPage listings = new ManageListingsPage();
            listings.EditManageListings();
            driver.WaitForElement(By.XPath("//tbody/tr[1]/td[3]"));
            String expextedTitle = "Seleinium with Java";
            String actualTitle = driver.FindElement(By.XPath("//tbody/tr[1]/td[3]")).Text;
            Assert.AreEqual(expextedTitle, actualTitle);

        }

    }
}
