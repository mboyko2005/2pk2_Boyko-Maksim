using System.Text.RegularExpressions;

namespace PZ_19
{
	internal class Program
	{
		static string text1 = @"E:\Text1.txt";
		static string text2 = @"E:\Text2.txt";
		static void Main(string[] args)
		{
			string text = OpenText(text1);
			Console.WriteLine("Текст 1");
			Console.WriteLine();
			Regex regex = new Regex(@"([0-9]\s[А-Я][а-я]+\s[А-Я][а-я]+\s.7\s.)|([0-9]\s[А-Я][а-я]+\s.7\s.)");
			foreach (Match match in regex.Matches(text))
			{
				string[] result = match.Value.Split(" ");
				if (result.Length == 5)
				{
					Console.WriteLine($"{result[1]} {result[2]}");
				}
				else
				{
					Console.WriteLine(result[1]);
				}

			}
			Console.WriteLine("Текст 2");
			Console.WriteLine();
			text = OpenText(text2);
			Regex regex2 = new Regex(@"([0-9]{1,3}[\.]){3}[0-9]{1,3}");
			foreach (Match match in regex2.Matches(text))
			{
				Console.WriteLine(match.Value);
			}
		}
		static string OpenText(string path)
		{
			using (FileStream stream = File.OpenRead(path))
			{
				StreamReader reader = new StreamReader(stream);
				string text = reader.ReadToEnd();
				return text;
			}
		}
	}
}