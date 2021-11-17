using System;
using System.Drawing;
using BasicsOOP.Bank;
using BasicsOOP.Basics;
using BasicsOOP.Geometry;
using Buildings;
using Point = BasicsOOP.Geometry.Point;
using Rectangle = BasicsOOP.Geometry.Rectangle;

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

            //Test properties
            Console.WriteLine( $"Тип банковского счета: {bankAccount2.BankAccountType}, номер счета: {bankAccount2.Number}, баланс: {bankAccount2.Balance}");

            //Test Withdraw
            bankAccount3.Withdraw(50000);

            //Test Deposit
            bankAccount1.Deposit(30000);
            bankAccount1.Deposit(20000);

            //Test Transfer
            bankAccount3.TransferTo(bankAccount4, 10000);

            Console.WriteLine();

            //Revers string
            var stringOperations = new StringsOperations();
            Console.WriteLine(stringOperations.Reverse("new words"));

            Console.WriteLine();

            //Emails
            var contactsPath = "D:\\contacts.txt";
            var emailsPath = "D:\\emails.txt";
            var emails = stringOperations.GetEmailsFromContacts(contactsPath);
            emails.ForEach(Console.WriteLine);
            stringOperations.SaveEmails(emails, emailsPath);

            Console.WriteLine();

            //Buildings
            var building1 = Creator.CreateBuilding(30, 10,30,1);
            var building2 = Creator.CreateBuilding(20,5,10,2);
            var building3 = Creator.CreateBuilding(height: 5.0f);
            var building4 = Creator.CreateBuilding(flats: 30);

            //Remove by id
            Creator.RemoveBuildingById(building2.Id);

            var buildings = Creator.GetBuildingsList();
            foreach (var building in buildings)
            {
                Console.WriteLine(building.ToString());
                Console.WriteLine();
            }

            //Rational numbers
            var r1 = new RationalNumber(2, 3);
            var r2 = new RationalNumber(3, 2);

            Console.WriteLine($"Равно?: {r1 == r2}");
            Console.WriteLine($"Не равно?: {r1 != r2}");
            Console.WriteLine($"Сумма: {r1 + r2}");
            Console.WriteLine($"Разность: {r1 - r2}");
            Console.WriteLine($"Инкремент: {++r1}");
            Console.WriteLine($"Декремент: {--r1}");
            Console.WriteLine($"Меньше?: {r1 < r2}");
            Console.WriteLine($"Больше?: {r1 > r2}");
            Console.WriteLine($"Меньше или равно?: {r1 <= r2}");
            Console.WriteLine($"Больше или равно?: {r1 >= r2}");
            Console.WriteLine($"Умножение: {r1 * r2}");
            Console.WriteLine($"Деление: {r1 / r2}");
            Console.WriteLine($"Остаток от деления: {r1 % r2}");

            Console.WriteLine();

            //Complex numbers
            var c1 = new ComplexNumber(4, 6);
            var c2 = new ComplexNumber(3, 7);

            Console.WriteLine($"Равно?: {c1 == c2}");
            Console.WriteLine($"Не равно?: {c1 != c2}");
            Console.WriteLine($"Сумма: {c1 + c2}");
            Console.WriteLine($"Разность: {c1 - c2}");
            Console.WriteLine($"Умножение: {c1 * c2}");

            Console.WriteLine();

            //Банковский счет
            Console.WriteLine($"Банковские счета для сравнения:\n{bankAccount2}\n{bankAccount3}");
            Console.WriteLine($"Балансы банковских счетов равны?: {bankAccount2 == bankAccount3}");
            Console.WriteLine($"Балансы банковских счетов не равны?: {bankAccount2 != bankAccount3}");
            bankAccount3.Deposit(10000);
            Console.WriteLine($"Балансы банковских счетов равны?: {bankAccount2 == bankAccount3}");

            Console.WriteLine();

            //Геометрические фигуры
            var point = new Point(1,1,false,Color.Red);
            var circle = new Circle(5, 5, true, Color.Blue, 5);
            var rect = new Rectangle(1, 2, true, Color.Aqua, 3, 4);

            point.Print();
            Console.WriteLine();

            circle.Print();
            Console.WriteLine();

            rect.Print();
            Console.WriteLine();

            point.MoveX(3);
            point.MoveY(1);

            circle.MoveX(4);
            circle.MoveY(2);

            rect.MoveX(1);
            rect.MoveY(3);

            Console.WriteLine();

            //Шифрование

        }

    }
}
