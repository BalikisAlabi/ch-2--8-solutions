using System;

namespace chapterFive
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("------------Question One---------");
            //Write an if-statement that takes two integer variables and exchanges their values if the first one is greater than the second one.
            int intOne = 10;
            int intTwo = 2;
            int intThird = intOne;
            if (intTwo < intOne)
            {
                intOne = intTwo;
                intTwo = intThird;
                intThird = intTwo;
                Console.WriteLine($"{intOne}");
            }

                 Console.WriteLine("------------Question Two---------");
            //Write a program that shows the sign (+ or -) of the product of three real numbers, without calculating it. Use a sequence of if operators.
            Console.WriteLine("Enter three numbers");
            int a = int.Parse(Console.ReadLine());
            int b = int.Parse(Console.ReadLine());
            int c = int.Parse(Console.ReadLine());

            if ((a < 0 && b > 0 && c > 0) || (b < 0 && a > 0 && c > 0) || (c < 0 && a > 0 && b > 0) || (a < 0 && b < 0 && c < 0))
        {
            Console.WriteLine("-");
        }
        else if ((a < 0 && b < 0 && c > 0) || (a < 0 && c < 0 && b > 0) || (b < 0 && c < 0 && a > 0) || (a > 0 && b > 0 && c > 0))
        {
            Console.WriteLine("+");
        }
        else if (a == 0 || b == 0 || c == 0)
        {
            Console.WriteLine("0");
        }

        Console.WriteLine("------------Question Three---------");

        //Write a program that finds the biggest of three integers, using nested if statements.

        Console.WriteLine("Enter three numbers");
            int d = int.Parse(Console.ReadLine());
            int e = int.Parse(Console.ReadLine());
            int f = int.Parse(Console.ReadLine());
            
            if(d > e )
            {
                Console.WriteLine($"{d} is the greatest");

                if(f > d)
                {
                    Console.WriteLine($"{f} is the greatest");
                
                 if(e > d)
                  {
                    Console.WriteLine($"{e} is the greatest");
                  }
                }
            }

            Console.WriteLine("------------Question Four---------");
            //Sort 3 real numbers in descending order. Use nested if statements.
            int a = 1;
            int b = 2;
            int c = a;
           if (a < b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;

                    if (b > c)
                    {                        
                        a = a + b;
                        b = a - b;
                        a = a - b;
                    }
                }
                else if (a >= c)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            else if (a == b)
            {
                if (a < c)
                {
                    a = a + c;
                    c = a - c;
                    a = a - c;
                }
            }
            else
            {
                if (b < c)
                {
                    b = b + c;
                    c = b - c;
                    b = b - c;
                }
                if (a < b)
                {
                    a = a + b;
                    b = a - b;
                    a = a - b;
                }
            }
            Console.WriteLine("{0}, {1}, {2}", a, b, c);
            Console.ReadLine();

             Console.WriteLine("------------Question Five---------");
             // Write a program that asks for a digit (0-9), and depending on the input, shows the digit as a word (in English). Use a switch statement.
           Console.WriteLine("Enter the first number");
           int number = int.Parse(Console.ReadLine());
           
            switch (number)
            {
            case 0 :
                    Console.WriteLine("zero");
            break;
            case 1 :
                    Console.WriteLine("One");
            break;
            case 2 :
                    Console.WriteLine("Two");
            break;
            case 3 :
                    Console.WriteLine("Three");
            break;
            case 4 :
                    Console.WriteLine("Four");
            break;
            case 5 :
                    Console.WriteLine("Five");
            break;
            case 6 :
                    Console.WriteLine("Six");
            break;
            case 7 :
                    Console.WriteLine("Seven");
            break;
            case 8 :
                    Console.WriteLine("Eight");
            break;
            case 9 :
                    Console.WriteLine("Nine");
            break;
            default:
                    Console.WriteLine("Wrong input");
            break;
            }
            Console.ReadLine();
            
             Console.WriteLine("------------Question Six---------");

            //Write a program that gets the coefficients a, b and c of a quadratic  equation: ax2 + bx + c,
            //calculates and prints its real roots (if they exist).  Quadratic equations may have 0, 1 or 2 real roots.
            Console.Write("Input A : ");
            double a = double.Parse(Console.ReadLine());
            Console.Write("Input B: ");
            double b = double.Parse(Console.ReadLine());
            Console.Write("Input C: ");
            double c =double.Parse(Console.ReadLine());
            double d = (double)(b * b - 4 * a * c);
            if (d < 0)
                Console.WriteLine("D={0}, There are no real roots.", d);
            else if (d == 0)
            {
                double x1 = (double)(-b / 2 * a);
                Console.WriteLine(" X = {0}", x1);
            }
            else
            {
               double x1 = (double)((-b + Math.Sqrt(d)) / (2 * a));
               double x2 = (double)((-b - Math.Sqrt(d)) / (2 * a));
               Console.WriteLine("X1={0} X2= {1}", x1, x2);
            }
            Console.ReadLine();

            Console.WriteLine("------------Question Seven---------");

            //Write a program that finds the greatest of given 5 numbers.
            Console.Write("Enter first number: ");
            int a = Int32.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int b = Int32.Parse(Console.ReadLine());
            Console.Write("Enter third number: ");
            int c = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            int d = Int32.Parse(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            int e = Int32.Parse(Console.ReadLine());
            
            if (a < b && b < c)
           {
             Console.WriteLine($"The greatest number is {c}");
           }
            if (b < a && c < a)
            {
                Console.WriteLine($"The greatest number is {a} ");
            }
            if (c < b && a < b)
            {
                Console.WriteLine($"The greatest number is {b} ");            
            }
                    
              
           Console.ReadLine();

           Console.WriteLine("------------Question Eight---------");
                
           // Write a program that, depending on the user’s choice, inputs int, double or string variable. If the variable is int or double, the program
           // increases it by 1. If the variable is a string, the program appends "*" at  the end. Print the result at the console. Use switch statement.
           Console.Write("Enter variable type (0 for int, 1 for double, 2 for string : 0, 1 or 2): ");
            int inputs = int.Parse(Console.ReadLine());

            switch (inputs)
            {
                case 0:
                    {
                        Console.Write("Enter a variable: ");
                        inputs= int.Parse(Console.ReadLine());
                        inputs++;
                        Console.WriteLine("Int variable +1 = {0}", inputs);
                        break;
                    }
                case 1:
                    {
                        Console.Write("Enter  a double variable: ");
                        double doubleVar = double.Parse(Console.ReadLine());
                        doubleVar++;
                        Console.WriteLine("Double variable +1 = {0}", doubleVar);
                        break;
                    }
                case 2:
                    {
                        Console.Write("Enter string variable: ");
                        string Vary = Console.ReadLine();
                        Vary = Vary + '*';
                        Console.WriteLine("String variable = {0}", Vary);
                        break;
                    }
                default:
                 Console.WriteLine("Wrong input"); break;
            }

            Console.WriteLine("------------Question Nine---------");
           // We are given 5 integer numbers. Write a program that finds those subsets whose sum is 0. Examples:         
           // - If we are given the numbers {3, -2, 1, 1, 8}, the sum of -2, 1 and 1 is 0.        
           // - If we are given the numbers {3, 1, -7, 35, 22}, there are no subsets  with sum 0.


            Console.Write("Enter first number: ");
            sbyte first = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter second number: ");
            sbyte second = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter third number: ");
            sbyte third = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fourth number: ");
            sbyte fourth = Convert.ToSByte(Console.ReadLine());
            Console.Write("Enter fifth number: ");
            sbyte fifth = Convert.ToSByte(Console.ReadLine());

            if(first + second == 0)
                Console.WriteLine("{0}+ {1} = 0", first, second);
            if (first + third == 0)
                Console.WriteLine("{0}+ {1} = 0", first, third);
            if (first + fourth == 0)
                Console.WriteLine("{0}+ {1} = 0", first, fourth);
            if (first + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", first, fifth);
            if (second + third == 0)
                Console.WriteLine("{0}+ {1} = 0", second, third);
            if (second + fourth == 0)
                Console.WriteLine("{0}+ {1} = 0", second, fourth);
            if (second + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", second, fifth);
            if (third + fourth == 0)
                Console.WriteLine("{0}+ {1} = 0", third, fourth);
            if (third + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", third, fifth);
            if (fourth + fifth == 0)
                Console.WriteLine("{0}+ {1} = 0", fourth, fifth);
            if (first + second + third == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, third);
            if (first + second + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fourth);
            if (first + second + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, second, fifth);
            if (first + third + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fourth);
            if (first + third + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", first, third, fifth);
            if (second + third + fourth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fourth);
            if (second + third + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", second, third, fifth);
            if (third + fourth + fifth == 0)
                Console.WriteLine("{0}+ {1}+ {2} = 0", third, fourth, fifth);

            Console.ReadLine();

            Console.WriteLine("------------Question Ten---------");
          /* Write a program that applies bonus points to given scores in the range [1…9] by the following rules:
            - If the score is between 1 and 3, the program multiplies it by 10.
            - If the score is between 4 and 6, the program multiplies it by 100.
            - If the score is between 7 and 9, the program multiplies it by 1000.
            - If the score is 0 or more than 9, the program prints an error
            message.*/
            Console.Write("Enter points between 1 and 9: ");
            byte points = Convert.ToByte(Console.ReadLine());
            if (points >= 1 && points <= 3)
                {
                    Console.WriteLine($"points mmultiplied by 10 = {points * 10}");
                }
            else if (points >= 4 && points <= 6)
                {
                    Console.WriteLine($"points mmultiplied by 100 = {points * 100}");
                }
            else if (points >= 7 && points <= 9)
                { 
                    Console.WriteLine($"points mmultiplied by 1000 = {points * 1000}");
                }
            else
                     Console.WriteLine("Wrong Input!");
                
            Console.ReadLine();


             Console.WriteLine("------------Question Eleven---------");

           /* Write a program that converts a number in the range [0…999] to words, corresponding to the English pronunciation. Examples:                  
            - 0 --> "Zero"
            - 12 --> "Twelve"
            - 98 --> "Ninety eight"
            - 273 --> "Two hundred seventy three"
            - 400 --> "Four hundred"
            - 501 --> "Five hundred and one"
            - 711 --> "Seven hundred and eleven"*/
            Console.Write("Enter a number between 0 and 999: ");
            short number = Convert.ToInt16(Console.ReadLine());

            byte hundreds = (byte)(number / 100 | 0);
            byte tensAndOnes;

            if (number > 99) tensAndOnes = (byte)(number % 100);
            else tensAndOnes = (byte)(number * 1);

            byte ones = (byte)(number % 10);

            switch (hundreds)
            {
                case 1: Console.Write("One hundred "); break;
                case 2: Console.Write("Two hundred "); break;
                case 3: Console.Write("Three hundred "); break;
                case 4: Console.Write("Four hundred "); break;
                case 5: Console.Write("Five hundred "); break;
                case 6: Console.Write("Six hundred "); break;
                case 7: Console.Write("Seven hundred "); break;
                case 8: Console.Write("Eight hundred "); break;
                case 9: Console.Write("Nine hundred "); break;
            }

            if (hundreds >= 1 && tensAndOnes >= 1) Console.Write("and ");

            if (tensAndOnes >= 20 && tensAndOnes < 30) Console.Write("Twenty");
            else if (tensAndOnes >= 30 && tensAndOnes < 40) Console.Write("Thirty");
            else if (tensAndOnes >= 40 && tensAndOnes < 50) Console.Write("Fourty");
            else if (tensAndOnes >= 50 && tensAndOnes < 60) Console.Write("Fifty");
            else if (tensAndOnes >= 60 && tensAndOnes < 70) Console.Write("Sixty");
            else if (tensAndOnes >= 70 && tensAndOnes < 80) Console.Write("Seventy");
            else if (tensAndOnes >= 80 && tensAndOnes < 90) Console.Write("Eighty");
            else if (tensAndOnes >= 90 && tensAndOnes < 100) Console.Write("Ninety");

            switch(tensAndOnes)
            {
                case 1: Console.Write("One"); break;
                case 2: Console.Write("Two"); break;
                case 3: Console.Write("Three"); break;
                case 4: Console.Write("Four"); break;
                case 5: Console.Write("Five"); break;
                case 6: Console.Write("Six"); break;
                case 7: Console.Write("Seven"); break;
                case 8: Console.Write("Eight"); break;
                case 9: Console.Write("Nine"); break;
                case 10: Console.Write("Ten"); break;
                case 11: Console.Write("Eleven"); break;
                case 12: Console.Write("Twelve"); break;
                case 13: Console.Write("Thirteen"); break;
                case 14: Console.Write("Fourteen"); break;
                case 15: Console.Write("Fifteen"); break;
                case 16: Console.Write("Sixteen"); break;
                case 17: Console.Write("Seventeen"); break;
                case 18: Console.Write("Eighteen"); break;
                case 19: Console.Write("Nineteen"); break;                
            }
            if (tensAndOnes > 20)
            {
                switch (ones)
                {
                    case 1: Console.Write("-one"); break;
                    case 2: Console.Write("-two"); break;
                    case 3: Console.Write("-three"); break;
                    case 4: Console.Write("-four"); break;
                    case 5: Console.Write("-five"); break;
                    case 6: Console.Write("-six"); break;
                    case 7: Console.Write("-seven"); break;
                    case 8: Console.Write("-eight"); break;
                    case 9: Console.Write("-nine"); break;
                }
            }
	        if (number == 0) Console.Write("Zero");
            Console.ReadLine();




        }
    }
}
