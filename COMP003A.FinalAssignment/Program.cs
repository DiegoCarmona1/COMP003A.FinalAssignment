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
                Console.WriteLine("Invalid Lastname");
            }
            SectionSeparator("Age");
            Console.WriteLine("Please Enter birth year");
            string ageCheck = Console.ReadLine();
            int age = Convert.ToInt32(ageCheck);
            if (ValidateAge(age))
            {
                Console.WriteLine("Age recorded successfully");
            } else
            {
                Console.WriteLine("Too old Invalid Input");
            }
            SectionSeparator("Gender");
            Console.WriteLine("Please Enter Gender (M, F, or O)");
            string genderCheck = Console.ReadLine();
            char gender = Convert.ToChar(genderCheck);
            if (ValidateGender(gender))
            {
                Console.WriteLine("Gender recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Input");
            }
            SectionSeparator("Questionnaire");
            Console.WriteLine("Answer these 10 questions for us please:");
            Console.WriteLine("First question: What is your current weight? (No need to be embarrassed)");
            string weightCheck = Console.ReadLine();
            int weight = Convert.ToInt32(weightCheck);
            if (ValidateWeight(weight))
            {
                Console.WriteLine("Weight successfully recorded");
            } else
            {
                Console.WriteLine("Invalid Input (fatty)");
            }
            Console.WriteLine("Next question: How often do you exercise? Often(O), Sometimes(S), Rarely(R)?");
            string regularity = Console.ReadLine();
            char pace = Convert.ToChar(regularity);
            if (ValidateRegularity(pace))
            {
                Console.WriteLine("Regularity Recorded");
            } else
            {
                Console.WriteLine("That is an Invalid Input");
            }

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
            string pattern = @"^\w{2,}$";

            if (Regex.IsMatch(name, pattern))
            {
                return true;
            } else
            {
                return false;
            }
        }
        /// <summary>
        /// Used to validate the age of the user using the birth year that cannot be older than 1900 or beyond the current one.
        /// </summary>
        /// <param name="age"></param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateAge(int age)
        {
            if (age > 2024)
            {
                return false;
            }  else
            {
                string goodToGo = Convert.ToString(age);
                string pattern = @"[12]{1}[09]{1}[0-9]{2}$";

                if (Regex.IsMatch(goodToGo, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            
        }

        /// <summary>
        /// Validates users Gender based upon the available character selection. Does not allow more than one character.
        /// </summary>
        /// <param name="gender"></param>
        /// <returns></returns>
        static bool ValidateGender(char gender)
        {
            string genderCheck = Convert.ToString(gender);
            string pattern = @"^[Mm]|[Ff]|[Oo]";

            if (Regex.IsMatch(genderCheck, pattern))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Vaalidates the weight of the user
        /// </summary>
        /// <param name="weight"></param>
        /// <returns>Boolean True or False</returns>
        static bool ValidateWeight(int weight)
        {
            string pattern = @"[123]{1}\d{1,}";
            if (weight > 400)
            {
                return false;
            } else
            {
                string patternRec = Convert.ToString(weight);

                if (Regex.IsMatch(patternRec, pattern))
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }


        static bool ValidateRegularity(char pace)
        {
            string paceCheck = Convert.ToString(pace);
            string pattern = @"^[Oo]|[Ss]|[Rr]";

            if (Regex.IsMatch (paceCheck, pattern))
            {
                return true ;
            }else
            {
                return false;
            }
        }

    }
}