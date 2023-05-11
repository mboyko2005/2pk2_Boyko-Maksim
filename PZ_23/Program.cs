namespace PZ_23
{
	internal class Program
	{
		static void Main(string[] args)
		{
			UndeliveredPackage undeliveredPackage = new UndeliveredPackage();
			undeliveredPackage.Reason = "Поломка";
			UndeliveredPackage undeliveredPackage1 = new UndeliveredPackage();
			undeliveredPackage1.Reason = "Заказчик уродец";
            Console.WriteLine(undeliveredPackage.Reason);
        }
	}
}