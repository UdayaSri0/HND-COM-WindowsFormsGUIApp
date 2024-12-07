using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsGUIApp
{
    internal class Session
    {
        public static string LoggedInUserName { get; set; } // The name of the logged-in user
        public static string LoggedInUserEmail { get; set; } // The email of the logged-in user
        public static string LoggedInUserEMPNumber { get; set; } // The EMP number of the logged-in user
        public static string LoggedInUserRole { get; set; } // The role (Admin/User) of the logged-in user

    }
}
