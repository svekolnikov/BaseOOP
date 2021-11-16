using System;
using BasicsOOP.Bank;
using BasicsOOP.Basics;
using Buildings;

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
        }
    }
}
