namespace PZ_13
{
    internal class Program
    {
        static string array(string[] m)
        {
            int a = m.Length;
            string max = m[1];
            for (int i = 0; i < m.Length; i++)
            {
                if (m[i].Length > m[1].Length)
                    max = m[i];
            }
            return max;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Введите количество строк");
            int b = int.Parse(Console.ReadLine());
            string[] B = new string[m];
            for (int i = 0; i < m; i++)
            {
                m[i] = Console.ReadLine();
            }

            Console.WriteLine($"Самая больша строка " + array(B) );
            Console.ReadLine();
        }
    }
}