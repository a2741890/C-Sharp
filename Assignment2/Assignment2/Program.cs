using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Program
    {

        static void Main(string[] args)
        {
            int numberOfTrack, aN, count;
            double accountBalance, totalPurchase, totalPayment;
            string sN;
            //Create an array of Supplier
            Supplier[] listOfSuppliers;
            Console.WriteLine("Hello, this is a system for David Jones to identify the suppliers to whom David Jones owes more than {0:C}", 600.00);
            Console.WriteLine("Would you like to track any supplier's status? Yes/No");
            if (Console.ReadLine().ToUpper() == "YES")
            {
                Console.WriteLine("Please enter the number of suppliers you wish to track");
                int.TryParse(Console.ReadLine(), out numberOfTrack);
                listOfSuppliers = new Supplier[numberOfTrack];
                count = 1;
                while (count < numberOfTrack + 1)
                {
                    sN = GetSupplierName();
                    aN = GetAccountNumber();
                    accountBalance = GetAccountBalance();
                    totalPurchase = GetTotalPurchase();
                    totalPayment = GetTotalPayment(accountBalance,totalPurchase);
                    listOfSuppliers[count - 1] = new Supplier(sN, aN, accountBalance, totalPurchase, totalPayment);
                    count++;
                }
                Console.Clear();
                for (int i = 0; i < listOfSuppliers.Length; i++)
                {
                    Console.WriteLine("On the following are the suppliers you wish to track:\n{0}\n", listOfSuppliers[i]);
                }
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Get the fuck out of my program.");
            }
            Console.ReadKey();
        }//EndOfMainMethod


        public static string GetSupplierName()
        {
            string sN;
            bool isInvalid = true;
            do
            {
                Console.WriteLine("Enter the name of supplier, and the length must be between 5~15 characters:");
                sN = Console.ReadLine();
                if (sN.Length < 5 || sN.Length > 15)
                {
                    Console.WriteLine("Invalid input length of the supplier name.");
                    isInvalid = false;
                }
                    
                } while(isInvalid == false);
            return sN;
        }
                public static int GetAccountNumber()
                {
                    bool isInvalid = true;
                    int aN;
                    do
                    {

                        Console.WriteLine("Enter the number of account, it start with 2 and must be 6 digits in total");
                        Console.Write("2");
                        if (int.TryParse(Console.ReadLine(), out aN) == true && aN >9999  && aN + 200000 < 299999)
                        {
                            aN += 200000;
                            isInvalid = true;
                        }
                        else
                        {
                            Console.WriteLine("Entering length of number is invalid.");
                            isInvalid = false;
                        }
                    } while (isInvalid == false);
                    return aN;
                }
                public static double GetAccountBalance()
                {
                    bool isInvalid = true;
                    double accountBalance;
                    do
                    {
                        Console.WriteLine("Enter the account of the balance at the beginning of the month :");
                        if (double.TryParse(Console.ReadLine(), out accountBalance) == true || accountBalance >= 0)
                        {
                            //Go to next step
                            isInvalid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input balance.");
                            isInvalid = false;
                        }
                    } while (isInvalid == false);
                    return accountBalance;
                }
                public static double GetTotalPurchase()
                {
                    bool isInvalid = true;
                    double totalPurchase;
                    do
                    {
                        Console.WriteLine("Enter the total of all purchase by {0} in the month: ");
                        Console.Write("$");
                        if (double.TryParse(Console.ReadLine(), out totalPurchase) == true && totalPurchase >= 0)
                        {
                            //Go to next step
                            isInvalid = true;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input purchase amount.");
                            isInvalid = false;
                        }
                    } while (isInvalid = false);
                    return totalPurchase;
                }
                public static double GetTotalPayment(double aB, double tP)
                {
                    bool isInvalid = true;
                    double totalPayment;
                    do
                    {
                        Console.WriteLine("Enter the total payment made by David Jone to the supplier in the month");
                        Console.Write("$");
                        if (double.TryParse(Console.ReadLine(), out totalPayment) == true && totalPayment >= 0 && totalPayment < aB+tP)
                        {
                            //Go to next step
                            isInvalid = true;
                        }
                        else if (totalPayment > aB+tP)
                        {
                            Console.WriteLine("No overpayment should be made, the total owing amount is {0}", aB+tP);
                            isInvalid = false;
                        }
                        else
                        {
                            Console.WriteLine("Invalid input payment amount.");
                        }
                    } while (isInvalid == false);
                    return totalPayment;
                }
            }
   


}

