
double sum = 0;

//int count = int.Parse(Console.ReadLine());

//for (int i = 0; i < count; i++)
//{
//    sum += int.Parse(Console.ReadLine());
//}

//int i = 0;
//while(i < count)
//{
//    sum += int.Parse(Console.ReadLine());
//    i++;
//}

//double average = sum / count;

//Console.WriteLine(average.ToString("0.000000"));

//while(average > 0)
//{
//    Console.WriteLine(average--.ToString("0.00000000000"));
//}

//for(;average > 0;)
//{
//    Console.WriteLine(average--.ToString("0.00000000000"));
//}

//int x = 0;

//while (x > 0)
//{
//    Console.WriteLine(x);
//    x++;
//}

//do
//{
//    Console.WriteLine(x);
//    //x++;

//} while (x > 0);


//while(true)
//{
//    string text = Console.ReadLine();

//    if (text == "end")
//        break;

//    if (text == "")
//        continue;

//    Console.WriteLine(text);
//}


int[] ages = [23, 63, 37, 46];

for (int i = 0; i < ages.Length; i++)
{
    Console.WriteLine(ages[i]);
}

foreach (int age in ages)
{
    Console.WriteLine(age);
}