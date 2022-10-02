namespace pz_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int A = Convert.ToInt32(Console.ReadLine());
            int count = 2;
            int prev = 1;
            int next = 1;
            int step = 0;

            while (true)
            {
                step = prev;
                prev = next;
                next += step;
                count++;
                if (next == A)
                {
                    Console.WriteLine(count);
                    break;
                }
                else if (next > A)
                {
                    Console.WriteLine(-1);
                    break;
                }
            }
        }
    }
}