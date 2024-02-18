{
    string s = Console.ReadLine().Trim();
    Console.WriteLine(s.Contains("0000000") || s.Contains("1111111") ? "YES" : "NO");
}