using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;



namespace BANK2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome To Parsian Bank");
            while(true)
            { 
            Console.WriteLine("Enter your username:");
            String username = Console.ReadLine();
            Console.WriteLine("Enter your Password:");
            string password = Console.ReadLine();
                if (Employee.Checkup(username, password) == 1 || Employee.Checkup(username, password) == 2 || Employee.Checkup(username, password) == 3)
                {
                    if (Employee.Checkup(username, password) == 1)
                        Console.WriteLine("Welcome Miss Etemadi");
                    else if (Employee.Checkup(username, password) == 2)
                        Console.WriteLine("Welcome Mr Bahrami");
                    else
                        Console.WriteLine("Welcome Mr Shayan");
                    while (true)
                    {
                        Console.WriteLine("for Add Coustomer Enter 1");
                        Console.WriteLine("for Remove Coustomer Enter 2");
                        Console.WriteLine("for View Coustomer Enter 3");
                        Console.WriteLine("for Log Out Enter 4");

                        int key = int.Parse(Console.ReadLine());
                        if (key == 1)
                        {
                            Console.WriteLine("Enter username:");
                            string u = Console.ReadLine();
                            Console.WriteLine("Enter Password:");
                            string p = Console.ReadLine();
                            Console.WriteLine("Enter firstname:");
                            string f = Console.ReadLine();
                            Console.WriteLine("Enter lastname:");
                            string l = Console.ReadLine();
                            Console.WriteLine("Enter ID:");
                            string i = Console.ReadLine();
                            Console.WriteLine("Enter cardnumber:");
                            string c = Console.ReadLine();
                            Console.WriteLine("Enter ccv2:");
                            int cv =int.Parse( Console.ReadLine());
                            Console.WriteLine("Enter Second pass:");
                            int s = int.Parse(Console.ReadLine());
                            Console.WriteLine("EnterExpiration date:");
                            string e = Console.ReadLine();
                            if (DataBase.AddCoustomer(i, u, p, f, l, c, cv, s, e))
                                Console.WriteLine("Done");
                            else
                                Console.WriteLine("Memory Full");
                        }
                        else if (key == 2)
                        {
                            Console.WriteLine("Enter ID:");
                            string i = Console.ReadLine();
                            if (DataBase.RemoveCoustomer(i))
                            {
                                Console.WriteLine("Done");
                            }
                            else
                            {
                                Console.WriteLine("No Coustomer found whith thids ID");
                            }
                        }
                        else if (key == 3)
                        {
                            Console.WriteLine(DataBase.viewCoustomer());
                        }
                        else if (key == 4)
                        {
                            break;
                        }
                        else
                            Console.WriteLine("Incorrect!");
                    }
                }
                else if (DataBase.Checkup2(username, password))
                {
                    
                  
                  Console.WriteLine("Enter id");
                  string id = Console.ReadLine();
                    if (DataBase.CheckID(id))
                    {
                        Console.WriteLine("Welcome Dear Coustomer : " + username);
                        while (true)
                        {
                            Console.WriteLine("for Deposit Enter 1");
                            Console.WriteLine("for Withdraw Enter 2");
                            Console.WriteLine("for Money Transfer Enter 3");
                            Console.WriteLine("View the last 5 Rounds Enter 4");
                            Console.WriteLine("for LogOut Enter 5");
                            int key = int.Parse(Console.ReadLine());
                            if (key == 1)
                            {
                                Console.WriteLine("Enter Deposit Emount:");
                                int depe = int.Parse(Console.ReadLine());
                                if (DataBase.DepositAmount(id, depe))
                                {
                                    Console.WriteLine("Successful deposit"+"\n"+"Deposit to account : " + depe + "Rial"
                                    +"\n"+" Balance : " + DataBase.ViewBalance(id) + "Rial");
                                    string ac = "Deposit";
                                    int B = DataBase.ViewBalance(id);
                                    DataBase.addRound(ac, id, depe);
                                }

                            }
                            else if (key == 2)
                            {
                                Console.WriteLine("Enter Withdrawal amount :");
                                int wid = int.Parse(Console.ReadLine());
                                if(wid+5000> DataBase.ViewBalance(id)){
                                    Console.WriteLine("Inventory is not enough");
                                }
                                else
                                {
                                    if (DataBase.Withdrawalamount(id, wid))
                                    {
                                        Console.WriteLine("Successful Withdrawal" + "\n"+"Withdrawal amount :" + wid + "Rial"
                                       +"\n"+" Balance : " + DataBase.ViewBalance(id) + "Rial");
                                        string ac = "Withdrawal";
                                        int B = DataBase.ViewBalance(id);
                                        DataBase.addRound(ac ,id, wid);
                                    }

                                }

                            }
                            else if (key == 3)
                            {
                                Console.WriteLine("Enter Transfer amount:");
                                int Trm =int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Destination card number:");
                                string Dest = Console.ReadLine();
                                Console.WriteLine("Enter CCV2:");
                                int ccv2= int.Parse(Console.ReadLine());
                                Console.WriteLine("Enter Second number:");
                                int s= int.Parse(Console.ReadLine());
                                Console.WriteLine("Expiration date:");
                                String e = Console.ReadLine();
                                if(Trm+5000 > DataBase.ViewBalance(id))
                                {
                                    Console.WriteLine("Inventory is not enough");
                                }
                                else
                                {
                                    if (DataBase.CheckDestinationcard(Dest) != "")
                                    {
                                        DataBase.Withdrawalamount(id, Trm);
                                        string ISC = DataBase.CheckDestinationcard(Dest);
                                        DataBase.DepositAmount(ISC, Trm);
                                        Console.WriteLine("Money transfer completed successfully" + "\n" +
                                        "Withdrawal amount: " + Trm + "Rial" + "\n" +
                                        "Balance : " + DataBase.ViewBalance(id) + "Rial");
                                        string ac = "Transfer";
                                        int b = DataBase.ViewBalance(id);
                                        int B = DataBase.ViewBalance(ISC);
                                        DataBase.addRound(id, ac, Trm);
                                        DataBase.addRound(ISC, ac, Trm);
                                    }
                                    else
                                        Console.WriteLine("Destination card number is not valid");
                                }

                            }
                            else if (key == 4)
                            {

                                Console.WriteLine(DataBase.ViewRounds());
                            }
                            else if (key == 5)
                            {
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Incorrect!");
                            }
                        }
                    }
                    else
                        Console.WriteLine("Invalid!");
                }
                else
                {
                    Console.WriteLine(" username and/or password is/are Incorect!");
                }
            }
            
        }
    }
}
