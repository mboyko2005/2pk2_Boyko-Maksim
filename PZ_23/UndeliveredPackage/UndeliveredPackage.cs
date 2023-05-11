using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace PZ_23
{
	internal class UndeliveredPackage: Package
	{
        public string Reason { get; set; }
		public override void GetPackageInfo()
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
