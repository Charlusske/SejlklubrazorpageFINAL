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
        public Event(string title, DateTime dateTime, string description, string location, Guid id)
        {
            Title = title;
            DateTime = dateTime;
            Description = description;
            Location = location;
            Id = id;
        }
        #endregion
    }
}
