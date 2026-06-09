using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Text;

namespace FlightReservation
{
    internal class FlightManager
    {
        public List<Flight> flights = new List<Flight>();
        public List<Booking> bookings = new List<Booking>();

        public int FlightIDCounter = 101;
        

        // public List<Passenger> passengers = new List<Passenger>();
        // Add Flight
        public void AddFlight()
        {
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
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }

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
        }

        //  View All Booking
        public void ViewBookings()
        {
            if (bookings.Count == 0)
            {
                Console.WriteLine("No bookings available.");
                return;
            }

            foreach (var b in bookings)
            {
                Console.WriteLine($"Booking ID: {b.BookingId} | Flight ID: {b.FlightId} | Flight No.: {b.FlightNumber} | Passenger: {b.PassengerName} | PassportNumber: {b.PassportNumber} | from {b.From} to {b.To} | Price: {b.Price}| Date: {b.Date} | Time: {b.Time}");
            }
        }

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
        }

        // Remove Flight
        public void RemoveFlight()
        {
            Console.WriteLine("Remove an Existing Flight");
            Console.WriteLine("*************************************");

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

            Console.WriteLine("Updated Flight List:");

            foreach (Flight flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.FlightId} | Flight No.: {flight.FlightNumber} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats} | Date: {flight.Date} | Time: {flight.Time}");
            }
        }

        public void ViewAllFlights() 
        {
            foreach (Flight flight in flights)
            {
                Console.WriteLine($"Flight ID: {flight.FlightId} | Flight No.: {flight.FlightNumber} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats} |  Date: {flight.Date} | Time: {flight.Time}");
            }

        }      
    }
}

