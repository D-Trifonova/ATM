using System;

namespace A_Work_3_ATM
{
    class Card : User
    {
        private readonly byte debit  = 10;
        private readonly byte credit = 20;

        public void Verifcation()
        {
            CardTransaction card = new CardTransaction();
            
            int exit    = 0;
            Random rnd  = new Random();
            int random  = rnd.Next(1, 21);

            if (random <= debit)
            {
                Console.WriteLine("You've entered a Debit card.");
                card.Transaction();
            }
            else if (random <= credit)
            {
                Console.WriteLine("You've entered a Credit card.");
                card.Transaction();
            }
            else
            {
                Console.WriteLine("Unidentified card.\nPlease, remove the card!");
                Console.ReadKey();
                Environment.Exit(exit);
            }
        }

        // TODO end
    }
}