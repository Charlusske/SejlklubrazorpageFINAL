using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class MaintenanceLog
    {
        #region Instance Fields
        private DateTime _timestamp;
        private string _logText;
        private Boat _loggedBoat;
        private Guid _id;
        #endregion

        #region Properties
        public DateTime Timestamp
        {
            get { return _timestamp; }
        }

        public string LogText
        {
            get { return _logText; }
        }

        public Boat LoggedBoat
        {
            get { return _loggedBoat; }
        }
        #endregion


        #region Constructor
        public MaintenanceLog(DateTime timestamp, Guid id)
        {
            _timestamp = timestamp;
            _id = id;
        }
        #endregion


        #region Methods
        public string ReadLog()
        {
            return $"Log ID: {_id}\nTimestamp: {_timestamp}\nBoat: {_loggedBoat.Name} ({_loggedBoat.BoatNumber})\nLog Text: {_logText}";
        }

        public string ReportIssue(string issueDescription, Boat boat)
        {
            _logText = issueDescription;
            _loggedBoat = boat;
            return $"Issue reported for Boat {_loggedBoat.Name} ({_loggedBoat.BoatNumber}) at {_timestamp}:\n{_logText}";
        }
        #endregion
    }
}
