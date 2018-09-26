using System;

namespace SkillsawDateTimeTask
{
    internal class Program
    {
        private static void Main()
        {
            const string mysqlDateFormat = "yyyy-MM-dd";

            //task does not specify should time be local or UTC so i assume a local is fine
            var now = DateTimeOffset.Now;
            var nextMonthFifteenthDay = now.AddMonths(1).AddDays(15 - now.Day);
            var prevMonthFifteenthDay = now.AddMonths(-1).AddDays(15 - now.Day);

            Console.WriteLine(nextMonthFifteenthDay.ToString(mysqlDateFormat));
            Console.WriteLine(prevMonthFifteenthDay.ToString(mysqlDateFormat));

            Console.ReadLine();
        }
    }
}
