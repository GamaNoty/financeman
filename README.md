# Personal Finance Manager

This is a simple console-based personal finance manager developed as part of a school project. The application helps users manage their finances by tracking their income and expenses. It allows for viewing the current balance, generating monthly reports, and performing other actions such as adding, editing, and deleting transactions.

## Features

- **Add Income/Expense**: Add new income or expense transactions with details such as amount, category, date, and optional notes.
- **View Balance**: Displays the current balance by calculating total income minus total expenses.
- **Generate Monthly Report**: Generates a report showing the total income, total expense, and balance for a specified month and year.
- **Edit Transaction**: Allows editing of previously entered transactions, updating details like amount, category, date, and notes.
- **Delete Transaction**: Allows deleting any transaction from the list after confirming the action.
- **Backup and Restore Data**: The application supports backing up and restoring transaction data in JSON format.
- **CSV File Persistence**: Data is stored in a CSV file (`finance_data.csv`), ensuring persistence even after the application is closed.

## How to Use

1. **Download/Clone the Repository**:
   Clone this repository to your local machine or download the ZIP file.

2. **Run the Application**:
   - Open the project in Visual Studio or your preferred C# IDE.
   - Build and run the application.
   - Use the console menu to interact with the program.

3. **Menu Options**:
   - Add Income (Option 1)
   - Add Expense (Option 2)
   - View Balance (Option 3)
   - Generate Monthly Report (Option 4)
   - Edit Transaction (Option 5)
   - Delete Transaction (Option 6)
   - Backup Data (Option 7)
   - Restore Data (Option 8)
   - Exit (Option 9)

4. **Data Storage**:
   - The transactions are stored in a CSV file named `finance_data.csv`.
   - The application also allows backing up data to a JSON file and restoring it later.

## Prerequisites

- .NET 6.0 or higher.
- A C# IDE like Visual Studio.

## Dependencies

This project uses the following libraries:
- [CsvHelper](https://joshclose.github.io/CsvHelper/) for CSV file reading and writing.
- [Newtonsoft.Json](https://www.newtonsoft.com/json) for data serialization and deserialization for backup and restore.

To install dependencies, use the following commands in your terminal:
```bash
dotnet add package CsvHelper
dotnet add package Newtonsoft.Json
