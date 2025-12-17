using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Post
    {
        #region Properties
        public string Title { get; set; }
        public DateTime DateTime { get; set; }
        public string Description { get; set; }
        public Guid Id { get; set; }
        public bool IsPublished { get; private set; }
        public DateTime? PublishedAt { get; private set; }
        #endregion

        #region Constructor
        public Post(string title, DateTime dateTime, string description)
        {
            Title = title;
            DateTime = dateTime;
            Description = description;
            Id = Guid.NewGuid();
            IsPublished = false;
        }
        #endregion


        #region Methods
        public bool Publish()
        {
            if (IsPublished)
            {
                return false;
            }

            IsPublished = true; 
            PublishedAt = DateTime.Now;
            return true;
        }

        public void UpdateDescription(string newDescription)
        {
            Description = newDescription;
        }


        public override string ToString()
        {
            return $"Title: {Title}\nDescription: {Description}\nDate and Time: {DateTime}\nId: {Id}";
        }
        #endregion
    }
}

