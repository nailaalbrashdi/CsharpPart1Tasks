namespace CsharpPart1Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our system");
            //    Console.WriteLine("Choose a service you need");
            //    Console.WriteLine("1.Find the Average");
            //    Console.WriteLine("2.Check if a Number is Even or Odd");
            //    Console.WriteLine("3.Find the Smallest Number in a List");
            //    Console.WriteLine("4.Count Positive and Negative Numbers");
            //    Console.WriteLine("5.Remove Duplicates from a List");



            //    Console.WriteLine("Enter how many numbers you need :");
            //    int n = int.Parse(Console.ReadLine());
            //    int[] numbers = new int[n]; //allocating array of size n
            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.WriteLine("Enter number : ");
            //        numbers[i] = int.Parse(Console.ReadLine());
            //    }
            //    int total = 0;
            //    for (int i = 0; i < n; i++)
            //    {
            //        total += numbers[i];
            //    }
            //    float average = (float)total / n;
            //    Console.WriteLine("The average is: " + average);


            //    Console.WriteLine("Enter a number:");
            //    int number1 = int.Parse(Console.ReadLine());
            //    if (number1 % 2 == 0)
            //    {
            //        Console.WriteLine("The number is Even");
            //    }
            //    else
            //    {
            //        Console.WriteLine("The number is Odd");
            //    }


            //    Console.WriteLine("Enter how many numbers you need:");
            //    int n1 = int.Parse(Console.ReadLine());
            //    int[] numbers1 = new int[n1];
            //    // read first number and assume it is the smallest
            //    Console.Write("Enter number 0: ");
            //    numbers1[0] = int.Parse(Console.ReadLine());
            //    int smallest = numbers1[0];

            //    // read remaining numbers
            //    for (int i = 1; i < n1; i++)
            //    {
            //        Console.Write("Enter number " + i + ": ");
            //        numbers1[i] = int.Parse(Console.ReadLine());

            //        if (numbers1[i] < smallest)
            //        {
            //            smallest = numbers1[i];
            //        }
            //    }

            //    Console.WriteLine("The smallest number is: " + smallest);



            //    Console.WriteLine("How many numbers you need:");
            //    int n2 = int.Parse(Console.ReadLine());

            //    int positiveCount = 0;
            //    int negativeCount = 0;

            //    for (int i = 0; i < n; i++)
            //    {
            //        Console.Write("Enter number " + (i + 1) + ": ");
            //        int num = int.Parse(Console.ReadLine());

            //        if (num > 0)
            //        {
            //            positiveCount++;
            //        }
            //        else if (num < 0)
            //        {
            //            negativeCount++;
            //        }
            //        // Zero is ignored
            //    }

            //    Console.WriteLine("Positive numbers: " + positiveCount);
            //    Console.WriteLine("Negative numbers: " + negativeCount);

            Console.WriteLine("How many numbers will you enter?");
            int n = int.Parse(Console.ReadLine());

            List<int> numbers = new List<int>();
            List<int> unique = new List<int>();

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter number: ");
                int num = int.Parse(Console.ReadLine());
                numbers.Add(num);
            }

            // Remove duplicates
            for (int i = 0; i < numbers.Count; i++)
            {
                if (!unique.Contains(numbers[i]))
                {
                    unique.Add(numbers[i]);
                }
            }

            // Output unique values
            Console.WriteLine("List without duplicates:");
            for (int i = 0; i < unique.Count; i++)
            {
                Console.Write(unique[i] + " ");
            }















        }



    }
    }

