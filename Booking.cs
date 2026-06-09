using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
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
    }
}
