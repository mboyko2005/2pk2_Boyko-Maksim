using System;

namespace BankLibrary
{
	public delegate void AccountStateHandler(object sender, AccountEventArgs e);

	public class AccountEventArgs
	{
		public string Message { get; private set; }
		public decimal Sum { get; private set; }

		public AccountEventArgs(string message, decimal sum)
		{
			Message = message;
			Sum = sum;
		}
	}
}
