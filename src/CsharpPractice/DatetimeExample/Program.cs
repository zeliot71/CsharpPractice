// See https://aka.ms/new-console-template for more information

DateTime datetime = DateTime.Now;
DateTime dateTime2 = DateTime.UtcNow;
DateTime dateTime3 = new DateTime(2020,12,20,10,54,30,100);

Console.WriteLine($"Year after 600 days: {dateTime3.AddDays(600).Year}");
Console.WriteLine(dateTime2.DayOfWeek);
Console.WriteLine(dateTime2.DayOfYear);

Console.WriteLine(DateTime.IsLeapYear(dateTime3.Year));

int mnt = datetime.Minute;
int mnt2 = datetime.Second;
int mnt3 = datetime.Millisecond;
int mnt4 = datetime.Hour;

Console.WriteLine(mnt);
Console.WriteLine(mnt2);
Console.WriteLine(mnt3);
Console.WriteLine(mnt4);

Console.WriteLine(datetime);
Console.WriteLine(dateTime2);
Console.WriteLine(dateTime3);

