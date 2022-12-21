using System.IO;
using System.Text;
using static System.Net.WebRequestMethods;

namespace PZ_16
{
    internal class Program
    {
        static void Main(string[] args)
        {
            FileStream file1 = new FileStream(@"D:\input.txt", FileMode.Create);
            StreamWriter writer = new StreamWriter(file1);
            byte[] array = new byte[100];
            Random rnd = new Random();
            for (byte i = 0; i < 100; i++)
            {
                array[i] = (byte)rnd.Next(1, 100);
                writer.WriteLine(array[i]);
            }
            writer.Close();

            FileStream file2 = new FileStream(@"D:\output.txt", FileMode.Create);
            StreamWriter writer2 = new StreamWriter(file2);
            writer2.WriteLine("Наименьшее число в файле input.txt: " + array.Min());
            writer2.WriteLine("Наибольшее число в файле input.txt: " + array.Max());
            writer2.Close();
        }
    }
}