using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace LessonA.DaySeven
{
    public delegate void SMSMsgHandler(long phoneno, string msg);
    public delegate void EmailMsgHandler(string emailAddress, string msg);
    internal class DaySeven
    {
        class Bank

        {
            public int Id;
            public string Name = string.Empty;
            public string City = string.Empty;
            public string Region = string.Empty;
            public string PostalCode = string.Empty;
        }//hashset is used so the details wont be reused . read only coz once assigned dont want to change further
        class Customer
        {
            public string CName;
            public int CustId;
            public string address;
            public int phone;
            public readonly DateTime Dob;
        }
        class Branch
        {
            public readonly int BankId;
            public readonly int BranchId;
            public string branchCity;
            public Branch(int bankId, int branchId)
            {
                BankId = bankId;
                BranchId = branchId;

            }
        }
        class Account
        {
            public readonly long AccountNo;
            public readonly int CustId;
            public Account(long accountNo, int custId)
            {
                AccountNo = accountNo;
                CustId = custId;
            }
        }
        public static void addAccount()
        {


        }
        public static void removeAccount()
        {

        }
        public static void displayAccount()
        {

        }

        public static void showAccount()
        {

        }
        public static void withdraw()
        {

        }
        public void Dodeposit(int accno, float amount)
        {

        }


    }
}
//signals have been used . 1st create acc obj. then msg creater obj.then acc controller obj.Events are by default multicast
// += will add and -= will remove
