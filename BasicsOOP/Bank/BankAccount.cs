using System;
using System.Threading.Channels;

namespace BasicsOOP.Bank
{
    public class BankAccount
    {
        private static long _number;

        public BankAccount()
        {
            BankAccountType = BankAccountType.Checking;
            if (_number == 0)
            {
                _number = 424277770000;
            }
            Number = ++_number;
            Balance = 0;
        }

        public BankAccount(decimal balance) : this()
        {
            Balance = balance;
        }

        public BankAccount(BankAccountType bankAccountType) : this()
        {
            BankAccountType = bankAccountType;
        }

        public BankAccount(decimal balance, BankAccountType bankAccountType) : this()
        {
            Balance = balance;
            BankAccountType = bankAccountType;
        }

        public BankAccountType BankAccountType { get; set; }
        public long Number { get; set; }
        public decimal Balance { get; set; }

        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Величина должна быть положительной.");
            }

            Balance += amount;
            Console.WriteLine($"Добавлено: {amount}. Остаток: {Balance}");
        }

        public void Withdraw(decimal amount)
        {
            if (amount > Balance)
            {
                throw new ArgumentOutOfRangeException(nameof(amount),"Недостаточно средств.");
            }
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Величина должна быть положительной.");
            }

            Balance -= amount;
            Console.WriteLine($"Снято: {amount}. Остаток: {Balance}");
        }

        public void TransferTo(BankAccount account, decimal amount)
        {
            account.Deposit(amount);
            Console.WriteLine($"Переведено: {amount}. Остаток: {Balance}");
        }

        public override string ToString()
        {
            return $"Тип банковского счета: {BankAccountType}, номер счета: {Number}, баланс: {Balance}";
        }
    }
}
