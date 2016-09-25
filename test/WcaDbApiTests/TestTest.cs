using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;
using WcaDbApi.ApiServices;
using WcaDbApi.Models;
using Microsoft.EntityFrameworkCore;
using Moq;

namespace WcaDbApiTests
{
    public class TestTest
    {
        [Fact]
        public void Test1()
        {
            var data = new List<Continents>
            {
                new Continents { Id="1", Latitude = 2323, Longitude = 3232, Name = "test1", RecordName = "rec1", Zoom = 1},
                new Continents { Id="2", Latitude = 2323, Longitude = 3232, Name = "test2", RecordName = "rec2", Zoom = 2},
                new Continents { Id="3", Latitude = 2323, Longitude = 3232, Name = "test3", RecordName = "rec3", Zoom = 3},
            }.AsQueryable();

            var mockSet = new Mock<DbSet<Continents>>();
            mockSet.As<IQueryable<Continents>>().Setup(m => m.Provider).Returns(data.Provider);
            mockSet.As<IQueryable<Continents>>().Setup(m => m.Expression).Returns(data.Expression);
            mockSet.As<IQueryable<Continents>>().Setup(m => m.ElementType).Returns(data.ElementType);
            mockSet.As<IQueryable<Continents>>().Setup(m => m.GetEnumerator()).Returns(data.GetEnumerator());

            var mockContext = new Mock<WCADBContext>();
            mockContext.Setup(m => m.Continents).Returns(mockSet.Object);

            var service = new MiscService(mockContext.Object);
            var test = service.GetContinents();

            Assert.Equal(3, test.Count());
        }
    }
}
