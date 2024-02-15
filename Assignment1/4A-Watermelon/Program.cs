{
    int w = int.Parse(Console.ReadLine());

    string result = CanDivideWatermelon(w);

    Console.WriteLine(result);
}

static string CanDivideWatermelon(int w)
{
    if (w < 2 || w % 2 != 0)
        return "NO";
    else return "YES";

}
