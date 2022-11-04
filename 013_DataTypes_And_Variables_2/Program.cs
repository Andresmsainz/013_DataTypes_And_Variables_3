using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _013_DataTypes_And_Variables_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char letter_a = 'a';

            Console.WriteLine("initial char letter_a = " + letter_a);

            letter_a = 'b';

            Console.WriteLine("changed char letter_a = " + letter_a);

            string firstName, lastName, familyHouse;

            firstName = "Jon";
            lastName = "Snow";
            familyHouse = "Stark";

            Console.WriteLine("You know nothing " + firstName + " " + lastName + "!");
            Console.WriteLine("If you don't shape up, you're going back to House " + familyHouse + "!");

        }
    }
}

