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
<<<<<<< HEAD
        public void DeleteById_NotFound()
=======
        public void DeleteById_ReturnNotFound()
>>>>>>> 3369f7f411d2a87169f3caef766e6a14ea7d8b69
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
