using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MVCRockers;
using MVCRockers.Controllers;
using MVCRockers.Models;

namespace MVCRockers.Tests.Controllers
{
    [TestClass]
    public class HomeControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Index() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void About()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.About() as ViewResult;

            // Assert
            Assert.AreEqual("Your application description page.", result.ViewBag.Message);
        }

        [TestMethod]
        public void Contact()
        {
            // Arrange
            HomeController controller = new HomeController();

            // Act
            ViewResult result = controller.Contact() as ViewResult;

            // Assert
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void FooActionReturnsAboutView()
        {
            HomeController controller = new HomeController();
            var result = controller.Foo() as ViewResult;
            Assert.AreEqual("About", result.ViewName);
        }

        [TestMethod]
        public void ContactFormSaysThanks()
        {
            HomeController controller = new HomeController();
            var result = controller.Contact("Great stuff!") as ViewResult;
            //Assert.AreEqual("Thanks!", result.ViewBag.Message);
            //Assert.IsNotNull(result.ViewBag.Message);
        }

        [TestMethod]
        public void ConcertIsAdded()
        {
            //var fakeDB = FakeTestDbContext();
            //fakeDB.Concerts = new FakeDbSet<Concert>();

            //etc...
        }
        
    }
}
