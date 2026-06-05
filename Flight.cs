using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    internal class Flight
    {
        public int FlightId { get; set; }
        public string From { get; set; }
        public string To { get; set; }
        public int Seats { get; set; }
        public double Price { get; set; }
    }
}
