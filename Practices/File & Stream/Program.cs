using System.Text;

//var filename = "demo.txt";

//if (File.Exists(filename)) 
//File.Delete(filename);
//File.WriteAllText(filename,""""
//    Hello From 
//              Vukuchuku
//    """");

//string content = File.ReadAllText(filename);

//Console.WriteLine(content);

//File::


//FileInfo fileInfo = new FileInfo(filename);

//if (fileInfo.Exists )
//    fileInfo.Delete();

//using (FileStream stream = fileInfo.Open(FileMode.OpenOrCreate))
//{

//    string streamContent = "This is a long text";

//    byte[] bytes = Encoding.UTF8.GetBytes(streamContent);

//    stream.Write(bytes, 0, bytes.Length);
//}

//using (FileStream stream = fileInfo.Open(FileMode.Open))
//{
//    byte[] bytes = new byte[1];

//    for (int i = 0; i < fileInfo.Length; i++)
//    {
//        stream.Read(bytes, 0, 1);

//        Console.Write(Encoding.UTF8.GetString(bytes));
//    }
//}


//Diectory::



var folderName = "MyFiles";

if (Directory.Exists(folderName))
    Directory.Delete(folderName, true);
Directory.CreateDirectory(folderName);

Console.WriteLine( Directory.GetCurrentDirectory());

DirectoryInfo directoryInfo = new DirectoryInfo(Directory.GetCurrentDirectory());

string? pathForFiles = directoryInfo?.Parent?.Parent?.Parent?.FullName;

string fullPath = Path.Combine(pathForFiles, folderName);

//if (Directory.Exists(folderName))
//    Directory.Delete(folderName, true);
//Directory.CreateDirectory(folderName);

DirectoryInfo currentDirectory = new DirectoryInfo(Directory.GetCurrentDirectory());

foreach (var file in currentDirectory.GetFiles("*.json"))
{
    Console.WriteLine(file.Name);
}


