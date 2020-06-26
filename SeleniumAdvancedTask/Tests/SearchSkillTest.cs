using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using SeleniumAdvancedTask.Global;
using SeleniumAdvancedTask.Pages;

namespace SeleniumAdvancedTask.Tests
{
    [TestFixture, Description("tests various functionalities of SearchSkill")]
    class SearchSkillTest : Base
    {


        [Test, Order(1), Description("test search skill by entering category in SearchSkill textbox")]
        public void TestSearchSkillByCategory()
        {
            Common SearchSkill = new Common();
            SearchSkill.SearchSkillByCategory();
            int result = SearchSkill.SearchResult();
            if (result > 0)
            {
                Assert.Pass("SearchSkillByCategory is passed ");
                Assert.NotNull(result);
            }
        }
        [Test, Order(2), Description("test search skill by selecting  category in SearchSkill result page")]
        public void TestSearchSkillBySelectingCategory()
        {
            Common SearchSkill = new Common();
            SearchSkill.SearchSkillBySelectingCategory();
            int result = SearchSkill.SearchResult();
            if (result > 0)
            {
                Assert.Pass("SearchSkillByCategory is passed ");
                Assert.NotNull(result);
            }
        }

        [Test, Order(3), Description("test search skill by entering sub-category in SearchSkill textbox")]
        public void TestSearchSkillBySubCategory()
        {
            Common SearchSkill = new Common();
            SearchSkill.SearchSkillBySubCategory();
            int result = SearchSkill.SearchResult();
            if (result > 0)
            {
                Assert.Pass("SearchSkillByCategory is passed ");
                Assert.NotNull(result);
            }

        }
        [Test, Order(3), Description("test search skill by entering sub-category in SearchSkill textbox")]
        public void TestSearchSkillBySelectingSubCategory()
        {
            Common SearchSkill = new Common();
            SearchSkill.SearchSkillBySelectingSubCategory();
            int result = SearchSkill.SearchResult();
            if (result > 0)
            {
                Assert.Pass("SearchSkillByCategory is passed ");
                Assert.NotNull(result);
            }
        }

        [Test, Order(4), Description("test search skill by entering filter in SearchSkill textbox and selecting filter in Serach result page")]
        public void TestSearchByFilterType()
        {
            Common SearchSkill = new Common();
            SearchSkill.SearchByFilterType();
            int result = SearchSkill.SearchResult();
            if (result > 0)
            {
                Assert.Pass("SearchSkillByCategory is passed ");
                Assert.NotNull(result);
            }
        }
    }
}
