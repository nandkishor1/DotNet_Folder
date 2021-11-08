using System;

namespace EnumProject
{
    public enum Days
    {
        Monday=1, Tuesday=11, Wednesday=21, Thursday=31,Friday=41
    }
    class Program
    {
        public static Days MeetingDate{ get; set; } = Days.Monday;
        static void Main(string[] args)
        {
            //Days d = Days.Friday;
            //Console.WriteLine((int)d);

            //foreach (int i in Enum.GetValues(typeof(Days)))
            //    Console.WriteLine(i);
            //foreach (string s in Enum.GetNames(typeof(Days)))
            //    Console.WriteLine(s);

            Console.WriteLine(MeetingDate);
            MeetingDate = Days.Friday;
            Console.WriteLine(MeetingDate);
        }
    }
}
