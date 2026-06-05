namespace FlightReservation
{
    internal class Program
    {
        private static string? userChoice;

        //static List<FlightManager> manager = new List<FlightManager>();
        //static List<Passenger> passengers = new List<Passenger>();
        // FlightManager manager = new FlightManager();
        static void Main(string[] args)
        {
            FlightManager flightManager = new FlightManager();
            Passenger passengers = new Passenger();
            PassengerDashboard passengerDashboard = new PassengerDashboard();

            Admin admin = new Admin // Deep Patel
            {
                Username = "admin",
                Password = "admin123"
            };
            // Asif Khan
            while (true)
                {
                    Console.WriteLine("\n********* FLIGHT RESERVATION App **************");
                    Console.WriteLine("\n*************************************************");
                    Console.WriteLine("1. Admin Login");
                    Console.WriteLine("2. Passenger Signup");
                    Console.WriteLine("3. Passenger Login");
                    Console.WriteLine("4. Exit");

                    Console.Write("Choose Option: ");
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
                                        flightManager.AddFlight();
                                        break;

                                        case "2":
                                            flightManager.SearchFlight();
                                            break;

                                        case "3":
                                        Console.WriteLine("View All Bookings"); // Once Abhay will done need to create method in admin 
                                        break;

                                        case "4":
                                            flightManager.ManageFlight();
                                            break;

                                        case "5":
                                            flightManager.RemoveFlight();
                                            break;
                                        case "6":
                                            flightManager.ViewAllFlights();
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

                    // Passenger Login - Abhay Khosla
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
                                        flightManager.ViewAllFlights();
                                        break;

                                    case "2":
                                        flightManager.SearchFlight();
                                        break;

                                    case "3":
                                        Console.WriteLine("Book Flight");
                                        break;

                                    case "4":
                                        Console.WriteLine("Cancel Booking");
                                        break;

                                    case "5":
                                        Console.WriteLine("View My Bookings");
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
