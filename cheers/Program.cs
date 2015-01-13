using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace cheers
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Hello, World");

            //Step 1: Get user's name and print it.
            System.Console.WriteLine("What is your name?");
            string name = System.Console.ReadLine();
            System.Console.WriteLine("Welcome, " + name);
            string upperName = name.ToUpper();
            string lowerName = name.ToLower();
            //Step 2: Cheer the user on.
            //If name is "Bob" output should be:
            //Give me a... B
            //Give me an ... O
            //Give me a ... B
            //BOB is ... GRAND!
            char[] array = lowerName.ToCharArray();
            for (int i = 0; i < array.Length; i++ )
            {
                char letter = array[i];
                string article;
                if("halfnorsemix".IndexOf(letter) >= 0){
                    article = "an";
                }else{
                    article = "a";
                }
                System.Console.WriteLine("Give me " + article + " ... " + letter);
            }
            System.Console.WriteLine(upperName + " is ... GRAND!");


                System.Console.WriteLine("Press any key to exit");
            System.Console.ReadKey();
        }
    }
}
