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
    [TestFixture,Description("tests delete managelistings functionality ")]
    class DeleteManageListingsTest:Base
    {
        [Test,Description("Tests Delete Manage Listings")]
        public void TestDeleteManageListings()
        {
            ProfilePage profileObj = new ProfilePage();
            profileObj.ClickManageListings();
            ManageListingsPage listings = new ManageListingsPage();
            listings.DeleteManageListing();
            Thread.Sleep(1000);
            String ExpectedDeleteConfirmation = driver.FindElement(By.XPath("//div[@class='ns-box ns-growl ns-effect-jelly ns-type-success ns-show']/div")).Text;
            Assert.IsTrue(ExpectedDeleteConfirmation.Contains(" has been deleted"));

            
        }
    }
}
