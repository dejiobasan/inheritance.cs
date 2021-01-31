using System;
using System.Collections.Generic;
using System.Text;

namespace Inheritance
{
    public class Account
    {
        private string firstname;
        private readonly string lastname;
        private string bvnnumber;
        private decimal accountbalance;
        private decimal accountcredit;
        private decimal accountdebit;

        // six-parameter constructor
        public Account(string first, string last, string number, decimal balance, decimal credit, decimal debit)
        {
            firstname = first;
            lastname = last;
            bvnnumber = number;
            accountbalance = balance;
            accountcredit = credit;
            accountdebit = debit;
        }

        public string FirstName
        {
            get
            {
                return firstname;
            }
        }

        public string LastName
        {
            get
            {
                return lastname;
            }
        }

        public string BvnNumber
        {
            get
            {
                return bvnnumber;
            }
        }

        public decimal AccountBalance
        {
            get
            {
                return accountbalance;
            }
            set
            {
                if (value >= 0)
                    accountbalance = value;
                else
                    throw new ArgumentOutOfRangeException("accountbalance", value, "accountbalance must be >= 0");
            }
        }

        public decimal AccountCredit
        {
            get
            {
                return accountcredit = accountbalance + accountcredit;
            }
        }

        public decimal AccountDebit
        {
            get
            {
                return accountdebit = accountbalance - accountdebit;
            }
            set
            {
                if (value > accountbalance)
                    accountdebit = value;
                else
                    throw new ArgumentOutOfRangeException("accountdebit", value, "accountdebit must be < accountbalance");
            }
        }

        public class SavingsAccount
        {
            private readonly string firstname;
            private string lastname;
            private string bvnnumber;
            private decimal initialbalance;
            private decimal interestrate;
            private decimal interestammount;


            //six parameter constructor

            public SavingsAccount(string first, string last, string number, decimal balance, decimal rate, decimal ammount)
            {
                firstname = first;
                lastname = last;
                bvnnumber = number;
                initialbalance = balance;
                interestrate = rate;
                interestammount = ammount;
            }

            public decimal CalculateInterest
            {
                get
                {
                    return interestammount = (initialbalance * interestrate);
                }
            }
            public class CheckingAccount
            {
                private decimal accountbalance1;
                private decimal initialbalance;
                private decimal feechargedpertransaction;
                private decimal feeammount;
                private decimal accountcredit;
                private decimal accountdebit;

                //six parameter constructor

                public CheckingAccount(decimal balance1, decimal balance, decimal fee, decimal ammount, decimal credit, decimal debit)
                {
                    accountbalance1 = balance1;
                    initialbalance = balance;
                    feechargedpertransaction = fee;
                    feeammount = ammount;
                    accountcredit = credit;
                    accountdebit = debit;
                }

                public decimal accountbalance
                {
                    get
                    {
                        return accountbalance1 = (initialbalance - feeammount);
                    }
                    set
                    {
                        if (value > accountbalance1)
                            feeammount = value;
                        else
                            throw new ArgumentOutOfRangeException("feeammount", "feeamount must be < accountbalance1");
                        
                    }
                }
            }

        }
        public override string ToString()
        {
            return string.Format("{0}: {1} {2}\n{3}: {4}\n{5}: {6}\n{7}: {8}\n{9}: {10}", "Account", firstname, lastname, "bvnnumber", bvnnumber, "accountbalance", accountbalance,
                "accountcredit", accountcredit, "accountdebit", accountdebit);
        }
        public class AccountTest
        {
            private static object firstname;

            public AccountTest(string v1, string v2, string v3, decimal v4, decimal v5, decimal v6)
            {
            }

            public static AccountTest Account { get; private set; }

            public static void Main(string[] args)
            {
                Account = new AccountTest("Trevor", "Phillips", "57581457", 6000000M, 100000M, 2000M);

                Console.WriteLine("firstname is {0}:");
                Console.WriteLine("lastname is {1}:");
                Console.WriteLine("bvnnumber is {2}:");
                Console.WriteLine("accountbalance is {3}:");
                Console.WriteLine("accountcredit is {4}:");
                Console.WriteLine("accountdebit is {5}:");
                Console.WriteLine("initialbalance is {6}:");
                Console.WriteLine("interestrate is {7}:");
                Console.WriteLine("interestammount is {8}:");
                Console.WriteLine("feeammount is {9}:");
                Console.WriteLine("feechargedpertransaction is {10}");
            }
        }



    }
}