
string OrgFilePath = "randomfile.txt";
string NewFolder = "Folder";
Directory.CreateDirectory(NewFolder);

byte[] originalFileBytes = File.ReadAllBytes(OrgFilePath);

long chunkSizeBytes = 100 * 1024;
int numChunks = (int)Math.Ceiling((int)Math.Ceiling((double)originalFileBytes.Length / chunkSizeBytes);
