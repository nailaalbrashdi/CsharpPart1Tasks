namespace CsharpPart1Tasks
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to our system");
            Console.WriteLine("Choose a service you need");
            Console.WriteLine("1.Find the Average");
            Console.WriteLine("2.Check if a Number is Even or Odd");
            Console.WriteLine("3.Find the Smallest Number in a List");



            Console.WriteLine("Enter how many numbers you need :");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n]; //allocating array of size n
            for (int i = 0; i < n; i++)
            {
                Console.WriteLine("Enter number : ");
                numbers[i] = int.Parse(Console.ReadLine());
            }
            int total = 0;
            for (int i = 0; i < n; i++)
            {
                total += numbers[i];
            }
            float average = (float)total / n;
            Console.WriteLine("The average is: " + average);


            Console.WriteLine("Enter a number:");
            int number1 = int.Parse(Console.ReadLine());
            if (number1 % 2 == 0)
            {
                Console.WriteLine("The number is Even");
            }
            else
            {
                Console.WriteLine("The number is Odd");
            }


            Console.WriteLine("Enter how many numbers you need:");
            int n1 = int.Parse(Console.ReadLine());
            int[] numbers1 = new int[n1];
            // read first number and assume it is the smallest
            Console.Write("Enter number 0: ");
            numbers1[0] = int.Parse(Console.ReadLine());
            int smallest = numbers1[0];

            // read remaining numbers
            for (int i = 1; i < n1; i++)
            {
                Console.Write("Enter number " + i + ": ");
                numbers1[i] = int.Parse(Console.ReadLine());

                if (numbers1[i] < smallest)
                {
                    smallest = numbers1[i];
                }
            }

            Console.WriteLine("The smallest number is: " + smallest);





        }

    }
}
