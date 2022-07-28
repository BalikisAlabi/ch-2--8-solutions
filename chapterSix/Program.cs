using System;

namespace chapterSix
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("---------------Question  1------------");
           // Write a program that prints on the console the numbers from 1 to N. The number N should be read from the standard input.

                Console.WriteLine("Enter the number : ");
                int n = int.Parse(Console.ReadLine());
                for(int i = 0; i<= n; i++)
                {
                  Console.WriteLine(i);
                }
                 Console.ReadLine(); 

                Console.WriteLine("---------------Question  2------------");
                //Write a program that prints on the console the numbers from 1 to N,
               //which are not divisible by 3 and 7 simultaneously. The number N
               //should be read from the standard input.

                Console.WriteLine("Enter n : ");
                int m = int.Parse(Console.ReadLine());
                for(int i = 0; i<= m; i++)
                {
                  if (i % 3 != 0 && i % 7 != 0)
                  {
                  Console.WriteLine(i);
                  }
                }

                Console.ReadLine(); 

                Console.WriteLine("---------------Question  3------------");
              //Write a program that reads from the console a series of integers and
              //prints the smallest and largest of them.

              Console.WriteLine("Enter first num ");
              int firstnum = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter second num ");
              int secondnum = int.Parse(Console.ReadLine());
              Console.WriteLine("Enter third num ");
              int thirdnum = int.Parse(Console.ReadLine());
              if (firstnum < secondnum  && firstnum < thirdnum)
              {
                Console.WriteLine($"The smallest number is {firstnum}");
              }
              if (secondnum < thirdnum && secondnum < firstnum)
              {
                Console.WriteLine($"The smallest number is {secondnum}");
              }
              if (thirdnum < firstnum &&  thirdnum < secondnum)
              {
                Console.WriteLine($"The smallest number is {thirdnum}");
              }
              
             
             
              if (firstnum > secondnum  && firstnum > thirdnum)
              {
                Console.WriteLine($"The greatest number is {firstnum}");
              }
              if (secondnum > thirdnum && secondnum > firstnum)
              {
                Console.WriteLine($"The largest number is {secondnum}");
              }
              if (thirdnum > firstnum &&  thirdnum > secondnum)
              {
                Console.WriteLine($"The largest number is {thirdnum}");
              }
               Console.ReadLine(); 

              Console.WriteLine("---------------Question  4------------");
             //Write a program that prints all possible cards from a standard deck of cards, without jokers (there are 52 cards: 4 suits of 13 cards).
              for (int i = 0; i < 4; i++)
            {
                if(i != 0) Console.WriteLine();

                for (int j = 0; j < 13; j++)
                {
                    switch (i)
                    {
                        case 0: Console.Write("Hearts "); break;
                        case 1: Console.Write("Diamonds "); break;
                        case 2: Console.Write("Spades "); break;
                        case 3: Console.Write("Clubs "); break;
                    }
                    switch(j)
                    {
                        case 0: Console.WriteLine("2"); break;
                        case 1: Console.WriteLine("3"); break;
                        case 2: Console.WriteLine("4"); break;
                        case 3: Console.WriteLine("5"); break;
                        case 4: Console.WriteLine("6"); break;
                        case 5: Console.WriteLine("7"); break;
                        case 6: Console.WriteLine("8"); break;
                        case 7: Console.WriteLine("9"); break;
                        case 8: Console.WriteLine("10"); break;
                        case 9: Console.WriteLine("J"); break;
                        case 10: Console.WriteLine("Q"); break;
                        case 11: Console.WriteLine("K"); break;
                        case 12: Console.WriteLine("A"); break;
                    }
                }
            }
            Console.ReadLine();  

           Console.WriteLine("---------------Question  5------------");  
           //Write a program that reads from the console number N and print the sum
          //of the first N members of the Fibonacci sequence: 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, 377, …

          int num1 = 0, num2 = 1, nextNumber,Number = 101;

            Console.Write($"{num1 + " " + num2},");
            for (int a = 2; a < Number; a++)
            {
                nextNumber = num1 + num2;
                Console.Write($"{nextNumber},");
                num1 = num2;
                num2 = nextNumber;

            }
             Console.ReadLine(); 

             Console.WriteLine("---------------Question  6------------");  
             //Write a program that calculates N!/K! for given N and K (1<K<N).

             Console.Write("Enter N: (1<K<N) ");
              int n = Int32.Parse(Console.ReadLine());
              Console.Write("Enter K: (1<K<N) ");
              int k = Int32.Parse(Console.ReadLine());
              
              for (int i = n - 1; i > 0; i--)
              {
                  n *= i;
              }
              
              for (int i = k - 1; i > 0; i--)
              {
                  k *= i;
              }
              
              n /= k;    
              Console.WriteLine("Result is {0}", n);
               Console.ReadLine(); 

               Console.WriteLine("---------------Question  7------------");

              //Write a program that calculates N!*K!/(N-K)! for given N and K (1<K<N).

            Console.Write("Enter N: (1<K<N) ");
            int n = Int32.Parse(Console.ReadLine());
            Console.Write("Enter K: (1<K<N) ");
            int k = Int32.Parse(Console.ReadLine());
            int n-K = n - k;

            for (int i = n - 1; i > 0; i--) n *= i;
            for (int i = k - 1; i > 0; i--) k *= i;
            for (int i = n-K - 1; i > 0; i--) n-K *= i;

            Console.WriteLine("Result is {0}", n * k / n-K);
             Console.ReadLine(); 

            Console.WriteLine("---------------Question  8------------");

            //In combinatorics, the Catalan numbers are calculated by the following formula:Write a program that calculates the nth Catalan number by given n.
                           
            Console.Write("Enter N: (N >=0 ) ");
            int n = Int32.Parse(Console.ReadLine());

            int fact2N = 2 * n, factNplus1 = n + 1;

            for (int i = fact2N - 1; i > 0; i--) fact2N *= i;
            for (int i = factNplus1 - 1; i > 0; i--) factNplus1 *= i;
            for (int i = n - 1; i > 0; i--) n *= i;

            Console.WriteLine("Result is {0}", fact2N / (factNplus1 * n));
             Console.ReadLine(); 

           Console.WriteLine("---------------Question  9------------");
           //Write a program that for a given integers n and x, calculates the sum:
                  int sum = 1, other = 1;
              Console.Write("Enter n: ");
              int n = Int32.Parse(Console.ReadLine());
              Console.Write("Enter x: ");
              int x = Int32.Parse(Console.ReadLine());
              
              for (int i = 1; i <= n; i++)
              {
                  other *= i / x;
                  sum += other;
              }    
              
              Console.WriteLine("Result is {0}", sum);
               Console.ReadLine(); 

            Console.WriteLine("---------------Question  10------------");
           // Write a program that reads from the console a positive integer number N (N < 20) and prints a matrix of numbers as on the figures below:
            
             Console.Write("Enter N: (N < 20) ");
            int n = Int32.Parse(Console.ReadLine());
                
            for (int i = 1; i <= n; i++)
            {
                for (int j = 1; j <= i + n-1; j++)
                {
                    Console.Write("{0} ", j);
                }
                Console.WriteLine();
            }  
            
            int n = 4;

            for (int row = 1; row <= n; row++)
            {
            for (int col = 1; col <= row; col++)
            {
            Console.Write(col + " ");
            }
            Console.WriteLine();
            }  
             Console.WriteLine("---------------Question  11------------");
             //Write a program that calculates with how many zeroes the factorial of a given number ends.
            Console.Write("Enter N: ");
            decimal n = Int32.Parse(Console.ReadLine());
            int zeroes = 0;
            
            for (int i = (int)(n - 1); i > 0; i--)
                n *= i;
            
            Console.Write("N! is {0} and it ends ", n);
            
            do
            {
                n /= 10;
                zeroes++;
            } while (n % 10 == 0);
            
            Console.WriteLine("with {0} zeroes.", zeroes);
            Console.WriteLine();
             Console.WriteLine("---------------Question  12------------");

             //Write a program that converts a given number from decimal to binary notation (numeral system).

          Console.Write("Enter number: ");
          int n = Int32.Parse(Console.ReadLine());    
          string binary = Convert.ToString(n, 2);
          Console.WriteLine("Result is {0}", binary);
           Console.ReadLine(); 


          Console.WriteLine("---------------Question  13------------");
          //Write a program that converts a given number from binary to decimal notation.
        Console.Write("Enter binary number: ");
        int n = Int32.Parse(Console.ReadLine());
        string toDecimal = Convert.ToString(Convert.ToInt32(n, 2), 10);
        Console.WriteLine("Result is {0}", toDecimal);
         Console.ReadLine(); 

          Console.WriteLine("---------------Question  14------------");
        //Write a program that converts a given number from decimal to hexadecimal notation. 
          Console.Write("Enter decimal number: ");
          int n = Int32.Parse(Console.ReadLine());
          string toDecimal = Convert.ToString(Convert.ToInt32(n, 10), 16);
          Console.WriteLine("Result is {0}", toDecimal); 
           Console.ReadLine(); 

          Console.WriteLine("---------------Question  15------------");
          //Write a program that converts a given number from hexadecimal to decimal notation.
          Console.Write("Enter hexadecimal number: ");
          int n = Int32.Parse(Console.ReadLine());
          string toDecimal = Convert.ToString(Convert.ToInt32(n, 16), 10);
          Console.WriteLine("Result is {0}", toDecimal);
           Console.ReadLine(); 
           Console.WriteLine("---------------Question  16------------");

          // Write a program that by a given integer N prints the numbers from 1 to N in random order.

            Random rnd = new Random();
            int temp, randomNumber;
            Console.Write("Enter number: ");
            int n = Int32.Parse(Console.ReadLine());
            int[] arr = new int[n];            

            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = i;
            }

            foreach (int i in arr)
            {                
                randomNumber = rnd.Next(0, n);
                temp = arr[i];
                arr[i] = arr[randomNumber];
                arr[randomNumber] = temp;                
            }

            foreach (int i in arr) Console.WriteLine(arr[i]);
             Console.ReadLine(); 

            Console.WriteLine("---------------Question  17------------");
           //Write a program that given two numbers finds their greatest common divisor (GCD) and their least common multiple (LCM).
            //You may use the formula LCM(a, b) = |a*b| / GCD(a, b).


          Console.Write("Enter first number: ");
          int a = Int32.Parse(Console.ReadLine());
          Console.Write("Enter second number: ");
          int b = Int32.Parse(Console.ReadLine());
          
          while (a != 0 && b != 0)
          {
              if (a > b) a %= b;
              else b %= a;
          }
          
          if (a == 0) Console.WriteLine(b);
          else Console.WriteLine(a); 
           Console.ReadLine(); 

          Console.WriteLine("---------------Question  18------------");     

         // Write a program that for a given number n, outputs a matrix in the form of a spiral:


            Console.Write("Enter N: ");
            int n = Int32.Parse(Console.ReadLine());            
            int[,] matrix = new int[n, n];
            int row = 0, col = 0, direction = 0;

            for (int i = 1; i <= n * n; i++)
            {
                switch(direction)
                {
                    case 0:
                            if (col > n - 1 || matrix[row, col] != 0)
                            {
                                direction = 1;
                                col--;
                                row++;
                            }
                            break;
                    case 1:
                            if (row > n - 1 || matrix[row, col] != 0)
                            {
                                direction = 2;
                                row--;
                                col--;
                            }
                            break;
                    case 2:
                            if (col < 0 || matrix[row, col] != 0)
                            {
                                direction = 3;
                                col++;
                                row--;
                            }
                            break;
                    case 3:
                            if (row < 0 || matrix[row, col] != 0)
                            {
                                direction = 0;
                                row++;
                                col++;
                            }
                            break;
                }

                matrix[row, col] = i;                

                switch(direction)
                {
                    case 0: col++; break;
                    case 1: row++; break;
                    case 2: col--; break;
                    case 3: row--; break;
                }
            }
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < n; j++)
                {
                    if (matrix[i, j] < 10) Console.Write("{0}  ", matrix[i, j]);
                    else Console.Write("{0} ", matrix[i, j]);
                }
                Console.WriteLine();

                        
             



        }
    }
}
