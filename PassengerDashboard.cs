using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    internal class PassengerDashboard : User
    {
        public int PassengerId { get; set; }
        public string PassportNumber { get; set; }

        public override void ShowMenu()
        {
            Console.WriteLine("--------------------PASSENGER DASHBOARD----------------------");
            Console.WriteLine("1. View Flights");
            Console.WriteLine("2. Search Flight");
            Console.WriteLine("3. Book Flight");
            Console.WriteLine("4. View My Bookings");
            Console.WriteLine("5. Cancel Booking");
            Console.WriteLine("6. Logout");

        }
    }
}
