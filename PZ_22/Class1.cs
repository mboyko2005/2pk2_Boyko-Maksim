using System;

namespace PZ_22
{
    class Package
    {
        public string NameSender { get; set; }
        public string NameReceiver { get; set; }
        public string Address { get; set; }
        public DateTime ReceiptDate { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        private static int totalPackages = 0;
        private static double totalWeight = 0;

        public Package(string отправитель, string получателя, string адрес, DateTime receiptDate, string тип)
        {
            NameSender = отправитель;
            NameReceiver = получателя;
            Address = адрес;
            ReceiptDate = receiptDate;
            Type = тип;

            totalPackages++;
            totalWeight += Weight;
        }

        public static int TotalPackages
        {
            get
            {
                return totalPackages;
            }
        }

        public static double TotalWeight
        {
            get
            {
                return totalWeight;
            }
        }

        public void GetPackageInfo()
        {
            Console.WriteLine("Имя отправителя " + NameSender);
            Console.WriteLine("Получатель " + NameReceiver);
            Console.WriteLine("Адрес получения: " + Address);
            Console.WriteLine("Дата: " + ReceiptDate.ToString("dd.MM.yyyy"));
            Console.WriteLine("Тип отправки: " + Type);
            Console.WriteLine("Вес поссылки: " + Weight + " kg");
        }
    }
}
