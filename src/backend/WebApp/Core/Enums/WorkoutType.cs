namespace Core.Enums;

public enum WorkoutType
{
    // Нечётные: повторения
    Pushups = 1,
    Pullups = 3,
    Squats = 5,
    SitUps = 7,
    BenchPress = 9,
    Lunges = 11,
    Burpees = 13,
    Dips = 15,
    KettlebellSwings = 17,
    BicepCurls = 19,
    JumpRope = 21,

    // Чётные: расстояние
    Run = 2,
    TreadmillRun = 4,
    Cycling = 6,
    Swimming = 8,
    Rowing = 10,
    StairClimbing = 12,
    Elliptical = 14,
    Walking = 16
}