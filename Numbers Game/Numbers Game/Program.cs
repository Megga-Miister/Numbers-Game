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
                int displayProduct = GetProduct(displayArray,displaySum);
                decimal displayQuotient = GetQuotient(displayProduct);

                int multiplier = displayProduct / displaySum;
                decimal displayDivisor = displayProduct / displayQuotient;

                Console.WriteLine($"Your array size is: {displayArray.Length}");
                Console.WriteLine($"The numbers in the array are {String.Join(", ", displayArray)}");
                Console.WriteLine($"The sum of the array is {displaySum}");
                Console.WriteLine($"{displaySum} * {multiplier} = {displayProduct}");
                Console.WriteLine($"{displayProduct} / {displayDivisor} = {displayQuotient}");


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

        static int GetProduct(int[] arr, int sum)
        {
            Console.WriteLine($"Please select a random number between 1 and {arr.Length}.");
            string givenIndex = Console.ReadLine();
            int multiplier = Convert.ToInt32(givenIndex);

            try
            {
                int product = sum * arr[multiplier - 1];
                return product;
            }
            catch (IndexOutOfRangeException ioore)
            {
                Console.WriteLine(ioore.Message);
                throw; 
            }
        }

        static decimal GetQuotient(int product)
        {
            Console.WriteLine($"Please enter a number to divide your product {product} by.");
            string givenDivisor = Console.ReadLine();
            decimal dividend = Convert.ToDecimal(product);
            decimal divisor = Convert.ToDecimal(givenDivisor);

            try
            {
                decimal quotient = decimal.Divide(dividend, divisor);
                return quotient;
            }
            catch (DivideByZeroException dbze)
            {
                Console.WriteLine(dbze.Message);
                return 0;
            }
        }

    }
}
