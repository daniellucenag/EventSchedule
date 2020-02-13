using EventSchedule.Application.Event;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace EventSchedule.Test.Application.Event
{
    [TestClass]
    public class EventAppServiceTest
    {
        [TestMethod]
        public void ShouldReturnListOfEvents()
        {
            Mock<IEventAppService> mockEventAppService = new Mock<IEventAppService>();

            EventBuilder builder = new EventBuilder().GetValidInstance();

            mockEventAppService.Setup(o => o.GetAll()).Returns(builder.AllEvents);

            var result = mockEventAppService.Object.GetAll();
           
            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldNotReturnListOfEvents()
        {
            Mock<IEventAppService> mockEventAppService = new Mock<IEventAppService>();

            EventBuilder builder = new EventBuilder().GetValidInstance();

            mockEventAppService.Setup(o => o.GetAll()).Returns(builder.EmptyList);

            var result = mockEventAppService.Object.GetAll();

            Assert.IsNull(result);
        }

        [TestMethod]
        public void ShouldReturnEventById()
        {
            Mock<IEventAppService> mockEventAppService = new Mock<IEventAppService>();

            EventBuilder builder = new EventBuilder().GetValidInstance();

            mockEventAppService.Setup(o => o.GetById(builder.SingleEvent.EventId)).Returns(builder.SingleEvent);

            var result = mockEventAppService.Object.GetById(builder.SingleEvent.EventId);

            Assert.IsNotNull(result);
        }

        [TestMethod]
        public void ShouldNotReturnEventById()
        {
            Mock<IEventAppService> mockEventAppService = new Mock<IEventAppService>();

            EventBuilder builder = new EventBuilder().GetValidInstance();

            mockEventAppService.Setup(o => o.GetById(builder.SingleEvent.EventId)).Returns(builder.EmptyEvent);

            var result = mockEventAppService.Object.GetById(builder.SingleEvent.EventId);

            Assert.IsNull(result);
        }
    }
}