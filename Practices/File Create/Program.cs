
//using System.Text;

//string folderPath = @"H:\DevSCS\jamil-csharp-b16\Practices\File Create\bin\Debug\net8.0";

//string folderName = "New Folder";
//string folderName2 = "New Folder2";


//string fileName = "example.txt";

//   string newFolderPath = Path.Combine(folderPath, folderName);
//string newFolderPath2 = Path.Combine(folderPath, folderName2);



//if (!Directory.Exists(newFolderPath))
//    Directory.CreateDirectory(newFolderPath);


//string filePath = Path.Combine(newFolderPath, fileName);

//if (File.Exists(filePath))
//{
//    File.Delete(filePath);
//}
//        File.Create(filePath).Close(); 


//if (!Directory.Exists(newFolderPath2))
//    Directory.CreateDirectory(newFolderPath2);
//string newFilePath = Path.Combine(newFolderPath2, fileName);
//File.Delete(newFilePath);
//if (File.Exists(filePath))
//    File.Move(filePath, newFilePath);
//    File.Copy(newFilePath, filePath);

//string[] filesInFolder = Directory.GetFiles(newFolderPath);
//string[] filesInFolder2 = Directory.GetFiles(newFolderPath2);
//foreach (string file in filesInFolder)
//{
//    Console.WriteLine(file);
//}
//foreach (string file in filesInFolder2)
//{
//    Console.WriteLine(file);
//}

using System.Text;

string folderPath = @"H:\DevSCS\jamil-csharp-b16\Practices\File Create\bin\Debug\net8.0";
string folderName = "New Folder";
string folderName2 = "New Folder2";
string fileName = "example.txt";

string newFolderPath = Path.Combine(folderPath, folderName);
string newFolderPath2 = Path.Combine(folderPath, folderName2);

DirectoryInfo directoryInfo1 = new DirectoryInfo(newFolderPath);
DirectoryInfo directoryInfo2 = new DirectoryInfo(newFolderPath2);

if (!directoryInfo1.Exists)
    directoryInfo1.Create();

if (!directoryInfo2.Exists)
    directoryInfo2.Create();

string filePath = Path.Combine(newFolderPath, fileName);
string newFilePath = Path.Combine(newFolderPath2, fileName);

FileInfo fileInfo = new FileInfo(filePath);
FileInfo newFileInfo = new FileInfo(newFilePath);

if (fileInfo.Exists)
    fileInfo.Delete();

// Creating and writing to the file in folder 1
using (FileStream fs1 = fileInfo.Create())
{
    byte[] contentBytes = Encoding.UTF8.GetBytes("Pass Kormu");
    fs1.Write(contentBytes, 0, contentBytes.Length);
}

// Creating and writing to the file in folder 2
using (FileStream fs2 = newFileInfo.Create())
{
    byte[] contentBytes = Encoding.UTF8.GetBytes("Fail Kormu");
    fs2.Write(contentBytes, 0, contentBytes.Length);
}

Console.WriteLine("Files created and written successfully.");

// Listing files in both folders
FileInfo[] filesInFolder = directoryInfo1.GetFiles();
FileInfo[] filesInFolder2 = directoryInfo2.GetFiles();

Console.WriteLine("Files in folder 1:");
foreach (FileInfo file in filesInFolder)
{
    Console.WriteLine(file.FullName);
}

Console.WriteLine("\nFiles in folder 2:");
foreach (FileInfo file in filesInFolder2)
{
    Console.WriteLine(file.FullName);
}

using (FileStream fs1 = fileInfo.Open(FileMode.Open))
{
    byte[] bytes = new byte[1];

    for (int i = 0; i < fileInfo.Length; i++)
    {
        fs1.Read(bytes, 0, 1);
        Console.Write(Encoding.UTF8.GetString(bytes));
    }
}

using (FileStream fs2= newFileInfo.Open(FileMode.Open))
{
    byte[] bytes = new byte[1];

    for (int i = 0; i < newFileInfo.Length; i++)
    {
        fs2.Read(bytes, 0, 1);
        Console.Write(Encoding.UTF8.GetString(bytes));
    }
}