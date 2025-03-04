// See https://aka.ms/new-console-template for more information
using System.Text;

int lenghth = 14;
string generateRandomString = GenerateRandomString(lenghth);
Console.WriteLine("Generating random string: " + generateRandomString);

string GenerateRandomString(int lenghth)
{
    string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopqrstuvwxyz0123456789";
    StringBuilder sb = new StringBuilder();
    Random random = new Random();

    for (int i = 0; i < lenghth; i++)
    {
        sb.Append(chars[random.Next(chars.Length)]);
    }

    return sb.ToString();
}