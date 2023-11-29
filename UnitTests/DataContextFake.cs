using MyFirstApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    public class DataContextFake:IDataContext
    {
        public List<Event> EventList { get; set; }

        public DataContextFake()
        {
            EventList = new List<Event>();

            EventList.Add(new Event {  Title = "first sample event", Start = new DateTime(2023, 11, 04) });
            EventList.Add(new Event { Title = "second sample event", Start = new DateTime(2023, 11, 10) });

        }


    }
}
