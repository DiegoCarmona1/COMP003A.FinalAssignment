/*
 * Author: Diego Caarmona
 * Course: COMP003A
 * Purpose: A culmination of all the skills and praactice garnered during the 9 week course of development with C#. To show and be jugded baased on my klnowlegde and talent with the C# language.
 * Theme: Exercise Application questionnaire
 */

using System.Text.RegularExpressions;

namespace COMP003A.FinalAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SectionSeparator("Name");
            Console.WriteLine("Please Enter First Name");
            string firstName = Console.ReadLine();
            if (ValidateName(firstName))
            {
                Console.WriteLine("First name recorded");
            } else
            {
                Console.WriteLine("Invalid Name");
            }
            Console.WriteLine("Pleaase enter Last name");
            string lastName = Console.ReadLine();
            if (ValidateName(lastName))
            {
                Console.WriteLine("Last name recorded");
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            SectionSeparator("Age");
            Console.WriteLine("Please Enter your age");
            string age = Console.ReadLine();
            int ageCheck = Convert.ToInt32(age);

        }

        /// <summary>
        /// USed to separate the different information sections of the console
        /// </summary>
        /// <param name="section"></param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
        }



        static bool ValidateName(string name)
        {
            string pattern = @"[Aa-Zz]\w";

            if (Regex.IsMatch(pattern, name))
            {
                return true;
            } else
            {
                return false;
            }
        }
    }
}