public class TimeOfDay : ITimeOfDayController
{
    public string GetCurrentTimeOfDay()
    {
        int currentHour = DateTime.Now.Hour;
        string timeOfDay;

        switch (currentHour)
        {
            case int hour when hour >= 6 && hour < 12:
                timeOfDay = "morning";
                break;
            case int hour when hour >= 12 && hour < 18:
                timeOfDay = "afternoon";
                break;
            case int hour when hour >= 18 && hour < 24:
                timeOfDay = "evening";
                break;
            default:
                timeOfDay = "night";
                break;
        }

        return $"It's currently {timeOfDay}.";
    }
}