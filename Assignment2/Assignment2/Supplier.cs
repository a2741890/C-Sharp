using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    class Supplier
    {
        private string supplierName;
        private int accountNumber;
        //at the begging of the particular month DJ owing by supplier
        private double accountBalance;
        //total of all purchase by DJ from supplier this month
        private double totalOfPurchase;
        //total of payments made by DJ to supplier this month, no overpayment
        private double totalOfPayment;
        //amount owing at the end of the month by DJ to supplier
        private double amountOwing;
        //constant: condition to display a message
        const double threshold = 600;
        //Default Constructor
        public Supplier()
        {

        }
        public Supplier(string sN,int aN)
        {
            supplierName = sN;
            accountNumber = aN;
        }
        public Supplier(double aB, double tPur, double tPay) { 
        
            
            accountBalance = aB;
            totalOfPurchase = tPur;
            totalOfPayment = tPay;
            amountOwing = GetAmountOwing();

        }
        public Supplier(string sN,int aN,double aB, double tPur, double tPay)
        {
            supplierName = sN;
            accountNumber = aN;
            accountBalance = aB;
            totalOfPurchase = tPur;
            totalOfPayment = tPay;
            amountOwing = GetAmountOwing();

        }
        public string SupplierName {
            get {
                return supplierName;
                }
            set {
                supplierName = value;
            }
        }
        public int AccountNumber
        {
            get
            {
                return accountNumber;
            }
            set
            {
                accountNumber = value;
            }
        }
        public double AccountBalance
        {
            get
            {
                return accountBalance;
            }
            set
            {
                accountBalance = value;
            }
        }
        
        public double TotalOfPurchase
        {
            get
            {
                return totalOfPurchase;
            }
            set
            {
                totalOfPurchase = value;
            }
        }
        public double TotalOfBalance
        {
            get
            {
                return totalOfPayment;
            }
            set
            {
                totalOfPayment = value;
            }
        }
        public double AmountOwning
        {
            get
            {
                return amountOwing;
            }
            set
            {
                amountOwing = value;
            }
        }
        public double GetAmountOwing()
        {
            
            amountOwing = AccountBalance + totalOfPurchase;
            amountOwing -= totalOfPayment;
            return amountOwing;
        }
        
        public override string ToString()
        {
            
            if (GetAmountOwing() > threshold)
            {
                return "Supplier: " + accountNumber + "\nThe account balance at the end of the month: " + GetAmountOwing() + "\nPayment of this account is due now.";
            }
            else
            {
                return "Supplier: " + accountNumber + "\nThe account balance at the end of the month: " + GetAmountOwing();
            }
        }


    }
}
