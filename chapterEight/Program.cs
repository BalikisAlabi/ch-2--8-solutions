using System;

namespace chapterEight
{
    class Program
    {
        static void Main(string[] args)
        { 
          Console.WriteLine("-----Question 1-----");
          // Convert the numbers 151, 35, 43, 251, 1023 and 1024 to the binary numeral system.
          int n= 151, o = 35, p = 43, q = 251, r = 1023, s = 1024;

          ConvertToBinary(n);
          ConvertToBinary(o);
          ConvertToBinary(p);
          ConvertToBinary(q);
          ConvertToBinary(r);
          ConvertToBinary(s);
        
          Console.WriteLine("-----Question 2-----");
           //  2. Convert the number 1111010110011110(2) to hexadecimal and decimal numeral systems.

          string m =  "1111010110011110";
          Console.WriteLine($"{m} to decimal is {Convert.ToInt64(m ,2)}");
          Console.WriteLine($"{m} to hexadecimal is {Convert.ToInt64(m ,2).ToString("X")}");
          Console.WriteLine();
        
          Console.WriteLine("-----Question 3-----");
           //  Convert the hexadecimal numbers FA, 2A3E, FFFF, 5A0E9 to binary and  decimal numeral systems.

          ConversionToBinaryAndDecimal("FA");
          ConversionToBinaryAndDecimal("2A3E");
          ConversionToBinaryAndDecimal("FFF");
          ConversionToBinaryAndDecimal("5A0E9");

          
        
         Console.WriteLine("-----Question 4-----");
          // Write a program that converts a decimal number to binary one.
         Console.Write("Enter decimal number:");
         int decimalNumber = (int)decimal.Parse(Console.ReadLine());
         string binaryNumber = Convert.ToString(decimalNumber , 2);
         Console.WriteLine($"Binary value: {binaryNumber}");
         Console.WriteLine();

         
         Console.WriteLine("----------Question 5-----------");
            //  Write a program that converts a binary number to decimal one.

         Console.Write("Enter binary number: ");
         int binaryValue = (int)decimal.Parse(Console.ReadLine());
         int decimalValue = Convert.ToInt32(binaryValue.ToString(), 2);           
         Console.WriteLine($"Decimal Value : {decimalValue} ");
         Console.WriteLine();

         
         Console.WriteLine("--------------Question 6--------");
         // Write a program that converts a decimal number to hexadecimal one.
         Console.Write("Enter decimal number: ");
         int decimalNum = (int)decimal.Parse(Console.ReadLine());
         string hexaDecimalValue = (decimalNum.ToString("x"));           
         Console.WriteLine($"Hexadecimal Value : {hexaDecimalValue} ");
         Console.WriteLine();

         
         Console.WriteLine("----------Question 7-----------");
         // Write a program that converts a hexadecimal number to decimal one.
         Console.Write("Enter hexadecimal number: ");
         string hexaDecimalNum = Console.ReadLine();
         Console.WriteLine($"Decimal Value : {Convert.ToInt32(hexaDecimalNum , 16)} ");
         Console.WriteLine();

          Console.WriteLine("------------Question 8----------");
         // Write a program that converts a hexadecimal number to binary one.
          Console.Write("Enter hexadecimal number: ");
          string hexaDecimalNumber = Console.ReadLine();
          Console.WriteLine($"Binary Value : {Convert.ToString(Convert.ToInt32(hexaDecimalNum , 16) , 2)} ");
          Console.WriteLine();

         
          Console.WriteLine("-------------Question 9-----------");
          // Write a program that converts a binary number to hexadecimal one.
          Console.WriteLine("Enter binary number: ");
          string binary = Console.ReadLine();
          Console.WriteLine($"Hexadecimal Value : {Convert.ToInt32(binary , 2).ToString("X")}");
          Console.WriteLine();


        
           Console.WriteLine("-------------Question 10-----------");
             //Write a program that converts a binary number to decimal using the Horner scheme.
           int deci = 0;
            Console.Write("Enter binary number: ");
            string binary = Console.ReadLine();
            int length = binary.Length;
            int power = length - 1;

            for (int i = 0; i < length; i++)
            {
                deci += (int)(int.Parse(binary[i].ToString()) * Math.Pow(2, power));
                power--;
            }

            Console.WriteLine("Result is {0}.", deci);

                 Console.WriteLine("-------------Question 12-----------");
           // Write a program that converts Arabic digits to Roman ones.
            lookup.Add('M', 1000);
            lookup.Add('C', 100);
            lookup.Add('L', 50);
            lookup.Add('X', 10);
            lookup.Add('V', 5);
            lookup.Add('I', 1);
            lookup.Add('m', 1000);
            lookup.Add('c', 100);
            lookup.Add('l', 50);
            lookup.Add('x', 10);
            lookup.Add('v', 5);
            lookup.Add('i', 1);

            int arabic = 0;

            for (int i = 0; i < roman.Count(); i++)
            {
                
                if (!lookup.ContainsKey(roman[i]))
                    return 0;

                if (i == roman.Count() - 1)
                {
                    arabic += lookup[roman[i]];
                }
                else
                {
                    if (lookup[roman[i + 1]] > lookup[roman[i]]) arabic -= lookup[roman[i]];
                    else arabic += lookup[roman[i]];
                }
            }
            return arabic;
        }

            Console.WriteLine("-------------Question 13-----------");
            //Write a program that by given N, S, D (2 ≤ S, D ≤ 16) converts the number N from an S-based numeral system to a D based numeral system.
            int S, D;
            Console.Write("Enter N: ");
            string N = Console.ReadLine();
                        
                        do
                        {
                Console.Write("Enter S (S == 2, 8, 10 or 16): ");
                S = Int32.Parse(Console.ReadLine());
                        } while (S != 2 && S != 8 && S != 10 && S != 16);

                        do
                        {
                Console.Write("Enter D (D == 2, 8, 10 or 16): ");
                            D = Int32.Parse(Console.ReadLine());
                        } while (D != 2 && D != 8 && D != 10 && D != 16);

                        N = Convert.ToString(Convert.ToInt32(N, S), D);

            Console.WriteLine($"Result is {N}.");
        }
    }
}
