using System;
using BasicsOOP.Bank;

namespace BasicsOOP
{
    class Program
    {
        static void Main(string[] args)
        {

            var bankAccount1 = new BankAccount();
            var bankAccount2 = new BankAccount(50000);
            var bankAccount3 = new BankAccount(90000, BankAccountType.Deposit);
            var bankAccount4 = new BankAccount(BankAccountType.Checking);

            Console.WriteLine(bankAccount1);
            Console.WriteLine(bankAccount2);
            Console.WriteLine(bankAccount3);
            Console.WriteLine(bankAccount4);

            Console.WriteLine( $"Тип банковского счета: {bankAccount2.BankAccountType}, номер счета: {bankAccount2.Number}, баланс: {bankAccount2.Balance}");

            bankAccount3.Withdraw(50000);

            bankAccount1.Deposit(30000);
            bankAccount1.Deposit(20000);
        }
    }
}
