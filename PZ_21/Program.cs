﻿using System;

namespace PZ_21
{
    class Program
    {
        static void Main(string[] args)
        {
            Package package1 = new Package("Anton Schmid", "Farid Safiev", "Chkalova 49", DateTime.Now, "Parcel");
            package1.GetPackageInfo();

            Package package2 = new Package("Kirill Petashvili", "Kirill Abelgans", "Chkalova 52", new DateTime(2022, 12, 31), "Letter");
            package2.GetPackageInfo();

            Package package3 = new Package("Pavel Levchenko", "Arina Zadorozhnaya", "Gagarin 42", DateTime.Now, "Express");
            package3.GetPackageInfo();

            Package package4 = new Package("Violette Chevtaykina", "Ilya Tulintsev", "Komsomolskaya 32", new DateTime(2022, 11, 15), "Courier");
            package4.GetPackageInfo();
        }
    }
}