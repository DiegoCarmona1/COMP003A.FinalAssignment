/*
 * Author: Diego Caarmona
 * Course: COMP003A
 * Purpose: A culmination of all the skills and praactice garnered during the 9 week course of development with C#. To show and be jugded baased on my klnowlegde and talent with the C# language.
 * Theme: Exercise Application questionnaire
 */

using System.Net.Security;
using System.Text.RegularExpressions;

namespace COMP003A.FinalAssignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello and welcome. This is the 'Work Warrior' application. We welcome you new user and wish you a grand journey of health and fitness. To apply and proceed on this application please input your information so we may use it to build a personal plan for you and your current ability:\n");
            SectionSeparator("Name");
            Console.WriteLine("Please Enter First Name");
            string q0 = "Please Enter First Name";
            string firstName = Console.ReadLine();
            if (ValidateName(firstName))
            {
                Console.WriteLine("First name recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Name");
                Environment.Exit(0);
            }
            Console.WriteLine("Please enter Last name");
            string q1 = "Please enter Last name";
            string lastName = Console.ReadLine();
            if (ValidateName(lastName))
            {
                Console.WriteLine("Last name recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Lastname");
                Environment.Exit(0);
            }
            string fullname = firstName + " " + lastName;
            SectionSeparator("Age");
            Console.WriteLine("Please Enter birth year");
            string q2 = "Please Enter birth year";
            string ageCheck = Console.ReadLine();
            int age = Convert.ToInt32(ageCheck);
            if (ValidateAge(age))
            {
                Console.WriteLine("Age recorded successfully");
            } else
            {
                Console.WriteLine("Too old Invalid Input");
                Environment.Exit(0);
            }
            SectionSeparator("Gender");
            Console.WriteLine("Please Enter Gender (M, F, or O)");
            string q3 = "Please Enter Gender (M, F, or O)";
            string genderCheck = Console.ReadLine();
            char gender = Convert.ToChar(genderCheck);
            if (ValidateGender(gender))
            {
                Console.WriteLine("Gender recorded successfully");
            } else
            {
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
            }
            SectionSeparator("Questionnaire");
            Console.WriteLine("Answer these 10 questions for us please:");
            Console.WriteLine("First question: What is your current weight? (No need to be embarrassed)");
            string q4 = "What is your current weight?";
            string weightCheck = Console.ReadLine();
            int weight = Convert.ToInt32(weightCheck);
            if (ValidateWeight(weight))
            {
                Console.WriteLine("Weight successfully recorded");
            } else
            {
                Console.WriteLine("Invalid Input (fatty)");
                Environment.Exit(0);
            }
            Console.WriteLine("Second question: How often do you exercise? Often(O), Sometimes(S), Rarely(R)?");
            string q5 = "How often do you exercise? Often(O), Sometimes(S), Rarely(R)?";
            string regularity = Console.ReadLine();
            char pace = Convert.ToChar(regularity);
            if (ValidateRegularity(pace))
            {
                Console.WriteLine("Regularity Recorded");
            } else
            {
                Console.WriteLine("That is an Invalid Input");
                Environment.Exit(0);
            }
            Console.WriteLine("Third question: Do you have any underlying conditions?");
            string q6 = "Do you have any underlying conditions?";
            string conditions = Console.ReadLine();
            Console.WriteLine("Fourth question: What is your target weight?");
            string q7 = "What is your target weight?";
            string target = Console.ReadLine();
            int targetWeight = Convert.ToInt32(target);
            if (ValidateWeight(targetWeight))
            {
                Console.WriteLine("Target weight recorded");
            } else
            {
                Console.WriteLine("Invalid Input");
                Environment.Exit(0);
            }
            Console.WriteLine("Fifth question: What is your height?");
            string q8 = "What is your height in feet?";
            Console.WriteLine("Feet?");
            string feetHeight = Console.ReadLine();
            int feet = Convert.ToInt32(feetHeight);
            if (ValidateHeight(feet))
            {
                Console.WriteLine("Height Recorded");
            }
            else
            {
                Console.WriteLine("Invalid Height Inputted");
                Environment.Exit(0);
            }
            Console.WriteLine("Inches?");
            string q9 = "What is your height in inches?";
            string inchesHeight = Console.ReadLine();
            int inches = Convert.ToInt32(inchesHeight);
            if (ValidateHeight(inches))
            {
                Console.WriteLine("Height Recorded");
            }
            else
            {
                Console.WriteLine("Invalid Height Inputted");
                Environment.Exit(0);
            }
            Console.WriteLine("Sixth Question: What days of the week do you wish to exercise? (M, T, W, Th, F, S, Su)");
            string q10 = "What days of the week do you wish to exercise? (M, T, W, Th, F, S, Su)";
            string weeklyRoutine = Console.ReadLine();
            if (ValidateRoutine(weeklyRoutine))
            {
                Console.WriteLine("Weekly Routine Updated");
            }else
            {
                Console.WriteLine("Sorry Invalid Input Entered or Overly frequent training selected (rest is important).");
                Environment.Exit(0);
            }
            Console.WriteLine("Seventh question: Do you prefer exercise outside or indoors?(O or I)");
            string q11 = "Do you prefer exercise outside or indoors?(O or I)";
            string areaCheck = Console.ReadLine();
            char area = Convert.ToChar(areaCheck);
            if (ValidateArea(area))
            {
                Console.WriteLine("Preference recorded");
            }else
            {
                Console.WriteLine("Invalid Input Entered");
                Environment.Exit(0);
            }
            Console.WriteLine("Eigth question: Equipment or No? (E or N)");
            string q12 = "Equipment or No? (E or N)";
            string equipCheck = Console.ReadLine();
            char equip = Convert.ToChar(equipCheck);
            if (ValidateEquip(equip))
            {
                Console.WriteLine("Preference recorded");
            }else
            {
                Console.WriteLine("Invalid Input Entered");
                Environment.Exit(0);
            }
            Console.WriteLine("Ninth question: Enter email address");
            string q13 = "Enter email address";
            string email = Console.ReadLine();
            if (ValidateEmail(email))
            {
                Console.WriteLine("Email recorded");
            } else
            {
                Console.WriteLine("Improper Input");
                Environment.Exit(0);
            }
            Console.WriteLine("Tenth question: Enter Password. Must have at least 5 letters, 3 numbers, a symbol, and must begin with the # sign");
            string q14 = "Enter Password. Must have at least 5 letters, 3 numbers, a symbol, and must begin with the # sign";
            string password = Console.ReadLine();
            if (ValidatePassword(password)) 
            {
                Console.WriteLine("Password Recorded");
            } else
            {
                Console.WriteLine("Password does not fit standards");
                Environment.Exit(0);
            }

            SectionSeparator("Questionnaire Array");
            string[] questions = {q4, q5, q6, q7, q8, q9, q10, q11, q12, q13, q14 };
            string[] responses = {weightCheck, regularity, conditions, target, feetHeight, inchesHeight, weeklyRoutine, areaCheck, equipCheck, email, password };
            if (gender == 'M')
            {
                Console.WriteLine($"Hello {fullname}, you are {AgeCalculator(age)} years old. You identify as Male");
            }
            else if (gender == 'F')
            {
                Console.WriteLine($"Hello {fullname}, you are {AgeCalculator(age)} years old. You identify as Female");
            }
            else if (gender == 'O')
            {
                Console.WriteLine($"Hello {fullname}, you are {AgeCalculator(age)} years old. You identify as an Other");
            }
            Console.WriteLine("\n Here is a Review of your questions and answers:\n");
            for (int i = 0; i < questions.Length; i++)
            {
                Console.WriteLine($"We asked you: {questions[i]}");
                Console.WriteLine($"You responded: {responses[i]}\n");
            }
            Console.WriteLine($"You have answered {questions.Length} questions for us. Thank you for your participation, we will be sending a proper routine and exercise schudule plan shortly. Have a wonderful day.");
        }

        /// <summary>
        /// USed to separate the different information sections of the console
        /// </summary>
        /// <param name="section">Stirng Input</param>
        static void SectionSeparator(string section)
        {
            Console.WriteLine("".PadRight(50, '*') + $"\n\t\t{section} Section\n" + "".PadRight(50, '*'));
        }

        /// <summary>
        /// Calculates the age of teh user using teh inputted birth year.
        /// </summary>
        /// <param name="ageYear">Integer input</param>
        /// <returns>Age of user based upon birth year input</returns>
        static int AgeCalculator(int birthYear)
        {
            return 2024 - birthYear;
        }

        /// <summary>
        /// Validates the users name as being a string of alphetibetical characters.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateName(string name)
        {
            string pattern = @"^[A-Za-z]{2,}$";

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
        /// <param name="gender">Character input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateGender(char gender)
        {
            string genderCheck = Convert.ToString(gender);
            string pattern = @"^[M]|[F]|[O]";

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
            string pattern = @"[123]{1}\d{1,2}";
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

        /// <summary>
        /// Validates the regularity of user exercise based on appropriate response presented.
        /// </summary>
        /// <param name="pace"></param>
        /// <returns>Boolean true or false</returns>
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

        /// <summary>
        /// Validates the height inputted by the user
        /// </summary>
        /// <param name="height">Integer Input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateHeight(int height)
        {
            string heightCheck = Convert.ToString(height);
            string pattern = @"\d{1}";

            if (Regex.IsMatch(heightCheck, pattern))
            {
                return true ;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Validates the Weekly routine selected by the user
        /// </summary>
        /// <param name="weekDay">string input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateRoutine(string weekDay)
        {
            string pattern = @"[MmTtWwHhFfSsUu]{1,5}";

            if (Regex.IsMatch(weekDay, pattern))
            {
                return true ;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Valiidates environmental preference given by user
        /// </summary>
        /// <param name="area">character input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateArea(char area)
        {
            string areaCheck = Convert.ToString(area);
            string pattern = @"[OoIi]{1}";

            if (Regex.IsMatch(areaCheck, pattern))
            {
                return true ;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Validates equipment usage preference
        /// </summary>
        /// <param name="equip">character input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateEquip(char equip)
        {
            string equipCheck = Convert.ToString(equip);
            string pattern = @"[EeNn]{1}";

            if (Regex.IsMatch(equipCheck, pattern))
            {
                return true;
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Validate the inputted email by the user
        /// </summary>
        /// <param name="email">string input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateEmail(string email)
        {
            string pattern = @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$";

            if (Regex.IsMatch(email, pattern)) 
            {
                return true; 
            }else
            {
                return false;
            }
        }

        /// <summary>
        /// Validates the efficacy of the password inputted by the user
        /// </summary>
        /// <param name="password">string input</param>
        /// <returns>Boolean true or false</returns>
        static bool ValidatePassword(string password)
        {
            string pattern = @"^#[A-Za-z]{5,}\d{3,}\W{1,}";

            if (Regex.IsMatch(password, pattern))
            {
                return true;
            }else
            {
                return false;
            }
        }
    }
}