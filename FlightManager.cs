
// Asif Khan

using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace FlightReservation
{
    internal class FlightManager
    {
        // List to store all available flights in the system
        public List<Flight> flights = new List<Flight>();

        // List to store all booking records made by passengers
        public List<Booking> bookings = new List<Booking>();
        
        // Flight is fixed and generate automatically 
        public int FlightIDCounter = 101;

        // Add Flights
        public void AddFlight()
        {
            // Collect flight details from users and convert data types safely
            try
            {
                /*Console.Write("Flight ID: ");
                int id = Convert.ToInt32(Console.ReadLine());*/

                Console.Write("Flight No.: ");
                string flightNo = Console.ReadLine();

                Console.Write("From: ");
                string from = Console.ReadLine();

                Console.Write("To: ");
                string to = Console.ReadLine();

                Console.Write("Seats: ");
                int seats = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                Console.Write("Date: ");
                DateOnly date = DateOnly.Parse(Console.ReadLine());

                Console.Write("Time: ");
                TimeOnly time = TimeOnly.Parse(Console.ReadLine());

                flights.Add(new Flight
                {
                    FlightId = FlightIDCounter++,
                    FlightNumber = flightNo,
                    From = from,
                    To = to,
                    Seats = seats,
                    Price = price,
                    Date = date,
                    Time = time
                });

                Console.WriteLine("Flight added successfully!");
            }
            // Handle invalid input errors and display this message
            catch
            {
                Console.WriteLine("Invalid input! Please enter correct values.");
            }
        } //End Add Flight Method

        // Admin View All Flights
        public void ViewAllFlights()
        {
            foreach (Flight flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.FlightId} | Flight No.: {flight.FlightNumber} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats} |  Date: {flight.Date} | Time: {flight.Time}\n");
            }

        } // End View All Flight Method

        // Search Flight
        public void SearchFlight()
        {
            Console.Write("Enter Flight ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var flight = flights.FirstOrDefault(f => f.FlightId == id);

            if (flight != null)
            {
                Console.WriteLine($"Flight ID: {flight.FlightId} | Flight No.: {flight.FlightNumber} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats} | Date: {flight.Date} | Time: {flight.Time}");
            }
            else
            {
                Console.WriteLine("Flight not found!");
            }
        } // End Search Flight Method

        // Manage Flight (Update) 
        public void ManageFlight()
        {
            Console.Write("Enter Flight ID to Update: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var flight = flights.FirstOrDefault(f => f.FlightId == id);

            if (flight != null)
            {
                Console.Write("New Price: ");
                flight.Price = Convert.ToDouble(Console.ReadLine());

                Console.Write("New Seats: ");
                flight.Seats = Convert.ToInt32(Console.ReadLine());

                Console.WriteLine("Flight updated successfully!");
            }
            else
            {
                Console.WriteLine("Flight not found!");
            }
        } // End Update Flights Method

        // Remove Flight
        public void RemoveFlight()
        {
            Console.WriteLine("\nRemove an Existing Flight");
            Console.WriteLine("-----------------------------");

            Console.Write("Enter Flight ID to Remove: ");
            int flightIdRemove = Convert.ToInt32(Console.ReadLine());

            Flight flightRemove = flights.Find(f => f.FlightId == flightIdRemove);

            if (flightRemove != null)
            {
                Console.WriteLine($"Flight ID {flightIdRemove} found in the list");

                flights.Remove(flightRemove);

                Console.WriteLine("Flight removed successfully!");
            }
            else
            {
                Console.WriteLine("Flight not found!");
            }

            Console.WriteLine("\nUpdated Flight List:");

            foreach (Flight flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.FlightId} | Flight No.: {flight.FlightNumber} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats} | Date: {flight.Date} | Time: {flight.Time}");
            }
        } // End Remove Method

        //  Admin can View All Passenger Bookings
        public void ViewBookings()
        {
            if (bookings.Count == 0)
            {
                Console.WriteLine("No bookings available.");
                return;
            }

            foreach (var b in bookings)
            {
                Console.WriteLine($"Booking ID: {b.BookingId} | Flight ID: {b.FlightId} | Flight No.: {b.FlightNumber} | Passenger: {b.PassengerName} | PassportNumber: {b.PassportNumber} | from {b.From} to {b.To} | Price: {b.Price}| Date: {b.Date} | Time: {b.Time}\n");
            }
        } // End View All Passenger Bookings Method

    } // End Class FlightManager
} // End Namespace

