// See https://aka.ms/new-console-template for more information

int? x = null;

if(!x.HasValue)
    x = int.Parse(Console.ReadLine());

if(x.HasValue)
    Console.WriteLine(x.Value);

int y = x.Value;

int z = x ?? 5;

x ??= 5;

string? p = x?.ToString();



