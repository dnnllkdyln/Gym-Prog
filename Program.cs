using System;
using System.Collections.Generic;

public class Program
{
    public static void Main(string[] args)
    {
        List<Workout> workouts = new List<Workout>
        {
            new Workout("Workout1", "Barbell and Weight Bench", "Push", "Bench Press", 4, 5),
            new Workout("Workout2", "Cable Machine", "Push", "Pushdown", 3, 12),
            new Workout("Workout3", "Pec Fly Machine", "Push", "Chest Fly", 3, 15),
            new Workout("Workout4", "Dumbbell", "Pull", "Dumbbell Rows", 3, 10),
            new Workout("Workout5", "Barbell and Weight Plates", "Pull", "Barbell Rows", 3, 10),
            new Workout("Workout6", "Cable Pulldowns", "Pull", "Lat PullDowns", 3, 15),
            new Workout("Workout7", "Leg Press Machine", "Leg", "Leg Press", 3, 15),
            new Workout("Workout8", "Cable Pulldowns", "Leg", "Back Squats", 2, 10),
            new Workout("Workout9", "Dumbbell", "Leg", "Lunges", 3, 15),
        };

        Console.WriteLine("Good day, gym enthusiasts! Welcome to Muscle Mania!");

        bool exit = false;
        while (!exit)
        {
            Console.WriteLine("\nPlease select the workout you'd like to do today: ");

            for (int i = 0; i < workouts.Count; i++)
            {
                Console.WriteLine($"{i + 1}. {workouts[i].WorkoutName}");
            }

            int choice = GetIntegerInput("\nEnter the number of your preferred workout (or 0 to exit):");

            if (choice >= 1 && choice <= workouts.Count)
            {
                Workout selectedWorkout = workouts[choice - 1];
                DisplayWorkoutDetails(selectedWorkout);
            }
            else if (choice == 0)
            {
                Console.WriteLine("\nThank you for stopping by, see us again!");
                exit = true;
            }
            else
            {
                Console.WriteLine("\nInvalid workout choice. Please try again.");
            }
        }
    }

    public static int GetIntegerInput(string message)
    {
        int input;
        Console.Write($"{message} ");
        while (!int.TryParse(Console.ReadLine(), out input))
        {
            Console.WriteLine("Invalid input. Please enter a valid number.");
            Console.Write($"{message} ");
        }
        return input;
    }

    public static void DisplayWorkoutDetails(Workout workout)
    {
        Console.WriteLine($"\nWorkout Number: {workout.WorkoutNum}");
        Console.WriteLine($"Equipment: {workout.Equipment}");
        Console.WriteLine($"Program Type: {workout.ProgramType}");
        Console.WriteLine($"Workout Name: {workout.WorkoutName}");
        Console.WriteLine($"Number of Sets: {workout.NumberOfSets}");
        Console.WriteLine($"Number of Reps: {workout.NumberOfReps}");
    }
}
