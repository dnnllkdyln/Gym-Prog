using System;
using System.Collections.Generic;

namespace GymProgram
{
    class Program
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
                    while (true)
                    {
                        Console.WriteLine("-----------------------------------------");
                        Console.WriteLine("Here are the following programs: ");
                        Console.WriteLine("Enter G (Push)");
                        Console.WriteLine("Enter Y (Pull)");
                        Console.WriteLine("Enter M (Leg)");
                        Console.WriteLine("Enter 0 to exit...");

                        Console.WriteLine("Choose your option:");
                        userInput = Console.ReadLine();

                        switch (userInput)
                        {
                            case "G":
                                Console.WriteLine("Push Day: (3 Sets - 12 Reps)");

                                List<string> pushWorkouts = new List<string>
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

                                DisplayWorkouts(pushWorkouts);

                                Console.Write("Enter the number of sets: ");
                                int setsG = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the number of reps: ");
                                int repsG = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("");
                                Console.WriteLine($"You performed {repsG} reps of {setsG} sets for each workout.");
                                break;

                            case "Y":
                                Console.WriteLine("Pull Day: (3 Sets - 12 Reps)");

                                List<string> pullWorkouts = new List<string>
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

                                DisplayWorkouts(pullWorkouts);

                                Console.Write("Enter the number of sets: ");
                                int setsY = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the number of reps: ");
                                int repsY = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("");
                                Console.WriteLine($"You performed {repsY} reps of {setsY} sets for each workout.");
                                break;

                            case "M":
                                Console.WriteLine("Leg Day: (4 Sets - 15 Reps)");

                                List<string> legWorkouts = new List<string>
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

                                DisplayWorkouts(legWorkouts);

                                Console.Write("Enter the number of sets: ");
                                int setsM = Convert.ToInt32(Console.ReadLine());
                                Console.Write("Enter the number of reps: ");
                                int repsM = Convert.ToInt32(Console.ReadLine());

                                Console.WriteLine("");
                                Console.WriteLine($"You performed {repsM} reps of {setsM} sets for each workout.");
                                break;

                            case "0":
                                Console.WriteLine("Exiting program...");
                                break;
                            default:
                                Console.WriteLine("Invalid input!");
                                break;
                        }

                        if (userInput == "0")
                        {
                            break;
                        }
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

        static void DisplayWorkouts(List<string> workouts)
        {
            Console.WriteLine("Available workouts:");
            for (int i = 0; i < workouts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {workouts[i]}");
            }
        }
    }
}
