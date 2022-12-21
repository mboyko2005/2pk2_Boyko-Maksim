namespace PZ_18_2_
{
    class Program
    {
        enum Holidays
        {
            spring,
            autumn,
            summer,
            winter
        }

        static void TellAboutHolidays(Holidays days)
        {
            switch (days)
            {
                case Holidays.summer:
                    Console.WriteLine(">> 01.06 Международный день защиты детей в России\r\n>> 11.06 День пивовара в России \r\n>> 12.06 День России\r\n>> 10.07 День рыбака в России \r\n>> 19.07 День пирожков с малиновым вареньем");
                    break;
                case Holidays.winter:
                    Console.WriteLine(">>09.12 День Героев Отечества\r\n>> 14.01 Старый Новый год \r\n >> 25.01 День студента");
                    break;
                case Holidays.autumn:
                    Console.WriteLine(">> 01.09 День знаний\r\n>>03.09 День окончания Второй мировой войны\r\n>> 11.09 День танкиста  ");
                    break;
                case Holidays.spring:
                    Console.WriteLine(">> 08.03 Международный женский день\r\n 01.04 День труда\r\n>> 09.04 День Победы");
                    break;
            }
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Введите сезон");
            string days = Console.ReadLine();

            if (days == "summer")
            {
                TellAboutHolidays(Holidays.summer);
            }
            if (days == "winter")
            {
                TellAboutHolidays(Holidays.winter);
            }
            if (days == "spring")
            {
                TellAboutHolidays(Holidays.spring);
            }
            if (days == "autumn")
            {
                TellAboutHolidays(Holidays.autumn);

            }
        }
    }
}