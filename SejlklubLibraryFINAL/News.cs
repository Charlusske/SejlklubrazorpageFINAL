using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SejlklubLibraryFINAL
{
    public class News : Post
    {
        #region Properties
        #endregion

        #region Methods
        public News(string title, DateOnly date, TimeOnly time, string description, Guid id)
        {
            Title = title;
            Date = date;
            Time = time;
            Description = description;

        }
        #endregion
    }
}
