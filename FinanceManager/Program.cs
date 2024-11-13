using System;
using System.Collections.Generic;
using System.Globalization;
using System.IO;
using CsvHelper;
using CsvHelper.Configuration;

namespace PersonalFinanceManager
{
    public class Transaction
    {
        public string? Type { get; set; }
        public string? Category { get; set; }
        public decimal Amount { get; set; }
        public DateTime Date { get; set; }
        public string? Notes { get; set; }
    }

    class Program
    {
        static List<Transaction> transactions = new List<Transaction>();
        const string CsvFile = "finance_data.csv";

        static void Main(string[] args)
        {
            LoadTransactions();
            while (true)
            {
                Console.WriteLine("Personal Finance Manager");
                Console.WriteLine("1. Add Income");
                Console.WriteLine("2. Add Expense");
                Console.WriteLine("3. View Balance");
                Console.WriteLine("4. Generate Monthly Report");
                Console.WriteLine("5. Edit Transaction");
                Console.WriteLine("6. Delete Transaction");
                Console.WriteLine("7. Backup Data");
                Console.WriteLine("8. Restore Data");
                Console.WriteLine("9. Exit");

                string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        AddTransaction("Income");
                        break;
                    case "2":
                        AddTransaction("Expense");
                        break;
                    case "3":
                        ViewBalance();
                        break;
                    case "4":
                        GenerateReport();
                        break;
                    case "5":
                        EditTransaction();
                        break;
                    case "6":
                        DeleteTransaction();
                        break;
                    case "7":
                        BackupData();
                        break;
                    case "8":
                        RestoreData();
                        break;
                    case "9":
                        return;
                    default:
                        Console.WriteLine("Invalid option. Please select a valid option.\n");
                        break;
                }

            }
        }
        static void AddTransaction(string type)
        {
            Console.Write("Enter amount: ");
            decimal amount = decimal.Parse(Console.ReadLine());
            Console.Write("Enter category: ");
            string category = Console.ReadLine();
            Console.Write("Enter date (dd-mm-yyyy): ");
            DateTime date = DateTime.ParseExact(Console.ReadLine(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
            Console.Write("Notes (optional): ");
            string notes = Console.ReadLine();

            Transaction transaction = new Transaction
            {
                Type = type,
                Amount = amount,
                Category = category,
                Date = date,
                Notes = notes
            };

            transactions.Add(transaction);
            SaveTransactions();
            Console.WriteLine($"{type} added successfully!\n");
        }
        static void ViewBalance()
        {
            decimal totalIncome = 0, totalExpense = 0;
            foreach (var t in transactions)
            {
                if (t.Type == "Income")
                    totalIncome += t.Amount;
                else if (t.Type == "Expense")
                    totalExpense += t.Amount;
            }
            Console.WriteLine($"Your current balance is: {totalIncome - totalExpense}\n");
        }
    }
