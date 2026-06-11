
// Original implementation by Abhay Kholsa, with modifications by Asif Khan
using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
// Class representing a flight booking, storing all booking details
    internal class Booking
    {
        public int BookingId { get; set; }
        public string PassengerName { get; set; }
        public int FlightId { get; set; }
        public int Seats {  get; set; } 
        public double Price {  get; set; } 
        public string From {  get; set; }
        public string To {  get; set; }
        public string PassportNumber { get; set; }      
        public string FlightNumber {  get; set; }
        public DateOnly Date { get; set; }
        public TimeOnly Time { get; set; }
    
    } // End Class Booking
} // End Namespace
