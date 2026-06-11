
// Deep Patel

using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    // Passenger dashboard class that inherits from User
    internal class PassengerDashboard : User
    {
        // Abhay Khosla Edited
        public int PassengerId { get; set; }
        public string PassportNumber { get; set; }

        // Display Options for Passenger Dashboard
        public override void ShowMenu()
        {
            Console.WriteLine("\n--------------- PASSENGER DASHBOARD --------------");
            Console.WriteLine("====================================================\n");
            Console.WriteLine("1. View Flights");
            Console.WriteLine("2. Search Flight");
            Console.WriteLine("3. Book Flight");
            Console.WriteLine("4. View My Bookings");
            Console.WriteLine("5. Cancel Booking");
            Console.WriteLine("6. Logout");
            Console.WriteLine("\n----------------------------------------------------");

        } // End ShowMenu 
    } // End Class PassengerDashboard
} // End Namespace
