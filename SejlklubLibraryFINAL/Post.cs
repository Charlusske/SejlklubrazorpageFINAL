using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Post
    {
        #region Properties
        public string Title { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
        public string Description { get; set; }
        public Guid Guid { get; set; }
        #endregion

        #region Methods
        public override string ToString()
        {
            return base.ToString();
        }

        public void Publish()
        {

        }
        #endregion
    }
}

