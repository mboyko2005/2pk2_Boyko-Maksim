namespace Pz_20
{
	internal class Program
	{
		static string maks()
		{
			string puk = Console.ReadLine();
			string antonout = "";
			for (int i = 0; i < puk.Length; i++)
			{
				if (char.IsLower(puk[i]))
				{
					antonout += puk[i].ToString().ToUpper();

				}
				else
				{
					antonout += puk[i].ToString().ToLower();
				}

			}
			return antonout;
		}
		static void Main(string[] args)
		{
			Console.WriteLine(maks());
		}
	}
}