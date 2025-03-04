// See https://aka.ms/new-console-template for more information
using System.Text;

Console.WriteLine("S1 longest repeat: " + LongestRepeat("abcakbo"));
Console.WriteLine("S2 longest repeat: " + LongestRepeat("4asbd 15"));
Console.WriteLine("S3 longest repeat: " + LongestRepeat("aabbccddeeff"));
//have numbers on repeat
Console.WriteLine("S4 longest repeat: " + LongestRepeat("abc12abcd123"));

string LongestRepeat(string s)
{
    var countAppeared = new Dictionary<char, int>();

    foreach (char c in s)
    {
        if (char.IsLetter(c))
        {
            if (!countAppeared.ContainsKey(c))
            {
                countAppeared[c] = 0;
            }
            countAppeared[c]++;
        }
    }

    var result = new StringBuilder();
    foreach (char c in s)
    {
        if (countAppeared.ContainsKey(c) && countAppeared[c] > 1)
        {
            result.Append(c);
        }
    }

    return result.Length == 0 ? "" : result.ToString();
}