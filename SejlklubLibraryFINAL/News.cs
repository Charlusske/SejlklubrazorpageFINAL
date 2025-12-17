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
        #region Properties
        #endregion

        #region Methods
        public News(string title, DateTime dateTime, string description) : base(title, dateTime, description)
        {
            Id = Guid.NewGuid();
        }
        #endregion


    }

}