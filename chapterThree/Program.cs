using System;

namespace chapterThree
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

           //Write an expression that checks whether an integer is odd or even.
            Console.WriteLine("-------------------------------Question 1----------------------------------");
            Console.WriteLine("=====\nWrite an expression that checks whether an integer is odd or even.\n=====\n");
            Console.Write("Enter the number: ");
            int number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number} is odd? {number % 2 != 0}");
            Console.WriteLine($"The number: {number} is even? {number % 2 == 0}");
            Console.WriteLine();

                  
            Console.WriteLine("-------Question 2-------");
            Console.WriteLine("=====\nWrite a Boolean expression that checks whether a\ngiven integer is divisible by both 5 and 7, without a remainder\n=====\n");
            Console.Write("Enter the number: ");
            int number2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine($"The number: {number2} is divisible by 5 and 7? {(number2 % 5 == 0) && (number2 % 7 == 0)}");
            Console.WriteLine();
            

             Console.WriteLine("-------Question 3-------");
            // Write an expression that looks for a given integer if its third digit (right  to left) is 7.
            int g = 12757;      
            Console.WriteLine($"The third integer is 7? {( (g/100) % 10  == 7)}");
            Console.WriteLine(); 

            
            Console.WriteLine("-------Question 4-------");  

            //Write an expression that checks whether the third bit in a given integer is 1 or 0.

            int nums = 1010101;
            Console.WriteLine($"Third bit is : {((nums/100) % 10 == 1)}");
            Console.WriteLine($"Third bit is : {((nums/100) % 10 == 0)}");
            Console.WriteLine();

            Console.WriteLine("-------Question 5-------"); 
           // Write an expression that calculates the area of a trapezoid by given sides a, b and height h. 
           int a0 = 3;
           int b0 = 7;
           int h0 = 9;
           Console.WriteLine((a0 + b0) / (2*h0));
           Console.WriteLine();

           Console.WriteLine("-------Question 6-------"); 
           //Write a program that prints on the console the perimeter and the area of a rectangle by given side and height entered by the user.
           
           Console.WriteLine("Enter your first number");
           int a = int.Parse(Console.ReadLine());
           Console.WriteLine("Enter your second number");
           int b = int.Parse(Console.ReadLine());
           Console.WriteLine("f = {0}, t= {1}", a * b, (a + b)*2);
           Console.WriteLine();

            Console.WriteLine("-------Question 7-------"); 
           //The gravitational field of the Moon is approximately 17% of that on the Earth. Write a program that calculates 
           //the weight of a man on the  moon by a given weight on the Earth.

           Console.WriteLine("Enter the weight of a man");
           int manWeight = int.Parse(Console.ReadLine());
           Console.WriteLine(" The weight of a man = {0}" , (manWeight * 0.17));
           Console.WriteLine();

           Console.WriteLine("-------Question 8-------"); 

           //Write an expression that checks for a given point {x, y} if it is within the circle K({0, 0}, R=5).
           //Explanation: the point {0, 0} is the center of the circle and 5 is the radius.   

          Console.Write("Enter x: ");
          int x = Convert.ToInt32(Console.ReadLine());
          Console.Write("Enter y: ");
          int y = Convert.ToInt32(Console.ReadLine());
          bool isInside = (x * + y * y <= 5) ? true : false;
          Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInside);
          Console.WriteLine();

          Console.WriteLine("-------Question 9-------"); 

          //Write an expression that checks for given point {x, y} if it is within the
          //circle K({0, 0}, R=5) and out of the rectangle [{-1, 1}, {5, 5}].
          //Clarification: for the rectangle the lower left and the upper right corners
          //are given.

            Console.Write("Enter x: ");
            int x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter y: ");
            int y = Convert.ToInt32(Console.ReadLine());
            bool isInsideCircle = (x * x + y * y <= 5) ? true : false;
            bool isOutsideRectangle = (x < -1 && x > 5 && y < 1 && y > 5) ? true : false;
            Console.WriteLine("The point O({0},{1}) is inside K((0,0),5)?: {2}", x, y, isInsideCircle);
            Console.WriteLine("The point O({0},{1}) is outside rectangle ((-1, 1), (5, 5)?: {2}", x, y, isOutsideRectangle);
            Console.WriteLine();


            Console.WriteLine("-------Question 10-------"); 
           // Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following actions:
           // - Calculates the sum of the digits (in our example 2+0+1+1 = 4).
            //- Prints on the console the number in reversed order: dcba (in our example 1102).
           // - Puts the last digit in the first position: dabc (in our example 1201).
           // - Exchanges the second and the third digits: acbd (in our example 2101).

            Console.Write("Enter number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            int a1 = num/1000;
            int a2 = (num/100) % 10;
            int a3 = (num/10) % 10;
            int a4 = num % 10;

            Console.WriteLine("sum of the numbers {0}", (a1 +a2 + a3 + a4));
            Console.WriteLine("reverse order of the numbers  {0}{1}{2}{3}", a1, a2, a3, a4);
            Console.WriteLine("Last digit in first position  {3}{0}{1}{2}", a1, a2, a3, a4);
            Console.WriteLine("Exchange of second and third digit {0}{2}{1}{3}", a1, a2, a3, a4);
            Console.WriteLine();

            Console.WriteLine("-------Question 11-------"); 
            //We are given a number n and a position p. Write a sequence of
            //operations that prints the value of the bit on the position p in the
            //number (0 or 1). Example: n=35, p=5 -> 1. Another example: n=35, p=6 -> 0.

            int n = 35; // 00100011
            int p = 6;
            int i = 1; // 00000001
            int mask = i << p; // Move the 1-st bit left by p positions
            // If i & mask are positive then the p-th bit of n is 1
            Console.WriteLine((n & mask) != 0 ? 1 : 0);  
            Console.WriteLine();

            Console.WriteLine("-------Question 12-------"); 
            //Write a Boolean expression that checks if the bit on position p in the integer v has the value 1. Example v=5, p=1 -> false.

            int N = 4;
            int P = 1;
            int I = 2;
            int Mask = I << p;
            Console.WriteLine((N & Mask) != 0 ? "P value is 0" : "P value is 1");   
            Console.WriteLine();

            Console.WriteLine("-------Question 13-------"); 
           //We are given the number n, the value v (v = 0 or 1) and the position p.
           // write a sequence of operations that changes the value of n, so the bit on
           // the position p has the value of v. Example: n=35, p=5, v=0 -> n=3. Another example: n=35, p=2, v=1 -> n=39.
            
            int n = 35;
            int p = 2;
            int v = 1;
            n =(v==0)?  n = n & (~(1 << p)) : n = n | (1 << p);
            Console.WriteLine(n);

            Console.WriteLine("-------Question 14-------");     
            //Write a program that checks if a given number n (1 < n < 100) is a prime number (i.e. it is divisible without remainder only to itself and 1);
            Console.WriteLine("Enter a number");
            int n = int.Parse(Console.ReadLine());
            if (1 < n < 100)
            for(i = 2; n < Math.Sqrt(n); n++)
            {
                if (n % i == 0);
                Console.WriteLine($"{0}, {1}");
            }*/
            

            Console.WriteLine("-------Question 15-------");  
           // Write a program that exchanges the values of the bits on positions 3, 4 and 5 with bits on positions 24, 25 and 26 of a given 32-bit unsigned integer.
            Console.WriteLine("Enter a number");
            int num = int.Parse(Console.ReadLine());

            int bit3 = (num >> 3) & 1;
            int bit24 = (num >> 24) & 1;
            num = num & (~(1 << 24)) | (bit3 << 24);
            num = num & (~(1 << 3)) | (bit24 << 3);

            int bit4 = (num >> 4) & 1;
            int bit25 = (num >> 25) & 1;
            num = num & (~(1 << 25)) | (bit4 << 25);
            num = num & (~(1 << 4)) | (bit25 << 4);

            int bit5 = (num >> 5) & 1;
            int bit26 = (num >> 26) & 1;
            num = num & (~(1 << 26)) | (bit5 << 26);
            num = num & (~(1 << 5)) | (bit26 << 5);
            Console.WriteLine($"{num}");


             Console.WriteLine("-------Question 16-------");
             //Write a program that exchanges bits {p, p+1, …, p+k-1} with bits {q, q+1, …, q+k-1} of a given 32-bit unsigned integer.
             {p, p+1, …, p+k-1} {q, q+1, …, q+k-1}
            
            Console.WriteLine("Enter a number");
            int nums = int.Parse(Console.ReadLine());

            int bitp = (nums >> p) & 1;
            int bitq = (num >> q) & 1;
            nums = nums & (~(1 << q)) | (bitp << q);
            nums = nums & (~(1 << p)) | (bitq << p);
            if (p < p+1 < n < p+k-1);
            for(int i)

            int bit4 = (num >> 4) & 1;
            int bit25 = (num >> 25) & 1;
            num = num & (~(1 << 25)) | (bit4 << 25);
            num = num & (~(1 << 4)) | (bit25 << 4);

            int bit5 = (num >> 5) & 1;
            int bit26 = (num >> 26) & 1;
            num = num & (~(1 << 26)) | (bit5 << 26);
            num = num & (~(1 << 5)) | (bit26 << 5);
            Console.WriteLine($"{num}");

             


           


            









            











            








          


 


        }
    }
}
