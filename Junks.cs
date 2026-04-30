// See https://aka.ms/new-console-template for more information
/*Console.WriteLine("Hello, World!");
var desktopPath = @"C:\Users\Hafasat\Desktop";
var filePath = $"{desktopPath}\\MGQSFile.txt";
var docxPath = $"{desktopPath}\\MGQSFile.docx";
var folderPath = $"{desktopPath}\\MGQSFolder";
var copiedFolder = $"{folderPath}\\MGQSFile.txt";
Directory.CreateDirectory(folderPath);
string fullName = "Dere Hafsat Omowunmi";
//File.WriteAllLines(filePath,Enumerable.Repeat(fullName,10));
for (int i = 0 ; i < 10 ; i ++)
{
    File.AppendAllText(filePath,fullName + Environment.NewLine);
}
File.Copy(filePath,copiedFolder,true);
string content = File.ReadAllText(filePath);
File.WriteAllText(docxPath,content);
Directory.Delete(folderPath);

//VERBATIM
//raw string literals --- """
//   mmomommkm kl mmmomom mommo"""

string car = "Mercedes";
string Max()
{
    int max = 0;
    char maxChar = ' ';
    for (int i = 0; i < car.Length; i++)
    {
        if (car[i] > max)
        {

            max = car[i];
            maxChar = car[i];
        }
    }
    return $"{maxChar} : {max}";
}
Max();
*/