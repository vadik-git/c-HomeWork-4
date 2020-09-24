using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventHomeWork
{
    class EventService
    {
        List<Event> listEvent = new List<Event>();


       public  void addEvent(Event a)
        {
            listEvent.Add(a);
        }
        public void deleteEvent(Event a)
        {
            listEvent.Remove(a);
        }

       public  void printList()
        {
            foreach(var i in listEvent)
            {
                Console.WriteLine(i);
            }
        }

        public void deleteEventService()
        {
            listEvent.Clear();

        }

        public void findData(DateTime date)
        {
            int index = listEvent.FindIndex(b => b.dateEvent == date);
            if (index != -1)
            {
                Console.WriteLine("Event find");
                Console.WriteLine(listEvent[index]);
            }
            else
            {
                Console.WriteLine($"event {date:d} not find");
            }
        }
        public void EventClient(Client a)
        {
            foreach(var i in listEvent)
            {
                if (i.client == a)
                {
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine($" client {a} not ");
                }
            }
        }

        public void FindFromTo(DateTime from, DateTime to)
        {
            List<Event> findEvent = listEvent.FindAll(a => a.dateEvent >= from && a.dateEvent <= to);
            foreach (var ev in findEvent)
            {
                Console.WriteLine(ev);
            }
        }

    }
}
