using System;
using System.Web.Mvc;
using Business.Contracts;
using EventManagerAssesment.Controllers;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EventManagerWeb.Test
{
    [TestClass]
    public class EventControllerTest
    {
        [TestMethod]
        public void Index()
        {
            // Arrange
            var eventLogic = Mock.Of<IEventLogic>();
            EventController controller = new EventController(eventLogic);
            // Act
            ViewResult result = controller.Index() as ViewResult;
            // Assert
            Assert.IsNotNull(result);
        }
    }
}
