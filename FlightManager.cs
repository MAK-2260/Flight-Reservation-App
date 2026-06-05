using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    internal class FlightManager
    {
        static List<Flight> flights = new List<Flight>();
       static List<Passenger> passengers = new List<Passenger>();

        // Add Flight
        public void AddFlight()
        {
            try
            {
                Console.Write("Flight ID: ");
                int id = Convert.ToInt32(Console.ReadLine());

                Console.Write("From: ");
                string from = Console.ReadLine();

                Console.Write("To: ");
                string to = Console.ReadLine();

                Console.Write("Seats: ");
                int seats = Convert.ToInt32(Console.ReadLine());

                Console.Write("Price: ");
                double price = Convert.ToDouble(Console.ReadLine());

                flights.Add(new Flight
                {
                    FlightId = id,
                    From = from,
                    To = to,
                    Seats = seats,
                    Price = price
                    

                });

                Console.WriteLine("Flight added successfully!");
            }
            catch
            {
                Console.WriteLine("Invalid input!");
            }
        }

        // View All Flights
        public void ViewAllFlights()
        {
            foreach (Flight flight in flights)
            {
                Console.WriteLine($"{flight.FlightId} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats}");
            }

        }

        // Search Flights
        public void SearchFlight()
        {
            Console.Write("Enter Flight ID: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var flight = flights.FirstOrDefault(f => f.FlightId == id);

            if (flight != null)
            {
                Console.WriteLine($"{flight.FlightId} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats} ");
            }
            else
            {
                Console.WriteLine("Flight not found!");
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
            Console.WriteLine("\nRemove an Existing Flight");
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

            Console.WriteLine("\nUpdated Flight List:");

            foreach (Flight flight in flights)
            {
                Console.WriteLine($"{flight.FlightId} | {flight.From} to {flight.To} | Price: {flight.Price} | Seats: {flight.Seats}");
            }
        }

        
    }
}

