using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    internal class AdminDashboard : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("----------------- ADMIN DASHBOARD ----------------");
            Console.WriteLine("--------------------------------------------------------");
            Console.WriteLine("1. Add Flight");
            Console.WriteLine("2. View All Flights");
            Console.WriteLine("3. Search Flight");
            Console.WriteLine("4. Manage Flight");
            Console.WriteLine("5. Remove Flight");
            Console.WriteLine("6. View All Bookings");
            Console.WriteLine("7. Logout");
            Console.WriteLine("----------------------------------------------------");

        }
    }
}
