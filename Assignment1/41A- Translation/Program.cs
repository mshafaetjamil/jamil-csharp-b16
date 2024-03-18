static bool IsReverse(string s, string t) => s.Equals(new string(t.ToCharArray().Reverse().ToArray()));

    string wordS = Console.ReadLine(); 

    string wordT = Console.ReadLine(); 

    Console.WriteLine(IsReverse(wordS, wordT) ? "YES" : "NO");
