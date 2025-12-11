using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SejlklubLibraryFINAL
{
    public class Event : Post
    {
        #region Properties
        public string Location { get; set; }
        public Guid Id { get; set; }
        #endregion

        #region Methods
        public Event(string title, DateOnly date, TimeOnly time, string description, string location, Guid id)
        {
            Title = title;
            Date = date;
            Time = time;
            Description = description;
            Location = location;
            Id = id;
        }
      
        #endregion
    }
}
