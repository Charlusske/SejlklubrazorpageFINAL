using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class EventRepository
    {
        #region InstanceField
        private List<Event> _events = new List<Event>();
        #endregion

        #region Methods
        public EventRepository()
        {
            _events = new List<Event>();
        }

        public void AddEvent(Event event1)
        {
            _events.Add(event1);
        }

        public void RemoveEvent(Event event1)
        {
            _events.Remove(event1);
        }

        public Event GetEventById(Guid id)
        {
            return _events.Find(event1 => event1.Id == id);
        }

        public List<Event> GetAllEvents()
        {
            return _events;
        }
        #endregion
    }
}
