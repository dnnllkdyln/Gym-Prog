using System;
using System.Collections.Generic;

public class Workout
{
    public string WorkoutNum { get; }
    public string Equipment { get; }
    public string ProgramType { get; }
    public string WorkoutName { get; }
    public int NumberOfSets { get; }
    public int NumberOfReps { get; }

    public Workout(string workOutNum, string equipment, string programType, string workoutName, int numberOfSets, int numberOfReps)
    {
        WorkoutNum = workOutNum;
        Equipment = equipment;
        ProgramType = programType;
        WorkoutName = workoutName;
        NumberOfSets = numberOfSets;
        NumberOfReps = numberOfReps;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        List<Workout> orders = new List<Workout>();

        orders.Add(new Workout("Workout1", "Barbell and Weight Bench", "Push", "Bench Press", 4, 5));
        orders.Add(new Workout("Workout2", "Dumbbell", "Pull", "Dumbbell Rows", 3, 10));
        orders.Add(new Workout("Workout3", "Leg Press Machine", "Leg", "Leg Press", 3, 15));

        foreach (Workout order in orders)
        {
            PrintWorkoutDetails(order);
        }
    }

    public static void PrintWorkoutDetails(Workout order)
    {
        string WorkoutDetails = 
                              $"   {order.WorkoutNum}\n" +
                              $"Equipment: {order.Equipment}\n" +
                              $"ProgramType: {order.ProgramType}\n" +
                              $"WorkoutName: {order.WorkoutName}\n" +
                              $"NumberOfSets: {order.NumberOfSets}\n" +
                              $"NumberOfReps: {order.NumberOfReps}\n";
        Console.Write(WorkoutDetails); 

    }
}
