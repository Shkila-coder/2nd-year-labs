namespace Lab8_5_Cons;

public class Date
{
    public event Action InvalidDate;
    public event Action SuspiciousDate;

    private static readonly int[] DaysInMonth = { 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31 };
    private static readonly string[] MonthsNames = { "January", "February", "March", "April", "May", "June", "July", "August", "September", "October", "November", "December" };

    private int day;
    public int Day
    {
        get { return day; }
        set
        {
            if (value < 1 || value > (Month == 2 && IsLeapYear(Year) ? 29 : DaysInMonth[Month - 1]))
            {
                InvalidDate?.Invoke();
                return;
            }

            if (value > 28)
            {
                SuspiciousDate?.Invoke();
            }

            day = value;
        }
    }

    private int month;
    public int Month
    {
        get { return month; }
        set
        {
            if (value < 1 || value > 12)
            {
                InvalidDate?.Invoke();
                return;
            }

            if (value > 12)
            {
                SuspiciousDate?.Invoke();
            }

            month = value;
        }
    }

    private int year;
    public int Year
    {
        get { return year; }
        set
        {
            if (value <= 0)
            {
                InvalidDate?.Invoke();
                return;
            }

            if (value > 2050)
            {
                SuspiciousDate?.Invoke();
            }

            year = value;
        }
    }

    public Date(int day, int month, int year)
    {
        Month = month;  // Сначала устанавливаем месяц и год
        Year = year;
        Day = day;      // Потом устанавливаем день, т.к. он зависит от месяца и года
    }

    private static bool IsLeapYear(int year)
    {
        return year % 4 == 0 && (year % 100 != 0 || year % 400 == 0);
    }

    public Date Next()
    {
        var day = Day + 1;
        var month = Month;
        var year = Year;

        if (day > DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0))
        {
            day = 1;
            month++;
        }

        if (month > 12)
        {
            month = 1;
            year++;
        }

        return new Date(day, month, year);
    }

    public Date Prev()
    {
        var day = Day - 1;
        var month = Month;
        var year = Year;

        if (day < 1)
        {
            month--;
            if (month < 1)
            {
                month = 12;
                year--;
            }

            day = DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0);
        }

        return new Date(day, month, year);
    }

    public bool IsLeapYear()
    {
        return IsLeapYear(Year);
    }

    public override string ToString()
    {
        return $"{Day} {MonthsNames[Month - 1]} {Year} г.";
    }
}

/*public static Date operator +(Date d1, Date d2)
{
    int day = d1.Day + d2.Day;
    int month = d1.Month + d2.Month;
    int year = d1.Year + d2.Year;
    return NormalizeDate(day, month, year);
}

public static Date operator -(Date d1, Date d2)
{
    int day = d1.Day - d2.Day;
    int month = d1.Month - d2.Month;
    int year = d1.Year - d2.Year;
    return NormalizeDate(day, month, year);
}

public static Date operator +(Date date, int days)
{
    return NormalizeDate(date.Day + days, date.Month, date.Year);
}

public static Date operator -(Date date, int days)
{
    return NormalizeDate(date.Day - days, date.Month, date.Year);
}*/

    /*private static Date NormalizeDate(int day, int month, int year)
    {
        while (day > DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0))
        {
            day -= DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0);
            month++;
            if (month > 12)
            {
                month = 1;
                year++;
            }
        }

        while (day <= 0)
        {
            month--;
            if (month <= 0)
            {
                month = 12;
                year--;
            }
            day += DaysInMonth[month - 1] + (month == 2 && IsLeapYear(year) ? 1 : 0);
        }

        return new Date(day, month, year);
    }*/

    
//}