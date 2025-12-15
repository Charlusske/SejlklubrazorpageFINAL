using System;
using System.Collections.Generic;
using System.Text;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SejlklubLibraryFINAL
{
    public class News : Post
    {
        #region Constructor
        public News(string title, DateOnly date, TimeOnly time, string description) : base(title, date, time, description)
        {
        }
        #endregion
    }

}