namespace C__final_task
{
    internal class Program
    {
        static double balance = 1000.00;
        static void Main(string[] args)
        {
            /* 1-Create a C# application calculates the sum of the two provided integer values and 
            returns triple of the sum of the two numbers if they are equal. */

            //Console.Write("Enter the first integer: ");
            //int num1 = Convert.ToInt32(Console.ReadLine()); 
            //Console.Write("Enter the second integer: ");
            //int num2 = Convert.ToInt32(Console.ReadLine()); 

            //int sum = num1 + num2;
            //if (num1 == num2)
            //{
            //    sum *= 3; 
            //}
            //Console.WriteLine($"Result: {sum}");


            /* 2-Create a C# program to check a student's eligibility for voting by taking into 
             consideration the student's age to be greater than 18.*/

            //Console.Write("Enter your age: ");
            //string input = Console.ReadLine();
            //int age = Convert.ToInt32(input);

            //if (age > 18)
            //{
            //    Console.WriteLine("Eligible to vote.");
            //}
            //else
            //{
            //    Console.WriteLine("Not eligible to vote.");
            //}





            /*Create a C# program that will receive a coordinate point as (x,y) and display the 
             quadrant it is in.*/


            //Console.Write("Enter x coordinate: ");
            //int x = int.Parse(Console.ReadLine());
            //Console.Write("Enter y coordinate: ");
            //int y = int.Parse(Console.ReadLine());

            //if (x > 0 && y > 0)
            //    Console.WriteLine("Quadrant: I");
            //else if (x < 0 && y > 0)
            //    Console.WriteLine("Quadrant: II");
            //else if (x < 0 && y < 0)
            //    Console.WriteLine("Quadrant: III");
            //else if (x > 0 && y < 0)
            //    Console.WriteLine("Quadrant: IV");
            //else
            //    Console.WriteLine("Point is on an axis or the origin.");


            /*Write a C# program asks user to input the laterals only for triangle and then display the 
              type of triangle if it is right, isosceles, or equilateral. */

            //Console.Write("Enter side a: ");
            //double a = double.Parse(Console.ReadLine());
            //Console.Write("Enter side b: ");
            //double b = double.Parse(Console.ReadLine());
            //Console.Write("Enter side c: ");
            //double c = double.Parse(Console.ReadLine());

            //if (a == b && b == c)
            //{
            //    Console.WriteLine("Equilateral Triangle");
            //}
            //else if (a == b || a == c || b == c)
            //{
            //    Console.WriteLine("Isosceles Triangle");
            //}
            //else
            //{
            //    Console.WriteLine("Scalene Triangle");
            //}



            /* Create a C# program to compute and print customer's electricity bill. The entire amount 
                to be paid to is calculated based on units consumed by the client which will be extracted 
                from keyboard. The fees are as shown in table below and note that 10% will be added as 
                surcharge if units consumed exceed 600 watts. */

            //Console.Write("Enter units consumed: ");
            //int units = int.Parse(Console.ReadLine());
            //double bill = 0;

            //if (units < 300)
            //    bill = units * 1.5;
            //else if (units < 450)
            //    bill = units * 2;
            //else
            //    bill = units * 2.5;

            //if (units > 600)
            //    bill *= 1.1; 

            //Console.WriteLine("Total Bill: $" + bill);



            /*Exercise 2: 
                Create a Bank System for ATM enables clients to Deposit, Withdraw and Check their balance 
                considering all validations may occur on user inputs such as (valid value, greater than zero and 
                less than balance, etc.…) . 
                Note: Make sure the menu will appear on screen till the client enters exit or similar.   */





            //        bool exit = false;

            //        while (!exit)
            //        {
            //            Console.WriteLine("\nATM Menu:");
            //            Console.WriteLine("1. Deposit");
            //            Console.WriteLine("2. Withdraw");
            //            Console.WriteLine("3. Check Balance");
            //            Console.WriteLine("4. Exit");

            //            Console.Write("Choose an option: ");
            //            int choice = int.Parse(Console.ReadLine());

            //            switch (choice)
            //            {
            //                case 1:
            //                    Deposit();
            //                    break;
            //                case 2:
            //                    Withdraw();
            //                    break;
            //                case 3:
            //                    CheckBalance();
            //                    break;
            //                case 4:
            //                    exit = true;
            //                    break;
            //                default:
            //                    Console.WriteLine("Invalid choice, try again.");
            //                    break;
            //            }
            //        }
            //    }

            //    static void Deposit()
            //    {
            //        Console.Write("Enter deposit amount: ");
            //        double amount = double.Parse(Console.ReadLine());

            //        if (amount > 0)
            //        {
            //            balance += amount;
            //            Console.WriteLine("Deposit successful.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Amount must be greater than zero.");
            //        }
            //    }

            //    static void Withdraw()
            //    {
            //        Console.Write("Enter withdrawal amount: ");
            //        double amount = double.Parse(Console.ReadLine());

            //        if (amount > 0 && amount <= balance)
            //        {
            //            balance -= amount;
            //            Console.WriteLine("Withdrawal successful.");
            //        }
            //        else
            //        {
            //            Console.WriteLine("Invalid amount. Please enter a valid amount within your balance.");
            //        }
            //    }

            //    static void CheckBalance()
            //    {
            //        Console.WriteLine("Current Balance: $" + balance);
            //        }



            /*Exercise 3: 
                    Create a program for taking the number of students dynamically at a class with their grades 
                    from the teacher and then show the minimum mark, maximum mark and the average one. Plus, 
                    how many students are above the Average and how much below Average.*/

            Console.Write("Enter number of students: ");
            int n = int.Parse(Console.ReadLine());
            int[] grades = new int[n];
            int total = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write($"Enter grade for student {i + 1}: ");
                grades[i] = int.Parse(Console.ReadLine());
                total += grades[i];
            }

            double average = total / (double)n;
            int aboveAverage = 0, belowAverage = 0;

            foreach (var grade in grades)
            {
                if (grade > average) aboveAverage++;
                else if (grade < average) belowAverage++;
            }

            Console.WriteLine($"Minimum Grade: {grades.Min()}");
            Console.WriteLine($"Maximum Grade: {grades.Max()}");
            Console.WriteLine($"Average Grade: {average}");
            Console.WriteLine($"Students Above Average: {aboveAverage}");
            Console.WriteLine($"Students Below Average: {belowAverage}");

        }
        }

    } 
