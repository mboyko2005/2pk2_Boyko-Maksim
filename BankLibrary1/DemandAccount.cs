﻿using BankLibrary;

public class DemandAccount : Account
{
	public DemandAccount(decimal sum, int percentage) : base(sum, percentage)
	{
	}
	protected internal override void Open()
	{
		base.OnOpened(new AccountEventArgs("Открыт новый счет до востребования! Id счета: " +
	   this._id, this._sum));
	}
}