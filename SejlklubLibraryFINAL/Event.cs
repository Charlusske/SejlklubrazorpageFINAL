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
        public List<Member> Participants { get; set; }
        #endregion

        #region Constructor
        public Event(string title, DateOnly date, TimeOnly time, string description, string location, Guid guid)
           : base(title, date, time, description)
        {
            Location = location;
            Participants = new List<Member>();
        }
        #endregion

        #region Methods
        public bool AddMember(Member member)
        {
            if (Participants.Contains(member))
            {
                return false;
            }

            Participants.Add(member);
            return true;
        }

        public void UpdateLocation(string newLocation)
        {
            Location = newLocation;
        }
        #endregion

    }
}
