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

            try
            {
                int[] displayArray = Populate(userArray);
                int displaySum = GetSum(displayArray);
               
            }
            catch (FormatException fe)
            {
                Console.WriteLine(fe.Message);
            }
            catch (OverflowException oe)
            {
                Console.WriteLine(oe.Message);
            }

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

        static int GetSum(int[] arr)
        {
            int sum = 0;

            foreach (int number in arr)
            {
                sum += number;
            }

            if(sum < 20)
            {
                throw (new Exception($"Value of {sum} is too low."));
            }

            return sum;
        }

        //static int GetProduct(int[] arr, int sum)
        //{

        //}

        //static decimal GetQuotient(int product)
        //{

        //}

    }
}
