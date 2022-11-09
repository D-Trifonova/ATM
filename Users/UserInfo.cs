using System;

namespace A_Work_3_ATM
{
    class UserInfo : User
    {

        private string phoneNum      = "0893123456"; // user's info
        private readonly string name = "Ivan G. Ivanov";
        private readonly int wallets = CardTransaction.GetWallet();

        public static string newPIN; // change
        public static string newPN;

        public void UsersInfo() // user info
        {
            Console.WriteLine();
            Console.WriteLine("--- User's information ---");
            Console.WriteLine("Name: " + name + "\nPhone number: " + phoneNum);
            Console.WriteLine("Wallet amount $" + wallets);

            Change();
        }

        private void Change()
        {
            CardTransaction cardTransaction = new CardTransaction();

            Console.Write("Change Phone Number (Y/N)? ");
            string phoneNumChange = Console.ReadLine();
            phoneNumChange        = phoneNumChange.ToLower();

            if (phoneNumChange.Equals("y"))
            {
                MenuPhoneNum();
            }

            Console.Write("Change PIN (Y/N)? ");
            string pinChange = Console.ReadLine();
            pinChange        = pinChange.ToLower();

            if (pinChange.Equals("y"))
            {
                MenuPIN();
            }
            else
            {
                cardTransaction.Transaction();
            }
        }

        private void MenuPhoneNum()
        {
            Console.Write("Enter new Phone Number: ");
            newPN = Console.ReadLine();
            phoneNum = newPN;

            Console.WriteLine("Your new Phone Number is " + newPN);
            UsersInfo();
        }

        private void MenuPIN()
        {
            User user = new User();
            string userOldPin = user.PIN;

            Console.Write("Enter new PIN: ");
            newPIN = Console.ReadLine();
            userOldPin = newPIN;

            Console.WriteLine("Your new PIN is " + newPIN);
            UsersInfo();
        }

        // TODO end
    }
}