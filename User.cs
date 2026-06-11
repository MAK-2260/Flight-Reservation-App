

//Deep Patel

using System;
using System.Collections.Generic;
using System.Text;

namespace FlightReservation
{
    // Basic class for all users in the system
    internal class User
    {
        public string Username { get; set; }
        public string Password { get; set; }

        
        public virtual void ShowMenu()
        {

        }
    
    } // End Class User
}// End Namespace
