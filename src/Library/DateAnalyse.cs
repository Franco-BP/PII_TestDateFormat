namespace TestDateFormat;

public static class DateAnalyse
{
    public static bool ValidDate(int days, int month, int year)
    {
        bool check = true;
        while (check)
        {
            check = (month > 0) & (days > 0);
            if (month == 2)
                if ((year % 400 == 0) | ((year % 4 == 0) & (year % 100 != 0)))
                    check = days <= 29;
            else if (month == (1 | 3 | 5 | 7 | 8 | 10 | 12))
                check = days <= 31;
            else
                check = days <=30;
            return check;
        }
        return check;
    }
}
