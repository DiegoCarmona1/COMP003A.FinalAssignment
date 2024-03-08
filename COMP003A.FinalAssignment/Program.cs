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
                Console.WriteLine("First name recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Name");
            }
            Console.WriteLine("Pleaase enter Last name");
            string lastName = Console.ReadLine();
            if (ValidateName(lastName))
            {
                Console.WriteLine("Last name recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            SectionSeparator("Age");
            Console.WriteLine("Please Enter birth year");
            string age = Console.ReadLine();
            int ageCheck = Convert.ToInt32(age);
            if (ValidateAge(age))
            {
                Console.WriteLine("Age recorded successfully");
            } else
            {
                Console.WriteLine("Too old Invalid Input");
            }
            SectionSeparator("Gender");
            Console.WriteLine("Please Enter Gender (M, F, or O)");
            string gender = Console.ReadLine();
            if (ValidateGender(gender))
            {
                Console.WriteLine("Gender recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            SectionSeparator("Questionnaire");


        }

        /// <summary>
        /// USed to separate the different information sections of the console
        /// </summary>
        /// <param name="section"></param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
        }


        /// <summary>
        /// Validates the users name as being a string of alphetibetical characters.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateName(string name)
        {
            string pattern = @"\w[a-z]";

            if (Regex.IsMatch(pattern, name))
            {
                return true;
            } else
            {
                return false;
            }
        }
        /// <summary>
        /// Used to validate the age of the user using the birth year that cannot be older than 1900.
        /// </summary>
        /// <param name="age"></param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateAge(string age)
        {
            string pattern = @"\d{1}(1-2)\d{1}(9-0)\d{2}";

            if (Regex.IsMatch(pattern, age)) 
            { 
                return true;
            } else 
            { 
                return false;
            }
        }

        /// <summary>
        /// Validates users Gender based upon the available character selection. Does not allow more than one character.
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        static bool ValidateGender(string gender)
        {
            string pattern = @".\w([Mm]|[Ff]|[Oo])";

            if (Regex.IsMatch(pattern, gender))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}