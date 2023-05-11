using PZ_24;
using System;

namespace PZ_24
{
	class UndeliveredPackage : Package
	{
		public string Reason { get; set; }
		public UndeliveredPackage(string отправитель, string получатель, string адрес, DateTime receiptDate, string тип, string причина) : base(отправитель, получатель, адрес, receiptDate, тип)
		{
			Reason = причина;
		}
		public override void GetPackageInfo()
		{
			base.GetPackageInfo();
			Console.WriteLine("Причина недоставки: " + Reason);
		}
	}

	class UndeliveredPackageProgram
	{
		static void Main(string[] args)
		{
			UndeliveredPackage package1 = new UndeliveredPackage("Anton Schmid", "Farid Safiev", "Chkalova 49", DateTime.Now, "Parcel", "Неправильный адрес");
			package1.Weight = 2;
			package1.GetPackageInfo();

			UndeliveredPackage package2 = new UndeliveredPackage("Kirill Petashvili", "Kirill Abelgans", "Chkalova 52", new DateTime(2022, 12, 31), "Letter", "Отсутствие получателя");
			package2.Weight = 0.5;
			package2.GetPackageInfo();

			UndeliveredPackage package3 = new UndeliveredPackage("Pavel Levchenko", "Arina Zadorozhnaya", "Gagarin 42", DateTime.Now, "Express", "Ошибочное написание имени получателя");
			package3.Weight = 3;
			package3.GetPackageInfo();

			UndeliveredPackage package4 = new UndeliveredPackage("Violette Chevtaykina", "Ilya Tulintsev", "Komsomolskaya 32", new DateTime(2022, 11, 15), "Courier", "Посылка потеряна");
			package4.Weight = 1;
			package4.GetPackageInfo();
		}
	}
}