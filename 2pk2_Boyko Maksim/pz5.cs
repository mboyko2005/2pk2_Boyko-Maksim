namespace ConsoleApp13
{
    internal class pz5
    {
        static void Main(string[] args)
        {

            char simvol = 'h';
            Console.WriteLine("Задание 1");
            for (int i = 20; i <= 90; i += 2)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine("Задание 2");
            for (int i = 1; i <= 6; i++)
            {
                Console.WriteLine(simvol);
                simvol++;
            }
            Console.WriteLine("Задание 3");
            for (int i = 0; i < 6; i++)
            {
                for (int j = 0; j < 6; j++)
                {
                    Console.WriteLine('#');
                }
            }
            Console.WriteLine("Задание 4");
            for (int i = 0; i < 100; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            Console.WriteLine("Задание 5");
            for (int i = 4, j = 40; j - i >= 13; i++, j--)
            {
                Console.WriteLine(j - i);
            }
        }
    }
}


