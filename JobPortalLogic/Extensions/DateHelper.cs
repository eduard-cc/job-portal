using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JobPortalLogic.Extensions;

public static class DateHelper
{
    public static string GetRelativeTime(DateTime date)
    {
        DateTime dateTime = new DateTime(date.Year, date.Month, date.Day, 0, 0, 0);
        DateTime today = DateTime.Today;
        TimeSpan timeAgo = today - dateTime;
        int daysAgo = (int)timeAgo.TotalDays;

        if (daysAgo == 0)
        {
            return "today";
        }
        else if (daysAgo == 1)
        {
            return "yesterday";
        }
        else if (daysAgo < 7)
        {
            return $"{daysAgo} {(daysAgo == 1 ? "day" : "days")} ago";
        }
        else if (daysAgo < 14)
        {
            return "last week";
        }
        else if (daysAgo < 21)
        {
            return "2 weeks ago";
        }
        else
        {
            int weeks = daysAgo / 7;
            if (weeks < 5)
            {
                return $"{weeks} {(weeks == 1 ? "week" : "weeks")} ago";
            }
            else
            {
                int months = weeks / 4;
                return $"{months} {(months == 1 ? "month" : "months")} ago";
            }
        }
    }
}
