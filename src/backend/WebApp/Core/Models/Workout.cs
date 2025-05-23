using Core.Enums;

namespace Core.Models;

public class Workout
{
    public long Id { get; set; }
    public WorkoutType WorkoutType { get; set; }
    public int Duration { get; set; }
    public int AverageHeartRate { get; set; }
    public int CaloriesBurnt { get; set; }

    public int? Sets { get; set; }
    public int? RepsPerSets { get; set; }

    public int? Distance { get; set; }
}