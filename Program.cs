using System;

namespace A_Work_3_ATM
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to ATM Bank services!\n...");

            UserVerification user = new UserVerification();
            user.Vrification();

            Console.ReadKey();
        }
    }
}