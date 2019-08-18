using System;
using ExercicioExcption.Entities;
using ExercicioExcption.Entities.Exceptions;

namespace ExercicioExcption
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter account data");
                Console.Write("Number: ");
                int number = int.Parse(Console.ReadLine());
                Console.Write("Holder: ");
                string holder = Console.ReadLine();
                Console.Write("Initial balance: ");
                double initialBalance = double.Parse(Console.ReadLine());
                Console.Write("Withdraw limit: ");
                double wdLimit = double.Parse(Console.ReadLine());

                Account account = new Account(number, holder, initialBalance, wdLimit);

                Console.WriteLine();
                Console.Write("Enter amount for withdraw: ");
                double withdraw = double.Parse(Console.ReadLine());
                account.WithDraw(withdraw);
                Console.WriteLine("New balance: $ " + account.Balance.ToString("F2"));
            }
            catch (AccountException e)
            {
                Console.WriteLine("Withdraw error: " + e.Message);
            }
        }
    }
}
