using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Single line comment

/* Multi
 * Line
 * Comment
 */

namespace Csharp_Tutorial_Lesson1
{
    class Program
    {
        // Accessibility levels
        /*
         * private              => invisible outside of scope under ALL circumstances
         * protected            => visible only to classes that derive from the base class
         *                      eg: ClassB : ClassA
         * public               => visible to the outside world
         * 
         * internal             => visible to the whole assembly (eg: Csharp_Tutorial_Lesson1)
         * protected internal   => visible to the assembly or classes deriving thereof
         *  
         * Access levels cannot be defined inside functions, only on class level (or above)
         * Variables defined in functions are always private to that scope/function
         */
        private byte mPrivateByte;
        protected byte mProtectedByte;
        public byte mPublicByte;

        // Declaration of variable
        private byte b1;
        // Definition of variable
        private byte b2 = 12;

        /* naming variables
         * prefix with 'm' for member
         * then descriptive name for content of variable
         */

        // This is a private member/variable, that will only be used in thsi context
        private string mCreditCardNumber;

        // This is a publicly accessible property, rather than a private member/variable
        public string CreditcardNumber { get; set; }

        static void Main(string[] args)
        {

            //Variables run-through
            /* 
            * byte mByte = 0;                 // 8 bit unsigned integer (0 <-> 255)
            * char mchar = 'c';               // 16 bit representation of a character such as 'a' 'b' '?' etc single quote escape as follows '\'' (see ascii table)
            * short mShort = 32100;           // 16 bit signed integer (-32768 <-> 32767)
            * int mInt = 2147483647;          // 32 bit signed integer (-2147483648 <-> 2147483647) 2 to the power of 32 essentially
            * uint mUint = 4294967295;        // 32 bit unsigned integer (0 <-> 4294967295)
            * float mFloat = 1.254f;          // 32 bit signed real number
            * double mDouble = 1.267345;      // 64 bit signed real number
            * decimal mDecimal = 1.4444M;     // 128 bit high precision real number
            * 
            * string mString = "Hello World"; // An array of char (C# technically calls this a class but it's still a variable really
            * 
            * bool mBool = true;              // 1 bit true or false representation takes either true||false or 0||1
            */

            Console.WriteLine("Hello World!");
            Console.WriteLine();
            Console.WriteLine("Please enter a number between 1 and 10 ...");
            // variables declared in a function should not need the 'm' prefix
            // but it helps to start them with lowercase to make it obvious they are in function scope only
            string userResponse = Console.ReadLine();

            int userNumber;
            if (int.TryParse(userResponse, out userNumber))
            {
                if (userNumber < 1 || userNumber > 10)
                {
                    Console.Write("Sorry the number \"");
                    Console.Write(userResponse);
                    Console.WriteLine("\" is outside the defined boundary!");
                } else
                {
                    int result = userNumber * userNumber;
                    Console.WriteLine($"{userNumber} squared equals {result}.");
                }
            } else
            {
                Console.WriteLine("Sorry but that was not a valid number..");
            }
            Console.WriteLine("Please find the \"Any\" key and press it to close this application.");
            Console.ReadKey();
        }
    }
}
