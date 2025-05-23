using Core.Enums;

namespace Core.Extensions;

public static class WorkoutTypeExtensions
{
    public static bool IsDurationBased(this WorkoutType type)
    {
        return (int)type % 2 == 0;
    }

    public static bool IsRepetitionBased(this WorkoutType type)
    {
        return !type.IsDurationBased();
    }
}