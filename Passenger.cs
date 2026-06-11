
// Abhay Khosla

using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    internal class Passenger
    {
        // List to store all passengers
        public List<Passenger> passengers = new List<Passenger>();

        // Counters used to generate unique IDs for passengers and bookings
        int passengerCounter = 1;
        int bookingCounter = 1;

        public string? Username { get; private set; }
        public int PassengerId { get; private set; }
        public string? Password { get; private set; }
        public string? PassportNumber { get; private set; }


        // Passenger SignUp
        public void Signup() // Deep Patel
        {
            Console.WriteLine("\n===== PASSENGER SIGNUP =====");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Console.Write("Passport Number: ");
            string passport = Console.ReadLine();

            passengers.Add(new Passenger
            {
                PassengerId = passengerCounter++,
                Username = username,
                Password = password,
                PassportNumber = passport
            });

            Console.WriteLine("Signup successful!");
        } // End Passenger Signup

        // Passenger Login
        public Passenger Login() // Deep Patel
        {
            Console.WriteLine("\n===== PASSENGER LOGIN =====");

            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            var passenger = passengers.FirstOrDefault(p =>
                p.Username == username &&
                p.Password == password);

            if (passenger != null)
            {
                Console.WriteLine("Login successful!");
                return passenger;
            }

            Console.WriteLine("Invalid credentials!");
            return null;
        } // End Passenger Login

        // Book Flight 
        // Original implementation by Abhay Kholsa, with modifications by Asif Khan
        public void BookFlight(Passenger passenger, FlightManager manager)
        {
            manager.ViewAllFlights();

            Console.Write("\nEnter Flight ID to Book: ");
            int id = Convert.ToInt32(Console.ReadLine());

            var flight = manager.flights.FirstOrDefault(f => f.FlightId == id);

            if (flight == null)
            {
                Console.WriteLine("Flight not found!");
                return;
            }

            if (flight.Seats <= 0)
            {
                Console.WriteLine("No seats available!");
                return;
            }

            flight.Seats--;

            manager.bookings.Add(new Booking
            {
                BookingId = bookingCounter++,
                PassengerName = passenger.Username,
                FlightId = id,
                // Seats = flight.Seats,
                Price = flight.Price,
                From = flight.From,
                To = flight.To,
                PassportNumber = passenger.PassportNumber,
                FlightNumber = flight.FlightNumber,
                Date = flight.Date,
                Time = flight.Time
            });

            Console.WriteLine("Flight booked successfully!");
        } // End Book Flight

        // View My Booking
        public void ViewMyBookings(Passenger passenger, FlightManager manager)
        {
            var bookings = manager.bookings.Where(b => b.PassengerName == passenger.Username && b.PassportNumber == passenger.PassportNumber);

            if (!bookings.Any())
            {
                Console.WriteLine("No bookings found.");
                return;
            }

            foreach (var booking in bookings)
            {
                Console.WriteLine($"Booking ID: {booking.BookingId} | Flight ID: {booking.FlightId} | Flight No.: {booking.FlightNumber} | from {booking.From} to {booking.To} | Price: {booking.Price} | Date: {booking.Date} | Time: {booking.Time}"); 
            }
        } // End View My Booking


        // Cancel Booking
        public void CancelBooking(Passenger passenger, FlightManager manager)
        {
            Console.WriteLine("\nCancel an Existing Booking");
            Console.WriteLine("-----------------------------");

            Console.Write("Enter Booking ID to Cancel: ");
            int bookingIdRemove = Convert.ToInt32(Console.ReadLine());

            Booking bookingRemove = manager.bookings.Find(b => b.BookingId == bookingIdRemove&& b.PassengerName == passenger.Username);

            if (bookingRemove != null)
            {
                Console.WriteLine($"Booking ID {bookingIdRemove} found");

                manager.bookings.Remove(bookingRemove);

                // Return seat back to flight
                Flight flight = manager.flights.Find(f => f.FlightId == bookingRemove.FlightId);

                if (flight != null)
                {
                    flight.Seats++;
                }

                Console.WriteLine("Booking cancelled successfully!");
            }
            else
            {
                Console.WriteLine("Booking not found!");
            }

            Console.WriteLine("\nUpdated Booking List:");

            foreach (Booking booking in manager.bookings)
            {
                if (booking.PassengerName == passenger.Username)
                {
                    Console.WriteLine($"Booking ID: {booking.BookingId} | Flight ID: {booking.FlightId}");
                }
            }
        } // End Cancel Booking
    
    } // End Class Passenger
} // End Namespace
