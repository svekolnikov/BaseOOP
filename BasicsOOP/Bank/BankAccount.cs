using System;
using System.Threading.Channels;

namespace BasicsOOP.Bank
{
    public class BankAccount : IEquatable<BankAccount>
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

        public BankAccountType BankAccountType { get; }
        public long Number { get; }
        public decimal Balance { get; private set; }

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



        public static bool operator ==(BankAccount acc1, BankAccount acc2)
        {
            return acc1?.Balance == acc2?.Balance ;
        }

        public static bool operator !=(BankAccount acc1, BankAccount acc2)
        {
            return !(acc1 == acc2);
        }

        public override bool Equals(object? obj)
        {
            return Equals(obj as BankAccount);
        }

        public bool Equals(BankAccount other)
        {
            return other != null && Balance == other.Balance;
        }

        public override int GetHashCode()
        {
            unchecked
            {
                var hash = 17;
                hash = hash * 23 + Number.GetHashCode();
                hash = hash * 23 + Balance.GetHashCode();
                hash = hash * 23 + BankAccountType.GetHashCode();
                return hash;
            }
        }

        public override string ToString()
        {
            return $"Тип банковского счета: {BankAccountType}, номер счета: {Number}, баланс: {Balance}";
        }
    }
}
