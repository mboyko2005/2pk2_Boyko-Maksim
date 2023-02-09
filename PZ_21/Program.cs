using System;

namespace PZ_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Package package1 = new Package("Антон Шмидт", "Фарид Сафиев", "Чкалова 49", DateTime.Now, "Parcel");
            package1.GetPackageInfo();

            Package package2 = new Package("Кирилл Петашвили", "Кирилл Абельганс", "Чкалова 52", new DateTime(2022, 12, 31), "Letter");
            package2.GetPackageInfo();

            Package package3 = new Package("Павел Левченко", "Арина Задорожняя", "Гагарина 42", DateTime.Now, "Express");
            package3.GetPackageInfo();

            Package package4 = new Package("Виолетта Чевтайкина", "Илья Тулинцев", "Комсомольская 32", new DateTime(2022, 11, 15), "Courier");
            package4.GetPackageInfo();
        }
    }
}
