
int[] numbers = [23, 44, 23, 6, 78];
int[] numbers2 = [38, 5, 39, 58, 68, 57];

double result1 = CalcualteAverage(numbers);
double result2 = CalcualteAverage(numbers2);


double CalcualteAverage(int[] numbers)
{
    double sum = 0;

    for (int i = 0; i < numbers.Length; i++)
    {
        sum += numbers[i];
    }

    double average = sum / numbers.Length;

    return average;
}
