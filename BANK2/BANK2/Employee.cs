using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK2
{
    class Employee
    {
        static string username1 = "Admin1";
        static string password1 = "1234";
        static string username2 = "Admin2";
        static string password2 = "5678";
        static string username3 = "Admin3";
        static string password3 = "9012";
        public static int Checkup(string U, string P)
        {
            if (username1 == U && password1 == P)
                return 1;
             else if (username2 == U && password2 == P)
                return 2;
            else if (username3 == U && password3 == P)
                return 3;
            else
            return 0;
        }
    }
}
