using System;
using System.Collections.Generic;
using System.Text;

namespace SejlklubLibraryFINAL
{
    public class Booking
    {
        #region Properties
        public string Date { get; set; }
        public string Time { get; set; }
        public string Destination { get; set; }
        public double Price { get; set; }
        public bool Booked { get; set; }
        #endregion

        #region Constructor
        public Booking(string date, string time, string destination, double price, bool booked)
        {
            Date = date;
            Time = time;
            Destination = destination;
            Price = price;
            Booked = booked;
        }
        #endregion

        #region Methods
        public Booking RentBoat()
        {
            Booked = true;
            return this;
        }

        public override string ToString()
        {
            return $"Date: {Date}, Time: {Time}, Destination: {Destination}, Price: {Price}, Booked: {Booked}";
        }

        public double CalculatePrice()
        {
            return Price;
        }

        public Booking EndOfBooking()
        {
            Booked = false;
            return this;
        }


        public void UpdateDestination(string newDest) { Destination = newDest; }
        #endregion

    }
}
