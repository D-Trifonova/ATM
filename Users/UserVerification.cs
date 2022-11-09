using System;

namespace A_Work_3_ATM
{
    class UserVerification : User
    {
        public void Vrification() // user requrenments
        {
            byte exit = 0;

            User user = new User();
            string pin = user.PIN;
            string enterPin = user.enterPIN;
            byte wrongPin = user.wrongPIN;

            do
            {
                Console.Write("Enter PIN - ");
                enterPin = (Console.ReadLine());
                wrongPin++;
            } while (enterPin != pin && wrongPin < 5);

            if (wrongPin == 5)
            {
                Console.WriteLine("PIN have been entered wrong " + wrongPin + " times!\nCard is locked.\nCall a bank client service (1 84 84) within 24h to ulock it.");
                Console.WriteLine("Logging You out...");
                Console.ReadLine();
                Environment.Exit(exit);
            }
            else
            {
                Console.WriteLine("Accsess Gtranted!\nWelcome!");
                Card card = new Card();
                card.Verifcation();
            }
        }

        // TODO end
    }
}