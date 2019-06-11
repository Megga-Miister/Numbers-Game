using System;

namespace Numbers_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my game! Let's do some math!");

            try
            {
                StartSequence();
            }
            catch (Exception ge)
            {
                Console.WriteLine($"It looks like you have ran into an issue: {ge.Message}");
            }
            finally
            {
                Console.WriteLine("Program is complete.");
                Console.ReadKey();
            }
        }

        static void StartSequence()
        {

        }

        static int[] Populate(int[] arr)
        {

        }

        static int GetSum(int[] arr)
        {

        }

        static int GetProduct(int[] arr, int sum)
        {

        }

        static decimal GetQuotient(int product)
        {

        }

    }
}
