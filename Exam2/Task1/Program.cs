using System;
using System.IO;
{ 
    Random random = new Random(DateTime.Now.Millisecond);


    long fileSizeGB = 5;
    long fileSizeBytes = fileSizeGB * 1024*1024*1024;

    string folderPath = @"H:\DevSCS\jamil-csharp-b16\Exam2\";
    Directory.CreateDirectory(folderPath);

    string filePath = Path.Combine(folderPath, "randomfile.txt");

    using (FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write))
    {


        for (int i = 0; i < fileSizeBytes; i++)
        {
            char randomChar = GetRandomChar(random);
            byte[] charBytes = BitConverter.GetBytes(randomChar);
            fs.Write(charBytes, 0, charBytes.Length);
        }
    }
    Console.WriteLine("File Created:"+ filePath);

}
    static char GetRandomChar(Random random)
    {
        return (char)random.Next('A', 'Z' +1);
    }


