using System;
using System.Reflection.Metadata;

namespace CrashCourse_ConditionExamination
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 8;
            int b = 3;



            string name = "Bryce";

            //data type string, 'verb' is equal to, if a is not equal to one. If conditon is true, write "are", if false, write "is"
            string verb = (a != 1) ? " are " : " is ";
            Console.Write("There" + verb + 8 + "\n");
            //Console, write, string "there" connotated with verb variable which is a string, also connotate the value of integer a and use the \n symbol to create a new line.

            string parity = (a % 2 != 0) ? " This value is odd" : " This value is even";
            Console.Write("The selected Number is " + a + parity + "\n");

            parity = (b % 2 != 0) ? "Odd" : "even";
            Console.Write(b + " is "  + parity + "\n");

            string whatismyname = (name == "Bryce") ? "That is NOT my Name, try again, please." : "That IS my name, good guess.";
            
          
            
            Console.WriteLine(whatismyname);

        }
    }
}
