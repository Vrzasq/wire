namespace xmlObjectProvider.Services;

internal static class DateTimeExtensions
{
    public static (
        DateTime startDate,
        DateTime endDate
        )
        ToDobaHandlowa(this DateTime dateTime)
    {
        var startDate = new DateTime(dateTime.Ticks, DateTimeKind.Utc)
            .ToLocalTime()
            .Date;

        return (
            startDate: startDate,
            endDate: startDate.AddDays(1)
            );
    }
}
