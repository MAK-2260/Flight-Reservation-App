

// Asif Khan

namespace FlightReservation
{
    internal class Program
    {
        private static string? userChoice; // declare string for user choice if they want continue or not

        //static List<FlightManager> manager = new List<FlightManager>();
        // FlightManager manager = new FlightManager();
        static void Main(string[] args)
        {
            // Username and password for admin login
            AdminDashboard admin = new AdminDashboard // Deep Patel
            {
                Username = "admin",
                Password = "admin123"
            };
            // Flight Management System
            FlightManager flightManager = new FlightManager();
            // Passenger Details
            Passenger passengers = new Passenger();
            // Passenger Interface Dashboard
            PassengerDashboard passengerDashboard = new PassengerDashboard();

            // Main Dashboard Display
                while (true)
                {
                    Console.WriteLine("--------------- FLIGHT RESERVATION App -------------");
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
                                    } // End Admin Switch Case
                                } // End Admin While
                            } // End Admin If Condition
                            else
                            {
                                Console.WriteLine("Invalid admin credentials!");
                            } // End Else

                            break;


                        // Passeneger Work --> Abhay Khosla
                    // Passenger Signup --> Deep Patel

                    case "2": 
                            passengers.Signup();
                            break;

                    // Passenger Login --> Deep Patel
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
                                    } // End Passenger Switch Case
                                } // End Passenger While
                            } // End If Condition - Passenger

                            break;

                        case "4":
                            Console.WriteLine("Exit Successfully");
                            Environment.Exit(0);
                            break;

                        default:
                            Console.WriteLine("Invalid option!");
                            break;
                    } // End Main Switch Case

            // Return to Main Menu
            MainMenu: continue;

        } // End While
    } // End Main Method
  } // End Class Program
} // End Namespace
