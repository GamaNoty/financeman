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

    }
}
