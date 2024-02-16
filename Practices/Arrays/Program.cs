////string[] names = new string[size];
//names[0] = "jamil";
//names[1] = "uddin";
//names[2] = "hossain";
//names[3] = "jamal";


//{
//    string line = Console.ReadLine();
//    int size,size2 = 0;
//    bool success = false;
//    success = int.TryParse(line, out size);

//    if (success && size >0)
//    {
//        string[,] names = new string[size, size2];

//        for (int i = 0; i < size; i++)
//        {    
//            for(int j = 0; j < size2; j++)
//            {
//                names[i, j] = Console.ReadLine();
//            }

//        }
//        string middlePersonName = names[size / 2, size2/ 2];
//        Console.WriteLine(middlePersonName);
//    }
//    else
//    {
//        Console.WriteLine("Size is not in Correct Order");
//    }
//}



//2d Array
/*string line = Console.ReadLine();
int size, size2;
bool success = false;

        // Parsing the input string to get the number of rows
success = int.TryParse(line, out size);

if (success && size > 0) // Checking if parsing was successful and size is valid
{
    Console.WriteLine("Enter the number of columns:");
    line = Console.ReadLine();

    // Parsing the input string to get the number of columns
    success = int.TryParse(line, out size2);

    if (success && size2 > 0) // Checking if parsing was successful and size2 is valid
    {
        string[,] names = new string[size, size2]; // Declaring the 2D array with different dimensions

        Console.WriteLine("Enter the names:");

        // Populating the array with names entered by the user
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size2; j++)
            {
               names[i, j] = Console.ReadLine();
            }
        }

        // Finding the middle person's name
        string middlePersonName = names[size / 2, size2 / 2]; // Adjusted index calculation
        Console.WriteLine($"Middle person's name: {middlePersonName}");
    }
    else
    {
        Console.WriteLine("Invalid number of columns. Please enter a positive integer.");
    }
}
else
{
    Console.WriteLine("Invalid number of rows. Please enter a positive integer.");
} */

//sum up 2 dimension then calculate
{
    Console.WriteLine("Enter the number of rows and columns (separated by space):");
    string[] dimensions = Console.ReadLine().Split(' ');

    int size, size2;

    // Parsing the input string to get the number of rows and columns
    if (dimensions.Length == 2 && int.TryParse(dimensions[0], out size) && int.TryParse(dimensions[1], out size2) && size > 0 && size2 > 0)
    {
        string[,] names = new string[size, size2]; // Declare 2D array with specified dimensions

        Console.WriteLine($"Enter names for {size * size2} persons:");

        // Populate the array with names entered by the user
        for (int i = 0; i < size; i++)
        {
            for (int j = 0; j < size2; j++)
            {
                names[i, j] = Console.ReadLine();
            }
        }

        // Calculate the total number of names
        int totalNames = size * size2;

        // Find the middle person's name
        string middlePersonName = names[totalNames / 2 / size2, totalNames / 2 % size2]; // Calculate middle index based on totalNames
        Console.WriteLine($"Middle person's name: {middlePersonName}");
    }
    else
    {
        Console.WriteLine("Invalid input for dimensions. Please enter two positive integers separated by space.");
    }
}


//short version

{
    Console.WriteLine("Enter the number of rows and columns (separated by space):");
    string[] dimensions = Console.ReadLine().Split(' ');

    int size, size2;

    if (dimensions.Length != 2 || !int.TryParse(dimensions[0], out size) || !int.TryParse(dimensions[1], out size2) || size <= 0 || size2 <= 0)
    {
        Console.WriteLine("Invalid input for dimensions. Please enter two positive integers separated by space.");
        return;
    }

    string[,] names = new string[size, size2];
    int totalNames = size * size2;

    Console.WriteLine($"Enter names for {totalNames} persons:");

    for (int i = 0; i < totalNames; i++)
    {
        names[i / size2, i % size2] = Console.ReadLine();
    }

    string middlePersonName = names[totalNames / 2 / size2, totalNames / 2 % size2];
    Console.WriteLine($"Middle person's name: {middlePersonName}");
}