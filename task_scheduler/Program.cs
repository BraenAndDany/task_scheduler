using System.IO;


string dir = "C:\\Users\\User\\Desktop\\task scheduler";
int i = 0;
DirectoryInfo files = new DirectoryInfo(dir);
FileInfo[] fls;
fls = files.GetFiles();
foreach (FileInfo file in fls)
{
    i++;
}
if (!Directory.Exists(dir)) 
    Directory.CreateDirectory(dir);
File.WriteAllText(Path.Combine(dir, i+".txt"), Convert.ToString(DateTime.Now));