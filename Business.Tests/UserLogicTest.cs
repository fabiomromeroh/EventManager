using Business.Implementations;
using Data.Contracts;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System;

namespace Business.Tests
{
    [TestClass]
    public class UserLogicTest
    {

        private IEventRepository eventRepository;
        private EventLogic Target { get; set; }

        [TestInitialize]
        public void OnInit()
        {
            this.eventRepository = Mock.Of<IEventRepository>();

            this.Target = new EventLogic(this.eventRepository);
        }

        [TestMethod]
        public void GetAllEvents_ExecuteOnce()
        {
            //Arrange

            //Act

            //Assert
            Mock.Get(this.eventRepository).Verify(x => x.FilterEvents(It.IsAny<DateTime?>(), It.IsAny<DateTime?>()), Times.Once());
        }


    }
}
