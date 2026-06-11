
// Deep Patel

using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    // Admin dashboard class that inherits from User
    internal class AdminDashboard : User
    {
        // Display Options for Admin Dashboard
        public override void ShowMenu()
        {
            Console.WriteLine("\n----------------- ADMIN DASHBOARD ----------------");
            Console.WriteLine("====================================================\n");
            Console.WriteLine("1. Add Flight");
            Console.WriteLine("2. View All Flights");
            Console.WriteLine("3. Search Flight");
            Console.WriteLine("4. Manage Flight");
            Console.WriteLine("5. Remove Flight");
            Console.WriteLine("6. View All Bookings");
            Console.WriteLine("7. Logout");
            Console.WriteLine("\n----------------------------------------------------");

        } // End ShowMenu 
    } // End Class AdminDashboard
} // End Namespace
