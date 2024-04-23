namespace ConsoleReborn.AccountBook;

public class AccountBook
{
    private string username;
    private string phoneNumber;
    private string data;
    public string? GetPhoneNumber()
    {
        Console.WriteLine("Enter your number: ");
        phoneNumber = Console.ReadLine();
        return phoneNumber;
    }
    
    public string? GetUsername()
    {
        Console.WriteLine("Enter your name: ");
        username = Console.ReadLine();
        return username;
    }

    public void SaveData(string username, string phoneNumber, object data)
    {
        Console.WriteLine("Saving Data...");
    }

    public void CheckIfUserExist (object user, object data)
    {
        Console.WriteLine("Checking info...");
    }
}