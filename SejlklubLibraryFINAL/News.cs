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
        public News(string title, DateTime dateTime, string description, Guid id)
        {
            Title = title;
            DateTime = dateTime;
            Description = description;

        }
        #endregion
    }
}
