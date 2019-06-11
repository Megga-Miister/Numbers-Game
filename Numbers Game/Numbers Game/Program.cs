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
            Console.WriteLine("Please enter a number greater than zero. Keep in mind you will have to enter this amount of numbers afterwards.");
            string userGivenString = Console.ReadLine();
            int givenNumber = Convert.ToInt32(userGivenString);

            int[] userArray = new int[givenNumber];

            Populate(userArray);
        }

        static int[] Populate(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine($"Please enter a number: {i + 1} out of {arr.Length}.");
                string arrString = Console.ReadLine();
                int arrNumber = Convert.ToInt32(arrString);

                arr[i] = arrNumber;
            }

            return arr;
        }

        //static int GetSum(int[] arr)
        //{

        //}

        //static int GetProduct(int[] arr, int sum)
        //{

        //}

        //static decimal GetQuotient(int product)
        //{

        //}

    }
}
