namespace FlightReservation
{
    internal class Program
    {
        private static string? userChoice;

        //static List<FlightManager> manager = new List<FlightManager>();
        // FlightManager manager = new FlightManager();
        static void Main(string[] args)
        {
            AdminDashboard admin = new AdminDashboard
            {
                Username = "admin",
                Password = "admin123"
            };

            FlightManager flightManager = new FlightManager();
            Passenger passengers = new Passenger();
            PassengerDashboard passengerDashboard = new PassengerDashboard();

                while (true)
                {
                    Console.WriteLine("\n--------------- FLIGHT RESERVATION App -------------");
                    Console.WriteLine("====================================================\n");
                    Console.WriteLine("1. Admin Login");
                    Console.WriteLine("2. Signup : Passenger");
                    Console.WriteLine("3. Login : Passenger ");
                    Console.WriteLine("4. Exit");
                    Console.WriteLine("\n----------------------------------------------------");

                Console.Write("\nChoose Option: ");
                    string choice = Console.ReadLine();

                    switch (choice)
                    {
                        // Admin Login
                        case "1":

                            Console.Write("Username: ");
                            string adminUser = Console.ReadLine();

                            Console.Write("Password: ");
                            string adminPass = Console.ReadLine();

                            if (adminUser == admin.Username &&
                                adminPass == admin.Password)
                            {
                                while (true)
                                {
                                    admin.ShowMenu();

                                    Console.Write("Choose Option: ");
                                    string adminChoice = Console.ReadLine();

                                    switch (adminChoice)
                                    {
                                        case "1":
                                        Console.WriteLine("Add Flights");
                                        flightManager.AddFlight();
                                            break;

                                        case "2":
                                        Console.WriteLine("View All Flight Details");
                                        flightManager.ViewAllFlights();
                                            break;

                                        case "3":
                                        Console.WriteLine("Search Result");
                                        flightManager.SearchFlight();
                                        break;

                                        case "4":
                                        Console.WriteLine("Update Flights");
                                        flightManager.ManageFlight();
                                        break;

                                        case "5":
                                        Console.WriteLine("Delete Flights");
                                        flightManager.RemoveFlight();
                                        break;

                                        case "6":
                                        Console.WriteLine("View All Passenger Bookings");
                                        flightManager.ViewBookings();
                                        break;

                                        case "7":
                                            Console.WriteLine("Admin logged out.");
                                            goto MainMenu;

                                        default:
                                            Console.WriteLine("Invalid option!");
                                            break;
                                    }
                                }
                            }
                            else
                            {
                                Console.WriteLine("Invalid admin credentials!");
                            }

                            break;

                        // Passenger Signup 
                        case "2":
                            passengers.Signup();
                            break;

                        // Passenger Login
                        case "3":

                            Passenger passenger = passengers.Login();

                            if (passenger != null)
                            {
                                while (true)
                                {
                                    passengerDashboard.ShowMenu();

                                    Console.Write("Choose Option: ");
                                    string passengerChoice = Console.ReadLine();

                                    switch (passengerChoice)
                                    {
                                        case "1":
                                        Console.WriteLine("Available Flights");
                                            flightManager.ViewAllFlights();
                                            break;

                                        case "2":
                                        Console.WriteLine("Result");
                                        flightManager.SearchFlight();
                                            break;

                                        case "3":
                                        Console.WriteLine("Book Flights");
                                        passengers.BookFlight(passenger, flightManager);
                                            break;

                                        case "4":
                                        Console.WriteLine("My Booking Dashboard");
                                        passengers.ViewMyBookings(passenger, flightManager);
                                        break;

                                        case "5":
                                            passengers.CancelBooking(passenger, flightManager);
                                        break;

                                        case "6":
                                            Console.WriteLine("Passenger logged out.");
                                            goto MainMenu;

                                        default:
                                            Console.WriteLine("Invalid option!");
                                            break;
                                    }
                                }
                            }

                            break;

                        case "4":
                            Console.WriteLine("Exit Successfully");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    }
                   
                
                MainMenu:
                    continue;
             
            }
    }
    }
}
