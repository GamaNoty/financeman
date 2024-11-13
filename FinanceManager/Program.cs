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
    }
