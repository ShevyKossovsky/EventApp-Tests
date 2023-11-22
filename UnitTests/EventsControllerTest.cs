using Microsoft.AspNetCore.Mvc;
using MyFirstApi;
using MyFirstApi.Controllers;

namespace UnitTests
{
    public class EventsControllerTest
    {

        [Fact]
        public void GetById_ReturnOk()
        {
            //Arange

            int id = 1;

            //Act
            var controller = new EventController();
            var res = controller.Get(id);

            //Assert
            Assert.IsType<OkObjectResult>(res);
        }
        [Fact]
        public void DeleteById_ReturnOk()
        {
            //Arange
            int id = 8;
            //Act
            var controller = new EventController();
            var res = controller.Delete(id);
            //Assert
            Assert.IsType<NotFoundResult>(res);
        }

    }
}