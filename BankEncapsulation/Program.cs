using BankEncapsulation;
using System.Collections.Generic;

var list = new List<string>();
var account = new BankAccount();

account.Deposit(1000);
Console.WriteLine(account.GetBalance());