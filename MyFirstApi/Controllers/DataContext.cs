using MyFirstApi;

namespace MyFirstApi.Controllers
{
    public class DataContext
    {

        public List<Event> EventsList { get; set; }

         public DataContext() {
            EventsList = new List<Event>() ;
            EventsList.Add(new Event() { Title="sample event",Start=new DateTime(2020,5,2)});

        }
    }
}
