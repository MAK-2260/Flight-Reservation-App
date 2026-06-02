
# Flight-Reservation-App
Share your work here 
Deep Patel
User class:
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Reservation_App
{
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        public virtual void ShowMenu()
        {
            Console.WriteLine("***********************************");
            Console.WriteLine("******* Passenger Dashboard *******");
            Console.WriteLine("***********************************");
            Console.WriteLine("1. View Flights");
            Console.WriteLine("2. Search Flights");
            Console.WriteLine("3. Book Flight");
            Console.WriteLine("4. Cancel Booking");
            Console.WriteLine("5. Logout");

        }
    }
}

----------------------------------------------------------------
passenger class:
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Reservation_App
{
    internal class Passenger : User
    {
        public int PassengerId { get; set; }
        public string PassportNumber { get; set; }
        public string Username { get; internal set; }
        public string Password { get; internal set; } 


    }
}

______________________________________________
Admin class:
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Reservation_App
{
    internal class Admin : User
    {
        public override void ShowMenu()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("******** Admin Dashboard *********");
            Console.WriteLine("**********************************");
            Console.WriteLine("1. Add Flight");
            Console.WriteLine("2. Search Flight");
            Console.WriteLine("3. Manage Flight");
            Console.WriteLine("4. Remove Flight");
            Console.WriteLine("5. Logout");
        }
    }
}
-----------------------------------------------
Login system:
using Flight_Reservation_App;
using System;
using System.Collections.Generic;
using System.Text;

namespace Flight_Reservation_App
{

    internal class LoginSystem
    {
        public List<Passenger> passengers = new List<Passenger>();

        int passengerCounter = 1;

        //Signup
        public void Signup()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("******** Passenger Signup ********");
            Console.WriteLine("**********************************");

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

        //Login
        public Passenger Login()
        {
            Console.WriteLine("**********************************");
            Console.WriteLine("******** Passenger Login *********");
            Console.WriteLine("**********************************");


            Console.Write("Username: ");
            string username = Console.ReadLine();

            Console.Write("Password: ");
            string password = Console.ReadLine();

            Passenger passenger = passengers.Find(p => p.Username == username && p.Password == password);

            if (passenger != null)
            {
                Console.WriteLine("Invalid credentials!");
                Console.WriteLine("Please create an account.");
                return null;
            }
            else
            {
                Console.WriteLine("Login successful!");
                return passenger;
            }
        } 

        //Logout
        public void Logout() 
        {
            Console.WriteLine("Logged out successfully!");
        }
    }
}
----------------------------------------------------------

Main class:

namespace Flight_Reservation_App
{
    internal class Program
    {
        private static string userChoice;

        static void Main(string[] args)
        {

            Admin admin = new Admin
            {
                Username = "admin",
                Password = "admin123"
            };
         

            do
            {
                Console.WriteLine("**********************************");
                Console.WriteLine("***** FLIGHT RESERVATION APP *****");
                Console.WriteLine("**********************************");
                Console.WriteLine("1. Admin Login");
                Console.WriteLine("2. Passenger Signup");
                Console.WriteLine("3. Passenger Login");
                Console.WriteLine("4. Exit");
                Console.WriteLine("**********************************");

                

                Console.Write("Select you chocie: ");
                int choice = Convert.ToInt32(Console.ReadLine());
                LoginSystem passengers = new LoginSystem();
                Admin add = new Admin();
                User user = new User();




                switch (choice)
                {
                    case 1:
                        Console.WriteLine("**********************************");
                        Console.WriteLine("*********** Admin Login **********");
                        Console.WriteLine("**********************************");
                         
                        Console.Write("Username: ");
                        string adminUser = Console.ReadLine();

                        Console.Write("Password: ");
                        string adminPass = Console.ReadLine();

                        if (adminUser == admin.Username && adminPass == admin.Password)
                        {
                            add.ShowMenu();
                        }
                        break;
                    case 2:
                        Console.WriteLine("");
                        passengers.Signup();
                        break;
                    case 3:
                        Console.WriteLine("");
                        passengers.Login();
                        user.ShowMenu();
                        break;
                    case 4:
                        Console.WriteLine("");
                        Environment.Exit(0);
                        break;
                    default:
                        Console.WriteLine("Error!");
                        break;

                }
                Console.WriteLine("Would like to continue (yes/no)");
                string userChoice = Console.ReadLine();
            } while (userChoice != "no");

        }
    }
}
----------------------------------------------------------------------------------------
