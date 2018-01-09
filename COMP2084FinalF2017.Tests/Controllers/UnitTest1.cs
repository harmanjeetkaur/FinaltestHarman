using System;
using System.Text;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Web.Mvc;
using COMP2084FinalF2017.Controllers;
namespace COMP2084FinalF2017.Tests.Controllers
{
    /// <summary>
    /// Summary description for UnitTest1
    /// </summary>
    [TestClass]
    public class UnitTest1
    {
       public void IndexLoadsValid()
        {
            //arrange
            CountriesController controller = new CountriesController();
            //act
            ViewResult result = Controller.Index() as ViewResult;
            //assert
            Assert.IsNotNull(result);

          
        }
        [TestMethod]
        public void IndexShowsValidCountry()
        {

        }
    }
}
