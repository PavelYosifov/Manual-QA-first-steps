using BankAccountDemo;
using System;

internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("*** Dimo enters the bank ***");
        BankAccount DimoAccount = new BankAccount(500);
        Console.WriteLine($"Dimo has {DimoAccount.Amount}BGN in his bank account");
        DimoAccount.Deposit(300);
        Console.WriteLine($"Dimo has {DimoAccount.Amount}BGN in his bank account");
    }
}