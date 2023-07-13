using System;
using System.Collections.Generic;

    class GymProgram
    {
        static void Main()
        {
            string gymPass = "3-12";

            Console.WriteLine("Welcome to GymProg...");

            Console.Write("Enter the GymPass: ");
            string userInput = Console.ReadLine();

            while (userInput != "0")
            {
                string result = userInput == gymPass ? "correct" : "error";

                if (result == "correct")
                {
                    GymProgram.Menu();
                    userInput = Console.ReadLine();

                    switch (userInput)
                    {
                        case "G":
                            GymProgram.Program("Push", "3", "12");
                            break;

                        case "Y":
                            GymProgram.Program("Pull", "3", "12");
                            break;

                        case "M":
                            GymProgram.Program("Leg", "4", "15");
                            break;

                        case "0":
                            Console.WriteLine("Exiting program...");
                            break;

                        default:
                            Console.WriteLine("Invalid input!");
                            break;
                    }
                }
                else
                {
                    Console.WriteLine("-----------------------------------------");
                    Console.WriteLine("Invalid GymPass, Please try again!");
                    userInput = Console.ReadLine();
                }
            }

            Console.WriteLine("");
            Console.WriteLine("Thanks for using GymProg...");
            Console.WriteLine("Hope we helped you in your workout program.");
        }

        static void Menu()
        {
            Console.WriteLine("-----------------------------------------");
            Console.WriteLine("Here are the following programs: ");
            Console.WriteLine("Enter G (Push)");
            Console.WriteLine("Enter Y (Pull)");
            Console.WriteLine("Enter M (Leg)");
            Console.WriteLine("Enter 0 to exit...");
            Console.WriteLine("Choose your option:");
        }

        static void Program(string programType, string numSets, string numReps)
        {
            Console.WriteLine($"{programType} Day: ({numSets} Sets - {numReps} Reps)");

            List<string> workouts = new List<string>();

            if (programType == "Push")
            {
                workouts = new List<string>
                {
                    "Flat Dumbbell Bench Press",
                    "Incline Bench Press",
                    "Dips",
                    "Side Lateral Raises",
                    "Triceps Pushdown",
                    "Seated Triceps Extension",
                    "Skullcrushers",
                    "Dumbbell Shoulder Press"
                };
            }
            else if (programType == "Pull")
            {
                workouts = new List<string>
                {
                    "Pull Ups",
                    "Deadlifts",
                    "Lat Pulldowns",
                    "Barbell Rows",
                    "Dumbbell Rows",
                    "Pullovers",
                    "Dumbbell Shrugs",
                    "Dumbbell Preacher Curls"
                };
            }
            else if (programType == "Leg")
            {
                workouts = new List<string>
                {
                    "Leg Press",
                    "Hack Squats",
                    "Leg Extension",
                    "Leg Curl",
                    "Lunges",
                    "Standing Calf Raises",
                    "Squats",
                    "Deadlifts"
                };
            }

            Workouts(workouts);

            Console.Write("Enter the number of sets: ");
            int sets = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the number of reps: ");
            int reps = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("");
            Console.WriteLine($"You performed {reps} reps of {sets} sets for each workout.");
        }

        static void Workouts(List<string> workouts)
        {
            Console.WriteLine(" ");
            for (int i = 0; i < workouts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {workouts[i]}");
            }
        }
    }
