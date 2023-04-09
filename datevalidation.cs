using System;

public class datevalidation
{
    public static void Main()
    {
        int year, month, day;



        Console.WriteLine("Enter year (between 2000 and 2050):");


        year = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter month between (1-12):");
        month = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Enter day between (1-31):");
        day = Convert.ToInt32(Console.ReadLine());

        if (year < 2000 || year > 2050)
        {
            Console.WriteLine("Invalid year. Please enter a year between 2000 and 2050.");
        }
        else if (month < 1 || month > 12)
        {
            Console.WriteLine("Invalid month. Please enter a month between 1 and 12.");
        }
        else if (day < 1 || day > 31)
        {
            Console.WriteLine("Invalid day. Please enter a day between 1 and 31.");
        }
        else if (day > DateTime.DaysInMonth(year, month))
        {
            Console.WriteLine("Invalid date. The month you entered only has " + DateTime.DaysInMonth(year, month) + " days.");
        }
        else
        {
            Console.WriteLine("Valid date.");
        }
    }
}