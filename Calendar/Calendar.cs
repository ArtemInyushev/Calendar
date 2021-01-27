using System;

namespace Calendar {
    public class Calendar {
        public static DateTime[,] getCalendar(DateTime date) {
            DateTime first = new DateTime(date.Year, date.Month, 1);
            DateTime[,] calendar = new DateTime[6, 7];
            int currentDay = (int)first.DayOfWeek;
            DateTime startDate = first.AddDays(-currentDay);
            for(int i = 0; i < 6; i++) {
                for(int j = 0; j < 7; j++) {
                    startDate = startDate.AddDays(1);
                    calendar[i, j] = startDate;
                }
            }
            return calendar;
        }
    }
}
