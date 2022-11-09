using System;
using System.Collections.Generic;

namespace A_Work_3_ATM
{
    class CardTransaction : Card
    {
        private static int wallet = 10_000;
        private readonly List<int> transactionsMade = new List<int>();

        public static int GetWallet()
        {
            return wallet;
        }

        public void Transaction()
        {
            short choose, exit = 0;

            Console.WriteLine("--- Choose from the menu below ---");
            Console.WriteLine("1. Money withdrawal - limit of $1_000.");
            Console.WriteLine("2. Cash availability.");
            Console.WriteLine("3. Check previous transactions.");
            Console.WriteLine("4. User info.");
            Console.WriteLine("5. FAST cash withdraw.");
            Console.WriteLine("0. Exit");
            Console.Write("Enter: ");
            choose = short.Parse(Console.ReadLine());

            if (choose == 1)
            {
                MoneyWithdrawal();
            }
            else if (choose == 2)
            {
                WalletCheck();
            }
            else if (choose == 3)
            {
                PreviousTransactions();
            }
            else if (choose == 0)
            {
                Environment.Exit(exit);
            }
            else if (choose == 4)
            {
                CallUserInfo();
            }
            else if(choose == 5)
            {
                FastMoneyWithdrawal();
            }
        }

        private void MoneyWithdrawal()
        {
            int chooseMoney;
            int limit = 1_000;

            Console.WriteLine("Withdrawal amount up to $1_000");
            Console.WriteLine("Go Back = 0");
            Console.Write("Enter anount: ");
            chooseMoney = int.Parse(Console.ReadLine());

            if (chooseMoney == 0)
            {
                Transaction();
            }
            if (chooseMoney <= limit)
            {
                wallet -= chooseMoney;
                Console.WriteLine(" - " + chooseMoney + " = " + wallet);
                transactionsMade.Add(wallet);
                Transaction();
            }
            else
            {
                Console.WriteLine("No such value!\nTry again.");
                MoneyWithdrawal();
            }
        }

        private void WalletCheck()
        {
            Console.WriteLine();
            Console.WriteLine("Your wallet has - $" + wallet);
            transactionsMade.Add(wallet);
            Console.WriteLine();
            Transaction();
        }

        private void PreviousTransactions()
        {
            Console.WriteLine();
            transactionsMade.ForEach(el => Console.WriteLine("$" + el));
            Console.WriteLine();
            Transaction();
        }

        private void CallUserInfo()
        {
            Console.WriteLine();
            UserInfo userinfo = new UserInfo();
            userinfo.UsersInfo();
        }

        private void FastMoneyWithdrawal()
        {
            int chooseFastMoney;

            Console.WriteLine("Withdrawal $20");
            Console.WriteLine("Withdrawal $50");
            Console.WriteLine("Withdrawal $1000");
            Console.WriteLine("Go Back = 0");
            Console.Write("Enter anount: ");
            chooseFastMoney = int.Parse(Console.ReadLine());

            if (chooseFastMoney == 0)
            {
                Transaction();
            }
            if (chooseFastMoney == 20)
            {
                wallet -= chooseFastMoney;
                Console.WriteLine(" - " + chooseFastMoney + " = " + wallet);
                transactionsMade.Add(wallet);
                Transaction();
            }
            else if (chooseFastMoney == 50)
            {
                wallet -= chooseFastMoney;
                Console.WriteLine(" - " + chooseFastMoney + " = " + wallet);
                transactionsMade.Add(wallet);
                Transaction();
            }
            else if (chooseFastMoney == 1_000)
            {
                wallet -= chooseFastMoney;
                Console.WriteLine(" - " + chooseFastMoney + " = " + wallet);
                transactionsMade.Add(wallet);
                Transaction();
            }
            else
            {
                Console.WriteLine("No such value! ");
                FastMoneyWithdrawal();
            }
        }

        // TODO end
    }
}
