
using System;
struct Worker
{
    public string Name;
    public string Position;
    public int Year;
}

class PZ_27
{
    static void Main(string[] args)
    {
        const int n = 10;
        Worker[] table = new Worker[n];

        // Ввод данных в массив table
        Console.WriteLine("Введите данные работников:");
        for (int i = 0; i < n; i++)
        {
            Console.Write("Фамилия и инициалы работника: ");
            table[i].Name = Console.ReadLine();
            Console.Write("Название занимаемой должности: ");
            table[i].Position = Console.ReadLine();
            Console.Write("Год поступления на работу: ");
            table[i].Year = int.Parse(Console.ReadLine());
        }

        // Сортировка массива table по фамилиям работников
        Array.Sort(table, (x, y) => x.Name.CompareTo(y.Name));

        // Вывод фамилий работников со стажем работы больше заданного значения
        Console.Write("Введите значение стажа работы: ");
        int experience = int.Parse(Console.ReadLine());
        bool found = false;
        Console.WriteLine("Фамилии работников со стажем работы больше {0}:", experience);
        foreach (Worker worker in table)
        {
            if (DateTime.Now.Year - worker.Year > experience)
            {
                Console.WriteLine(worker.Name);
                found = true;
            }
        }
        if (!found)
        {
            Console.WriteLine("Нет работников со стажем работы больше {0}", experience);
        }

        Console.ReadKey();
    }
}
