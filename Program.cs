using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab7_ValidateStudentInfo
{
    class Program
    {

        static string keepGoing;

        static void Main(string[] args)
        {

            Classroom expNet = new Classroom();

            Console.WriteLine("Welcome to our .NET class.");
            Console.WriteLine("Which student would you like to learn more about? (enter a number 1-23:)");
            try
            {
                int studentNumber = int.Parse(Console.ReadLine());

              /*  for (int i = 0; i < expNet.students.Length; i++)
                  {
                  expNet.students[i] = new Student();
                  }
                  */

                Console.WriteLine("\nStudent #" + studentNumber + " is " + expNet.students[studentNumber].FirstName + " " + expNet.students[studentNumber].LastName);

                
                //int studentInfo = int.Parse(Console.ReadLine());

                do
                {
                    Console.WriteLine("\nWhat would you like to know about " + expNet.students[studentNumber].FirstName + "? (enter'hometown' or 'favorite food'):");
                    string studentInfo = Console.ReadLine();
                    if (studentInfo == "hometown")
                    {
                        Console.WriteLine("\n" + expNet.students[studentNumber].FirstName + " is from " + expNet.students[studentNumber].Hometown + ".");
                        continueOrQuit();
                    }

                    else if (studentInfo == "favorite food")

                    {
                        Console.WriteLine("\n" + expNet.students[studentNumber].FirstName + "'s favorite food is " + expNet.students[studentNumber].FavoriteFood + ".");
                        continueOrQuit();
                    }

                    else
                    {
                        Console.WriteLine("\nThis information does not exist, please try again. (enter'hometown' or 'favorite food'): ");
                    }

                } while (keepGoing.ToLower() == "y" || keepGoing.ToLower() == "yes");
            }

            catch (IndexOutOfRangeException)
            {
                Console.WriteLine("Try another index");
            }

            catch (Exception ex)
            {
                Console.WriteLine("an exception is caught");
                Console.WriteLine("The type is " + ex.GetType());
                Console.WriteLine("The Message " + ex.Message);
            }
            finally
            {

            }
            Console.ReadKey();

        }
        

        private static void continueOrQuit()
        {
            Console.WriteLine("Would you like to know more? (enter 'yes' or 'no')");
            keepGoing = Console.ReadLine();
        }
       
    }
}