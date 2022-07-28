using System;

namespace chapterFour
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------Question one--------------");
            //Write a program that reads from the console three numbers of type int and prints their sum.
            Console.WriteLine("Enter 1st number");
            int num1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 2nd number");
            int num2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter 3rd number");
            int num3 = int.Parse(Console.ReadLine());
            Console.WriteLine($"The sum of the numbers are  {num1 + num2 + num3}");
            Console.WriteLine();

            Console.WriteLine("-------------Question Two--------------");
            //Write a program that reads from the console the radius "r" of a circle and prints its perimeter and area.
            Console.WriteLine("Enter the number");
            int radiusnum = int.Parse(Console.ReadLine());
            double radiusnums = 2 * Math.PI * radiusnum;
            double area = Math.PI * radiusnum * radiusnum;
            Console.WriteLine($"The perimeter is {radiusnums} and the radius is {area}");
            Console.WriteLine();

            Console.WriteLine("-------------Question Three--------------");

            //A given company has name, address, phone number, fax number, web site and manager. The manager has name, surname and phone number.
            //Write a program that reads information about the company and its manager and then prints it on the console.
             Console.Write("Enter company name: ");
            string compName = Console.ReadLine();
            Console.Write("Enter company address: ");
            string compAddr = Console.ReadLine();
            Console.Write("Enter company phone number: ");
            string compPhone = Console.ReadLine();
            Console.Write("Enter company fax: ");
            string compFax = Console.ReadLine();
            Console.Write("Enter company website: ");
            string compSite = Console.ReadLine();
            Console.Write("Enter company manager: ");
            string compManager = Console.ReadLine();
            Console.Write("Enter manager first name: ");
            string managerFName = Console.ReadLine();
            Console.Write("Enter manager last name: ");
            string managerLName = Console.ReadLine();
            Console.Write("Enter manager phone: ");
            string managerPhone = Console.ReadLine();

            Console.WriteLine("Firm: Name - {0}, Address - {1}, Number - {2}, Fax - {3}, Website - {4}, Manager - {5}", compName, compAddr, compPhone, compFax, compSite, compManager);
            Console.WriteLine("Manager: Name - {0} {1}, Phone - {2}", managerFName, managerLName, managerPhone);
            Console.WriteLine();
            
            Console.WriteLine("-------------Question four--------------");
           // Write a program that prints three numbers in three virtual columns on the console. Each column should have a width of 10 characters and
           //the numbers should be left aligned. The first number should be an integer in hexadecimal; the second should be fractional positive; and
           //the third – a negative fraction. The last two numbers have to be rounded to the second decimal place.

           int hexNum = 2015;
           Console.WriteLine("|0x{0,-8:X|", hexNum);
           double fractNum = -1.856;
           Console.WriteLine("|0,-10:f2}|", fractNum);
           Console.WriteLine();

           Console.WriteLine("-------------Question five--------------");
            //Write a program that reads from the console two integer numbers (int) and prints how many numbers between them exist, such that the
            //remainder of their division by 5 is 0. Example: in the range (14, 25) there are 3 such numbers: 15, 20 and 25.
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
    
            for (int i = a; i <= b; 
            i++)
           {
             f (i % 5 == 0) counter++;
           }
    
           Console.WriteLine("{0} numbers found.", counter);
           Console.WriteLine();

           Console.WriteLine("-------------Question six--------------");
          //Write a program that reads two numbers from the console and prints the greater of them. Solve the problem without using conditional  statements.
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
    
            Console.WriteLine("{0} >= {1}", Math.Max(a, b), Math.Min(a, b)); 
            Console.WriteLine();

            Console.WriteLine("-------------Question seven--------------");
           //Write a program that reads five integer numbers and prints their sum. 
           //If an invalid number is entered the program should prompt the user to enter another number.
            int a, b, c, d, e;
            bool parseSucceed = false;

            do
            {
                Console.Write("Enter first number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out a);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter second number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out b);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter third number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out c);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fourth number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out d);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);

            do
            {
                Console.Write("Enter fifth number");
                parseSucceed = Int32.TryParse(Console.ReadLine(), out e);
                Console.WriteLine(parseSucceed);
            } while (!parseSucceed);
            Console.WriteLine();

            Console.WriteLine("-------------Question eight--------------");
            //Write a program that reads five numbers from the console and prints the greatest of them.
            Console.Write("Enter first number");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number");
            int e = Int32.Parse(Console.ReadLine());

            if (a > b && a > c && a > d && a > e) Console.WriteLine("{0} is the biggest.", a);
            else if (b > a && b > c && b > d && b > e) Console.WriteLine("{0} is the biggest.", b);
            else if (c > a && c > b && c > d && c > e) Console.WriteLine("{0} is the biggest.", c);
            else if (d > a && d > b && d > c && d > e) Console.WriteLine("{0} is the biggest.", d);
            else if (e > a && e > b && e > c && e > d) Console.WriteLine("{0} is the biggest.", e);
            else Console.WriteLine("There isn't a biggest number.");
            Console.WriteLine();

            Console.WriteLine("-------------Question nine--------------");
           // Write a program that reads an integer number n from the console. After that reads n numbers from the console and prints their sum.
               int sum = 0;
    
           Console.Write("Enter numbers count: ");
           int length = Int32.Parse(Console.ReadLine());
    
           for (int i = 0; i < length; i++)
           {
             Console.Write("Enter {0} number: ", i + 1);
             sum += Int32.Parse(Console.ReadLine());
           }
    
           Console.WriteLine("Sum of all numbers is {0}.", sum);
           Console.WriteLine();

           Console.WriteLine("-------------Question Ten--------------");
           //Write a program that reads an integer number n from the console and prints all numbers in the range [1…n], each on a separate line.
           int sum = 0;
    
            Console.Write("Enter number: ");
            int length = Int32.Parse(Console.ReadLine());
    
            for (int i = 1; i <= length; i++)
           {
             Console.WriteLine(i);
           }
            Console.WriteLine();

           Console.WriteLine("-------------Question Eleven--------------");
           //Write a program that prints on the console the first 100 numbers in the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, …

            int num1 = 0, num2 = 1, nextNumber,Number = 101;

            Console.Write($"{num1 + " " + num2},");
            for (int a = 2; a < Number; a++)
            {
                nextNumber = num1 + num2;
                Console.Write($"{nextNumber},");
                num1 = num2;
                num2 = nextNumber;

            }
            Console.WriteLine();
           Console.WriteLine("-------------Question Twelve--------------");
            //Write a program that calculates the sum (with precision of 0.001) of the following sequence: 1 + 1/2 - 1/3 + 1/4 - 1/5 + …
             int sum = 1+ 1/2- 1/3+ 1/4 -1/5;
              Console.WriteLine($"{sum}");

            Console.WriteLine();

           

            

        
            

            
        }
    }
}
