namespace Enumerations
{
    internal class Enumerations
    {
        static void Main(string[] args)
        {

            // asec sheidzleba
            string weekDayName = WeekDay.Friday.ToString();

            // asec sheidzleba
            WeekDay day = WeekDay.Saturday;
            Console.WriteLine(weekDayName);
            Console.WriteLine(day);

            // ase romeli dgea amovagdebt magas  meramdene dgea anu. saturday dabechdavs 5 s
            Console.WriteLine((int)day);
        }
    }

    enum WeekDay
    {
        Monday,
        Tuesday,
        Wednesday,
        Thursday,
        Friday,
        Saturday,
        Sunday = 60  // ase vanicheb sundays 6 is nacvlad 60 s 
    }
}