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
        #endregion

        #region Constructor
        public Event(string title, DateOnly date, TimeOnly time, string description, string location) : base(title, date, time, description)
        {
            Location = location;
        }
        #endregion

    }
}
