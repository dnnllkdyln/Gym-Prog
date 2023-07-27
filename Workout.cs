public class Workout
{
    public string WorkoutNum { get; set; }
    public string Equipment { get; set; }
    public string ProgramType { get; set; }
    public string WorkoutName { get; set; }
    public int NumberOfSets { get; set; }
    public int NumberOfReps { get; set; }

    public Workout(string workoutNum, string equipment, string programType, string workoutName, int numberOfSets, int numberOfReps)
    {
        WorkoutNum = workoutNum;
        Equipment = equipment;
        ProgramType = programType;
        WorkoutName = workoutName;
        NumberOfSets = numberOfSets;
        NumberOfReps = numberOfReps;
    }
}
