using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariablesEverywhere
{
    class Program
    {
        static void Main(string[] args)
        {
            //A variable that stores text
            string words;
            words = "Hello World";
            Console.WriteLine(words);

            //Any variable can be initialized on the line they are declared on
            string words2 = "blah blah blah";

            //Subsequent accesses to variables dont require you use the type any more
            words2 = "In brightest day,";
            words2 = "In blackest night.";
            Console.WriteLine(words2);

            //Very small numbers - often used in large groups to push raw data around
            byte tinyNumber;
            tinyNumber = 3;
            Console.WriteLine(tinyNumber);

            //Signed bytes - can be between -127 to +127
            sbyte tinySignedNumber;
            tinySignedNumber = -17;
            Console.WriteLine(tinySignedNumber);

            //Bigger than a byte, smaller than the rest
            short smallNumber;
            smallNumber = -4843;
            Console.WriteLine(smallNumber);

            //The unsigned version - Can only be positive, so moves the negative side amount over
            //From range of -32768/+32767 to 0/+65535
            ushort mediumNum;
            mediumNum = 65000;
            Console.WriteLine(mediumNum);

            //Most commonly used - not too big or small, -2,147,483,648 to +2,147,483,647
            int goldiLocks;
            goldiLocks = 2147483646;
            Console.WriteLine(goldiLocks);

            //Moves the negative range over to the positive, so 0 to 4,294,967,295
            uint bigGoldi;
            bigGoldi = 4294967295;
            Console.WriteLine(bigGoldi);

            //Bigger number range 
            long bigNum;
            bigNum = 9223372036854775807;
            Console.WriteLine(bigNum);

            //Again, moves negative range to positive side
            ulong biggestNum;
            biggestNum = 18446744073709551615;
            Console.WriteLine(biggestNum);

            //Char is for storing single letters
            char singleLetter;
            singleLetter = 'A';
            Console.WriteLine(singleLetter);

            //Floats use decimal places
            float pi;
            pi = 3.141593f;
            Console.WriteLine(pi);

            //Double uses decimal places, but have an even bigger range
            double piAsDouble;
            piAsDouble = 3.14159265358979;
            Console.WriteLine(piAsDouble);

            //decimal is commonly used for money, is much more accurate than float or double, but can't go as high in range
            decimal piAsADecimal;
            piAsADecimal = 3.1415926535897932384626433833M;
            Console.WriteLine(piAsADecimal);

            //True or false
            bool truthValue;
            truthValue = true;
            Console.WriteLine(truthValue);
            truthValue = false;
            Console.WriteLine(truthValue);

            Console.ReadKey();


        }
    }
}
