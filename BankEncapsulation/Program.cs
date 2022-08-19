using BankEncapsulation;
using System.Collections.Generic;


var account = new BankAccount();

account.Deposit(1000);
Console.WriteLine(account.GetBalance());

account.Withdraw(500);
Console.WriteLine(account.GetBalance());


account.WorkCheck(300);
