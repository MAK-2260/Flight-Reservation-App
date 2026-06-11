

// Asif Khan

using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    // Class representing a Flight entity in the reservation system
    internal class Flight
    {
 // Properties representing flight details including ID, flight number, route, seats, price, date, and time
        public int FlightId { get; set; }
        public string FlightNumber { get;  set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Seats { get; set; }
        public double Price { get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    
    } // End Class Flight
} // End Namespace