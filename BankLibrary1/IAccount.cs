using System;

namespace BankLibrary
{
	public interface IAccount
	{
		void Put(decimal sum); // метод пополнения счета
		decimal Withdraw(decimal sum); // метод снятия со счета
	}
}
