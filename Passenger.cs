using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    internal class Passenger
    {
        public List<Passenger> passengers = new List<Passenger>();

        int passengerCounter = 1;

        public string? Username { get; private set; }
        public int PassengerId { get; private set; }
        public string? Password { get; private set; }
        public string? PassportNumber { get; private set; }

        // SignUp
        public void Signup()
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
        }

        // Login
        public Passenger Login()
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
        }


       
    }
}