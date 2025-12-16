using System;
using System.Collections.Generic;
using System.Security.Cryptography;
using System.Text;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SejlklubLibraryFINAL
{
    public class News : Post
    {
        #region Constructor
        public News(string title, DateOnly date, TimeOnly time, string description, Guid guid) : base(title, date, time, description)
        {
        }
        #endregion


    }

}