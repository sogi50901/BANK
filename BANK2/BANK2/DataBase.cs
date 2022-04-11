using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BANK2
{
    class DataBase
    {
        public static Coustomer[] allcoustomers = new Coustomer[20];
        public static int actkp = 0;
        public static CardNumber[] allcardnumbers = new CardNumber[10000];
        public static int catkp = 0;
        public static bool AddCoustomer(string i, string u, string p, string f, string l, string c, int cv, int s, string e)
        {
            if (actkp == 20)
                return false;
            Coustomer X = new Coustomer(i);
            X.username = u;
            X.password = p;
            X.firstname = f;
            X.lastname = l;
            X.cardnumber = c;
            X.ccv2 = cv;
            X.secondPass = s;
            X.expirationdate = e;
            allcoustomers[actkp] = X;
            actkp++;
            return true;
        }
        public static bool addRound(string ac ,string i, int am)
        {
            if (catkp == 10000)
            {
                catkp = 0;
            }
            CardNumber Y = new CardNumber();
            Y.action = ac;
            Y.id = i;
            Y.amount = am;
            allcardnumbers[catkp] = Y;
            catkp++;
            return true;
        }
        public static string ViewRounds()
        {
            string R = "";
            for(int j=0; j<6; j++)
            {
                R += allcardnumbers[j].action + "  " + allcardnumbers[j].amount + "  "  + "\n";
            }
            return R;
        }
        public static bool RemoveCoustomer(string id)
        {
            for (int i = 0; i <= actkp; i++)
            {
                if (allcoustomers[i].id == id)
                {
                    allcoustomers[i] = allcoustomers[actkp - 1];
                    actkp--;
                    return true;
                }

            }
            return false;
        }
        public static string viewCoustomer()
        {
            string R = "";
            for (int i = 0; i < actkp; i++)
            {
                R += allcoustomers[i].username + allcoustomers[i].id + " " + allcoustomers[i].cardnumber + "\n";
            }
            return R;
        }
        public static bool Checkup2(string U, string P)
        {
            for (int i = 0; i < actkp; i++)
            {
                if (allcoustomers[i].username == U && allcoustomers[i].password == P)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool CheckID(string id)
        {
            for (int i = 0; i < actkp; i++)
            {
                if (allcoustomers[i].id == id)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool DepositAmount(string ID, int Dep)
        {
            for (int i = 0; i < actkp; i++)
            {
                if (allcoustomers[i].id == ID)
                {
                    allcoustomers[i].balance += Dep;
                    return true;
                }
            }
            return false;
        }

        public static int ViewBalance(string ID)
        {
            int newBalance = 0;
            for (int i = 0; i < actkp; i++)
            {
                if (allcoustomers[i].id == ID)
                {
                    newBalance = allcoustomers[i].balance;
                }
            }
            return newBalance;
        }
        public static bool Withdrawalamount(string ID, int Wid)
        {
            for (int i = 0; i < actkp; i++)
            {
                if (allcoustomers[i].id == ID)
                {
                    allcoustomers[i].balance -= Wid;
                    return true;
                }
            }
            return false;
        }
        public static string CheckDestinationcard(string SC)
        {
            string S = "";
           
            for(int i=0; i<actkp; i++)
            {
                if (allcoustomers[i].cardnumber == SC)
                {
                    S = allcoustomers[i].id;
                }
                else
                    S = "";
            }
            return S;
        }
    }
}