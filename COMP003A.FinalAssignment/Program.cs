/*
 * Author: Diego Carmona
 * Course: COMP003A
 * Purpose: A culmination of all the skills and praactice garnered during the 9 week course of development with C#. To show and be jugded baased on my klnowlegde and talent with the C# language.
 * Theme: Exercise Application questionnaire
 */

using System.Diagnostics.Metrics;
using System.Reflection;
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
            string firstName = Console.ReadLine();
            Console.WriteLine("Please enter Last name");
            string lastName = Console.ReadLine();
            FullNameValidator(firstName, lastName);
            string fullName = firstName + " " + lastName;
            SectionSeparator("Age");
            Console.WriteLine("Please Enter birth year");
            string ageCheck = Console.ReadLine();
            int age = 0;
            try
            {
              age = Convert.ToInt32(ageCheck);
                
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateAge(age))
            {
                Console.WriteLine("Age recorded successfully");
            }
            else
            {
                while (ValidateAge(age) == false)
                {
                    Console.WriteLine("Invalid Age, please re-enter");
                    ageCheck = Console.ReadLine();
                    age = 0;
                    try
                    {
                        age = Convert.ToInt32(ageCheck);

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateAge(age);
                }
                Console.WriteLine("Age recorded successfully");
            }
            SectionSeparator("Gender");
            Console.WriteLine("Please Enter Gender (M, F, or O)");
            string genderCheck = Console.ReadLine();
            char gender = 'a';
            try
            {
                gender = Convert.ToChar(genderCheck);
            } catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateGender(gender))
            {
                Console.WriteLine("Gender recorded successfully");
            } else
            {
                while (ValidateGender(gender) == false)
                {
                    Console.WriteLine("Invalid Input, please re-enter");
                    genderCheck = Console.ReadLine();
                    gender = 'a';
                    try
                    {
                        gender = Convert.ToChar(genderCheck);
                    } catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateGender(gender);
                }
                Console.WriteLine("Gender recorded successfully");
            }
            SectionSeparator("Questionnaire");
            string[] questions = new string[11];
            string[] responses = new string[11];
            Console.WriteLine("Answer these 10 questions for us please:");
            Console.WriteLine("First question: What is your current weight? (No need to be embarrassed)");
            questions[0] = "What is your current weight?";
            string weightCheck = Console.ReadLine();
            int weight = 0;
            try
            {
                weight = Convert.ToInt32(weightCheck);
            } catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateWeight(weight))
            {
                Console.WriteLine("Weight successfully recorded");
            } else
            {
                while (ValidateWeight(weight) == false)
                {
                    Console.WriteLine("Invalid Input, please re-enter");
                    weightCheck = Console.ReadLine();
                    weight = 0;
                    try
                    {
                        weight = Convert.ToInt32(weightCheck);

                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateWeight(weight);
                }
                Console.WriteLine("Weight recorded successfully");
            }
            responses[0] = weightCheck;
            Console.WriteLine("Second question: How often do you exercise? Often(O), Sometimes(S), Rarely(R)?");
            questions[1] = "How often do you exercise? Often(O), Sometimes(S), Rarely(R)?";
            string regularity = Console.ReadLine();
            char pace = 'a';
            try
            {
                pace = Convert.ToChar(regularity);
            } catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            
            if (ValidateRegularity(pace))
            {
                Console.WriteLine("Regularity Recorded");
            } else
            {
                while (ValidateRegularity(pace) == false)
                {
                    Console.WriteLine("Invalid Input, please re-enter");
                    regularity = Console.ReadLine();
                    pace = 'a';
                    try
                    {
                        pace = Convert.ToChar(regularity);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateRegularity(pace);
                }
                Console.WriteLine("Regularity Recorded");
            }
            responses[1] = regularity;
            Console.WriteLine("Third question: Do you have any underlying conditions?");
            questions[2] = "Do you have any underlying conditions?";
            string conditions = Console.ReadLine();
            responses[2] = conditions;
            Console.WriteLine("Fourth question: What is your target weight?");
            questions[3] = "What is your target weight?";
            string target = Console.ReadLine();
            int targetWeight = 0;
            try
            {
                targetWeight = Convert.ToInt32(target);
            }catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateWeight(targetWeight))
            {
                Console.WriteLine("Target weight recorded");
            } else
            {
                while(ValidateWeight(targetWeight) == false)
                {
                    Console.WriteLine("Invalid Input, please re-enter");
                    target = Console.ReadLine();
                    targetWeight = 0;
                    try
                    {
                        targetWeight = Convert.ToInt32(target);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateWeight(targetWeight);
                }
                Console.WriteLine("Target Weight Recorded");
            }
            responses[3] = target;
            Console.WriteLine("Fifth question: What is your height?");
            questions[4] = "What is your height in feet?";
            Console.WriteLine("Feet?");
            string feetHeight = Console.ReadLine();
            int feet = 0;
            try
            {
                feet = Convert.ToInt32(feetHeight);
            }catch(FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateHeight(feet))
            {
                Console.WriteLine("Height Recorded");
            }
            else
            {
                while (ValidateHeight(feet) == false)
                {
                    Console.WriteLine("Invalid Input, please re-enter");
                    feetHeight = Console.ReadLine();
                    feet = 0;
                    try
                    {
                        feet = Convert.ToInt32(feetHeight);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateHeight(feet);
                }
                Console.WriteLine("Height Recorded");
            }
            responses[4] = feetHeight;
            Console.WriteLine("Inches?");
            questions[5] = "What is your remaining height in inches?";
            string inchesHeight = Console.ReadLine();
            int inches = 0;
            try
            {
                inches = Convert.ToInt32(inchesHeight);
            } catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateHeight(inches))
            {
                Console.WriteLine("Height Recorded");
            }
            else
            {
                while (ValidateHeight(inches) == false)
                {
                    Console.WriteLine("Invalid Input, please re-enter");
                    inchesHeight = Console.ReadLine();
                    inches = 0;
                    try
                    {
                        inches = Convert.ToInt32(inchesHeight);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateHeight(inches);
                }
                Console.WriteLine("Height Recorded");
            }
            responses[5] = inchesHeight;
            Console.WriteLine("Sixth Question: What days of the week do you wish to exercise? (M, T, W, Th, F, S, Su)");
            questions[6] = "What days of the week do you wish to exercise? (M, T, W, Th, F, S, Su)";
            string weeklyRoutine = Console.ReadLine();
            if (ValidateRoutine(weeklyRoutine))
            {
                Console.WriteLine("Weekly Routine Updated");
            }else
            {
                while(ValidateRoutine(weeklyRoutine))
                {
                    Console.WriteLine("Sorry Invalid Input Entered or Overly frequent training selected (rest is important). Please re-enter");
                    weeklyRoutine = Console.ReadLine();
                    ValidateRoutine(weeklyRoutine);
                }
            }
            responses[6] = weeklyRoutine;
            Console.WriteLine("Seventh question: Do you prefer exercise outside or indoors?(O or I)");
            questions[7] = "Do you prefer exercise outside or indoors?(O or I)";
            string areaCheck = Console.ReadLine();
            char area = 'a';
            try
            {
                area = Convert.ToChar(areaCheck);
            } catch(FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateArea(area))
            {
                Console.WriteLine("Preference recorded");
            }else
            {
                while (ValidateArea(area))
                {
                    Console.WriteLine("Invalid Input please re-enter");
                    areaCheck = Console.ReadLine();
                    area = 'a';
                    try
                    {
                        area = Convert.ToChar(areaCheck);
                    }
                    catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateArea(area);
                }
                Console.WriteLine("Preference recorded");
            }
            responses[7] = areaCheck;
            Console.WriteLine("Eigth question: Equipment or No? (E or N)");
            questions[8] = "Equipment or No? (E or N)";
            string equipCheck = Console.ReadLine();
            char equip = 'a';
            try
            {
                equip = Convert.ToChar(equipCheck);
            }catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            if (ValidateEquip(equip))
            {
                Console.WriteLine("Preference recorded");
            }else
            {
                while(ValidateEquip(equip))
                {
                    Console.WriteLine("Improper Input, please re-enter");
                    equipCheck = Console.ReadLine();
                    equip = 'a';
                    try
                    {
                        equip = Convert.ToChar(equipCheck);
                    }catch (FormatException ex)
                    {
                        Console.WriteLine("Error: " + ex.Message);
                    }
                    ValidateEquip(equip);
                }
                Console.WriteLine("Preference Recorded");
            }
            responses[8] = equipCheck;
            Console.WriteLine("Ninth question: Enter email address");
            questions[9] = "Enter email address";
            string email = Console.ReadLine();
            if (ValidateEmail(email))
            {
                Console.WriteLine("Email recorded");
            } else
            {
                while (ValidateEmail(email))
                {
                    Console.WriteLine("Improper Input please re-enter");
                    email = Console.ReadLine();
                    ValidateEmail(email);
                }
                Console.WriteLine("Email recorded");
            }
            responses[9] = email;
            Console.WriteLine("Tenth question: Enter Password. Must have at least 5 letters, 3 numbers, a symbol, and must begin with the # sign");
            questions[10] = "Enter Password. Must have at least 5 letters, 3 numbers, a symbol, and must begin with the # sign";
            string password = Console.ReadLine();
            if (ValidatePassword(password)) 
            {
                Console.WriteLine("Password Recorded");
            } else
            {
                while (ValidatePassword(password))
                {
                    Console.WriteLine("Password does not fit standards try again");
                    password = Console.ReadLine();
                    ValidatePassword(password);
                }
            }
            responses[10] = password;
            SectionSeparator("Questionnaire Array");
            BigThreeIntroQuestions(gender, fullName, age);
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
            return DateTime.Now.Year - birthYear;
        }

        /// <summary>
        /// Validates the users name as being a string of alphetibetical characters.
        /// </summary>
        /// <param name="name"></param>
        /// <returns>Boolean true or false</returns>
        static bool ValidateName(string name)
        {
            string pattern = @"^[A-Za-z]{2,}$";

            // Regex.IsMatch is used to compare two matching data type inputs with one another to see if they match.
            // Name is the string input placed by the user when the method is called
            // Pattern is a regular expression used to formulate a pattern and rulebook of sorts that judges if the prior input meets all standards of the expression.
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
            //Limits the age limit inputted 
            if (age > DateTime.Now.Year)
            {
                return false;
            }  else
            {
                string userAge = "";
                try
                {
                    userAge = Convert.ToString(age);
                }
                catch(FormatException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

                string pattern = @"[12]{1}[09]{1}[0-9]{2}$";
                // Regex.IsMatch compares the two string inputs to see if they match one another and returns a boolean true or false output.
                // userAge is the value determined by the current year minus the integer (supposedly year) the user inputs, it is used to find the birth year of the user.
                // // pattern here is a regular expression pattern used to control how low the allowed integer is, how many integers are inputted, and teh range in which they are accepted. 
                if (Regex.IsMatch(userAge, pattern))
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
            string genderCheck = "";
            try
            {
                genderCheck = Convert.ToString(gender);
            }catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
            string pattern = @"^[Mm]|[Ff]|[Oo]";
            // Regex.IsMatch here is used to match the available options within pattern [Mm] [Ff] [Oo], with the character input from the user.
            // genderCheck is teh string converted form of teh user input gender in order to compare with teh string pattern, two alternate data types cannot be matched.
            // pattern is used as the limiter of the user input as it only allows specified characters.
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
                string patternRec = "";
                try
                {
                    patternRec = Convert.ToString(weight);
                } catch (FormatException ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }

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
            string paceCheck = "";
            try
            {
                paceCheck = Convert.ToString(pace);
            } catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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
            string heightCheck = "";
            try
            {
               heightCheck = Convert.ToString(height);
            }catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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
            string areaCheck = "";
            try
            {
                areaCheck = Convert.ToString(area);
            } catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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
            string equipCheck = "";
            try
            {
                equipCheck = Convert.ToString(equip);
            }catch (FormatException ex)
            {
                Console.WriteLine("Error: " + ex.Message);
            }
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

        /// <summary>
        /// Gathers the user INputs from the first three questions and formulates sentences based upon the gender chosen, utilizing the remaining information to build said sentences.
        /// </summary>
        /// <param name="gender">Character Input</param>
        /// <param name="fullname">String Input</param>
        /// <param name="age">Integer Input</param>
        static void BigThreeIntroQuestions(char gender, string fullname, int age)
        {
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
        }


        static void FullNameValidator(string firstName, string lastName)
        {
            if (ValidateName(firstName))
            {
                Console.WriteLine("First name recorded successfully");
            }
            else
            {
                while (ValidateName(firstName) == false)
                {
                    Console.WriteLine("Invalid Name, please re-enter");
                    firstName = Console.ReadLine();
                    ValidateName(firstName);
                }
                Console.WriteLine("First name recorded successfully");
            }
            if (ValidateName(lastName))
            {
                Console.WriteLine("Last name recorded successfully");
            }
            else
            {
                while (ValidateName(lastName) == false)
                {
                    Console.WriteLine("Invalid Name, please re-enter");
                    lastName = Console.ReadLine();
                    ValidateName(lastName);
                }
                Console.WriteLine("Last name recorded successfully");
            }
        }
    }
}