using System;

namespace DateTimeHelperLibrary
{
    public class DateTimeHelper
    {
        // Method to add days to a given date
        public DateTime AddDaysToDate(DateTime date, int days)
        {
            return date.AddDays(days);
        }

        // Method to get current date in a formatted string
        public string GetCurrentDateFormatted()
        {
            return DateTime.Now.ToString("yyyy-MM-dd");
        }

        // Method to calculate the difference in days between two dates
        public int GetDateDifference(DateTime startDate, DateTime endDate)
        {
            return (endDate - startDate).Days;
        }
    }
}
