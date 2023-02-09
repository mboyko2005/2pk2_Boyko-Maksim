using System;
using System.Collections.Generic;
using System.Text;

namespace PZ_21
{
    class Package
    {
        public string nameDest { get; set; }
        public string nameSor { get; set; }
        public string address { get; set; }
        public DateTime receiptDate { get; set; }
        public string type { get; set; }

        public Package(string nameDest, string nameSor, string address, DateTime receiptDate, string type)
        {
            this.nameDest = nameDest;
            this.nameSor = nameSor;
            this.address = address;
            this.receiptDate = receiptDate;
            this.type = type;
        }

        public void GetPackageInfo()
        {
            Console.WriteLine("Destination name: " + nameDest);
            Console.WriteLine("Sender name: " + nameSor);
            Console.WriteLine("Address: " + address);
            Console.WriteLine("Receipt date: " + receiptDate);
            Console.WriteLine("Type: " + type);
        }
    }
}