using System;

namespace chapterTwo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
             Console.WriteLine("---------Question 1------------");
               //Declare several variables by selecting for each one of them the most
               //appropriate of the types sbyte, byte, short, ushort, int, uint, long
               //and ulong in order to assign them the following values: 52,130; -115;
               //4825932; 97; -10000; 20000; 224; 970,700,000; 112; -44; -1,000,000;
               //1990; 123456789123456789.

               sbyte a = 97, -115, 112, -44;
               byte  b = 224;
               short c = 20000, 1990, -10000;
               ushort d = 52130;
               int   e = 970,700,000; 
               uint  f = 4825932;
               long  g = -1000000;
               ulong h = 123456789123456789; 
               Console.WriteLine();

                    Console.WriteLine("---------Question 2------------");

              /* Which of the following values can be assigned to variables of type float,
               double and decimal: 5, -5.01, 34.567839023; 12.345; 8923.1234857; 3456.091124875956542151256683467?*/

             float x = 12.345F;
             decimal y = 3456.091124875956542151256683467M;
             double z = 8923.1234857;
             Console.WriteLine();
                    Console.WriteLine("---------Question 3------------");
             //Write a program, which compares correctly two real numbers with accuracy at least 0.000001.
             double a = 3.48963;
             double b = 3.489631;
             bool equal = Math.Abs(a -= b) < 0.000001;
             Console.WriteLine();

                    Console.WriteLine("---------Question 4------------");
             //Initialize a variable of type int with a value of 256 in
             //hexadecimal format (256 is 100 in a numeral system with base 16).

             int valueInDec = 256;
             int valueInHex = 0x100;
             Console.WriteLine();

                Console.WriteLine("---------Question 5------------");
             //Declare a variable of type char and assign it as a value the character,
             //which has Unicode code, 72 (use the Windows calculator in order to find hexadecimal representation of 72).

              char ch = 72;
              char chx = 
              Console.WriteLine();
                     
                     Console.WriteLine("---------Question 6------------");

              //Declare a variable isMale of type bool and assign a value to it depending on your gender.

              bool isMale = female;*/

              Console.WriteLine();


                        Console.WriteLine("---------Question 7------------");

              //Declare two variables of type string with values "Hello" and "World".
              //Declare a variable of type object. Assign the value obtained of
              //concatenation of the two string variables (add space if necessary) to this variable. Print the variable of type object.

              
              string firstval = "Hello";
              string secondval = "World";
              object all = firstval  + " " +  secondval;
              Console.WriteLine("The word is : "  + firstval + " " +  secondval + ".");

              Console.WriteLine();

                    Console.WriteLine("---------Question 8------------");

             /*Declare two variables of type string and give them values "Hello" and  "World". Assign the value obtained by the concatenation of the two
             variables of type string (do not miss the space in the middle) to a variable of type object. Declare a third variable of type string and
             initialize it with the value of the variable of type object (you should use type casting)*/

             string firstone = "Hello";
             string secondone  = "World";
             object thrd = firstone + " " + secondone;
             string thirdone = Convert.ToString(thrd);

             Console.WriteLine();

                Console.WriteLine("---------Question 9------------");
             //Declare two variables of type string and assign them a value “The
             //"use" of quotations causes difficulties.” (without the outer quotes).
             //In one of the variables use quoted string and in the other do not use it.

             string vari = "The \"use\" of quotations causes difficulties.";
             string vari2 = "\" The \"use\" of quotations causes difficulties.\"";

             Console.WriteLine();


                Console.WriteLine("---------Question 10------------");
             //Write a program to print a figure in the shape of a heart by the sign "o".

                Console.WriteLine("o 0            o o");
                Console.WriteLine("o  o         o  o");
                Console.WriteLine(" o  o       o   o");
                Console.WriteLine("o     o   o     o");
                Console.WriteLine(" oo    ooo   oo ");
                Console.WriteLine("  o          o ");
                Console.WriteLine("   o        o  ");
                Console.WriteLine("        o     ");

                Console.WriteLine();

                    Console.WriteLine("---------Question 11------------");
                Console.WriteLine("           ©      ");
                Console.WriteLine("        ©    ©      ");
                Console.WriteLine("       ©       ©     ");
                Console.WriteLine("      ©         ©     ");
                Console.WriteLine("     ©           ©     ");
                Console.WriteLine("    ©             ©     ");
                Console.WriteLine("   ©               ©    ");
                Console.WriteLine("  ©©©©©©©©©©©©©©©©©©©    ");
                Console.WriteLine();

                Console.WriteLine("---------Question 12------------");

            //A company dealing with marketing wants to keep a data record of its employees. Each record should have the following characteristic – first
            //name, last name, age, gender (‘m’ or ‘f’) and unique employee number (27560000 to 27569999). Declare appropriate variables needed to
           //maintain the information for an employee by using the appropriate data types and attribute names.

            Console.WriteLine("Enter the first name.");
            string firstname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the last name.");
            string lastname = Convert.ToString(Console.ReadLine());
            Console.WriteLine("Enter the age.");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter your gender.");
            char gender = Convert.ToChar(Console.ReadLine());
            int id = 27560000 - 27569999;
            Console.WriteLine();

            
            Console.WriteLine("---------Question 13------------");

          //Declare two variables of type int. Assign to them values 5 and 10 respectively. Exchange (swap) their values and print them.

         int a = 4;
         int b = 3;
         a = a + b;
         b = a - b;
         a = a - b;
         Console.WriteLine("a :{0} b: {1}", a, b);



        }
    }
}
