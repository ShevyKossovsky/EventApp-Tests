namespace MyFirstApi
{
    public class Event
    {
        static int count = 0;
        public int Id { get; }
        public string Title { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }

        public Event()
        {
            count++;
            Id = count;
        }
        public Event(string title, DateTime start, DateTime end)
        {

            Title = title;
            Start = start;
            End = end;
        }


    }
}
