using System.Text;

StringBuilder sb = new StringBuilder();

string s = "hello world";
string y = s;
y = "dhaka";

Console.WriteLine(s[6]);

sb.Append(s);
sb[6] = 'W';

Console.WriteLine(sb);

string result = sb.ToString();
