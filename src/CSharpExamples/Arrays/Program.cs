// See https://aka.ms/new-console-template for more information
/*
string line = Console.ReadLine();
int size = 0;

bool success = false;

success = int.TryParse(line, out size);

if (success)
{
    string[] names = new string[size];

    for (int i = 0; i < size; i++)
    {
        names[i] = Console.ReadLine();
    }

    string middlePersonName = names[names.Length / 2];
    Console.WriteLine(middlePersonName);
}
else
{
    Console.WriteLine("Size is not in correct format");
}


int[,] grid = new int[3, 3];
grid[0, 0] = 2;
grid[0, 1] = 4;
grid[1, 1] = 5;

Console.WriteLine(grid[1, 1]);
*/


int[][] jaggedArray = new int[3][];

jaggedArray[0] = new int[2];
jaggedArray[1] = new int[3];
jaggedArray[2] = new int[4];

jaggedArray[0][0] = 79;
jaggedArray[0][1] = 49;
jaggedArray[1][0] = 80;
jaggedArray[1][1] = 68;
jaggedArray[1][2] = 56;
jaggedArray[2][0] = 57;
jaggedArray[2][1] = 34;
jaggedArray[2][2] = 88;
jaggedArray[2][3] = 92;

for(int i = 0; i < jaggedArray.GetLength(0); i++)
{
    double avg = 0;
    for(int j = 0; j < jaggedArray[i].Length; j++)
    {
        avg = avg + jaggedArray[i][j];
    }
    Console.WriteLine(avg / jaggedArray[i].Length);
}


int[] ages = [ 34, 66, 78 ];
int[,] coords = new int[,]
{
    { 2, 3, 6 },
    { 4, 5, 7 }
};

jaggedArray = new int[][]
{
    new int[]{ 79, 49 },
    new int[]{ 80, 68, 56 },
    new int[]{ 57, 34, 88, 92 }
};


int count = int.Parse(Console.ReadLine());

int[][] dynamicJaggedArray = new int[count][];

for(int i = 0; i <= count; i++)
{
    int items = int.Parse(Console.ReadLine());
    dynamicJaggedArray[i] = new int[items];

    for(int j = 0; j < items; j++)
    {
        int item = int.Parse(Console.ReadLine());
        dynamicJaggedArray[i][j] = item;
    }
}