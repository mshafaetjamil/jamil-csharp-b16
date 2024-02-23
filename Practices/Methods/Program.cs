
    string[] numberString = (Console.ReadLine().Split(' '));
    double[] numbers = new double[numberString.Length];
    for (int i = 0; i < numberString.Length; i++)
    {
        numbers[i] = double.Parse(numberString[i]);
    }

    string[] numberString2 = (Console.ReadLine().Split(' '));
    double[] numbers2 = new double[numberString2.Length];
    for (int i = 0; i < numberString2.Length; i++)
    {
        numbers2[i] = double.Parse(numberString2[i]);
    }
    {
        double result = CalculateAverage(numbers);
        double result2 = CalculateAverage(numbers2);
        Console.WriteLine(result);
        Console.WriteLine(result2);
    }



double CalculateAverage(double[] numbers)
{
    double sum = 0;
    int count = numbers.Length;
    for (int i = 0; i < count; i++)
    {
        sum += numbers[i];
    }
    double average = sum / count;
    return average;
}

//string[] numberString = Console.ReadLine().Split(' ');
//double[] numbers = new double[numberString.Length];
//for (int i = 0; i < numberString.Length; i++)
//{
//    numbers[i] = double.Parse(numberString[i]);
//}

//string[] numberString2 = Console.ReadLine().Split(' ');
//double[] numbers2 = new double[numberString2.Length];
//for (int i = 0; i < numberString2.Length; i++)
//{
//    numbers2[i] = double.Parse(numberString2[i]);
//}
//{ 
//double result = CalculateAverage(numbers);
//double result2 = CalculateAverage(numbers2);

//Console.WriteLine("Average of numbers: " + result);
//Console.WriteLine("Average of numbers2: " + result2);
//}    

// double CalculateAverage(double[] numbers)
//{
//    double sum = 0;
//    int count = numbers.Length;
//    for (int i = 0; i < count; i++)
//    {
//        sum += numbers[i];
//    }
//    double average = sum / count;
//    return average;
//}