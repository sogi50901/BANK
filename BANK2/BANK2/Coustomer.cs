using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BANK2
{
    class Coustomer 
    {
        public string username;
        public string password;
        public string firstname;
        public string lastname;
        public int ccv2;
        public int secondPass;
        public string expirationdate;
        public string cardnumber;
        public string id;
        public int balance = 0;
        public Coustomer(string id)
        {
            this.id = id;
        }
        

    }
}
