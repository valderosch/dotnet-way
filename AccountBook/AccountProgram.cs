namespace ConsoleReborn.AccountBook;

public class AccountProgram
{
    AccountBook accountBook = new AccountBook();

    public void PrintData()
    {
        var phoneData =accountBook.GetPhoneNumber();
        var usernameData = accountBook.GetUsername();
        Console.WriteLine("\nHere is your data, that will be added to book.\n_______________________________________");
        Console.WriteLine($"User: {usernameData} - {phoneData}");
    }
}

