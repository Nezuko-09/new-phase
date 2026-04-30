class ImplementingMethods : IMethodsUsed
{
    string? desktopPath;
    string? mGQSTeachingPath;
    string? workingFilePath;
    protected string? mGQSFolder;
    FileStream fileStream = null!;
    public void Paths()
    {
        string desktopPath = @"C:\Users\Hafsat\Desktop";
        string mGQSTeachingPath = $@"{desktopPath}\MGQSTeaching";
        string workingFilePath = $@"{mGQSTeachingPath}\WorkingWithFiles";
        string mGQSFolder = $@"{desktopPath}\MGQS Folder";
        Directory.CreateDirectory(mGQSFolder);
    }
    public void CreateFile()
    {
        Console.WriteLine("Input the file name... Ensure it has an extension eg: files.txt");
        string input = Console.ReadLine()!;
        while (!Path.HasExtension(input))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!!--File must have an extension. EG:.txt,.doxc");
            Console.ResetColor();
            input = Console.ReadLine()!;
        }
        string fileName = $@"{mGQSFolder}\{input}";
        fileStream = File.Create(fileName);
        Console.WriteLine("file has been successflly created");
        fileStream.Close();
    }
    public void DeleteFile()
    {
        Console.WriteLine("write the name of the file in mgqs folder you want to delete");
        string fileame = $@"{mGQSFolder}\{Console.ReadLine()}";
        if (File.Exists(fileame))
        {
            File.Delete(fileame);
            Console.WriteLine($"file with path {fileame} has been deleted successfully");
        }
        else
        {
            Console.WriteLine("invalid file name. nothing was deleted".ToUpper());
        }
    }
    public void CreateFolder()
    {
        Console.WriteLine("type the name of folder to be created");
        string folderName = $@"{mGQSFolder}\{Console.ReadLine()}";
        Directory.CreateDirectory(folderName);
        Console.WriteLine($"folder with path {folderName} has been created successfully");
    }
    public void DeleteFolder()
    {
        Console.WriteLine("type the name of the folder you want to delete");
        string folderName = $@"{mGQSFolder}\{Console.ReadLine()}";
        if (Directory.Exists(folderName))
        {
            Directory.Delete(folderName);
            Console.WriteLine($"folder with path {folderName} has been deleted successfully");
        }
        else
        {
            Console.WriteLine("Invalid folder name.no deletion happened".ToUpper());
        }
    }
    public void WriteTextIntoFile()
    {
        Console.WriteLine("input the name of the file you want to write a text in");
        string existingFile = Console.ReadLine()!;
        if (!Path.HasExtension(existingFile))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!!--File must have an extension. EG:.txt,.doxc");
            Console.ResetColor();
            existingFile = Console.ReadLine()!;
        }
        while (Path.HasExtension(existingFile) && File.Exists(existingFile))
        {
            Console.WriteLine("input the text to be written in the file");
            File.WriteAllText(existingFile, Console.ReadLine());
            Console.WriteLine("your text has successfully been written in the file".ToUpper() +existingFile);
        }
        Console.WriteLine("File does not exist check well before inputting fileName. THANK YOU!!");
    }
    public void CopyExistingFileIntoAnotherOfSameFolder()
    {
        Console.WriteLine("input the file name to be copied(i.e:THE FILE YOU WANT TO COPY)");
        string fileToCopy = Console.ReadLine()!;
        while (!Path.HasExtension(fileToCopy))
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("Error!!--File must have an extension. EG:.txt,.doxc");
            Console.ResetColor();
        }
        if (!File.Exists(fileToCopy))
        {
            Console.WriteLine("this file does not exist".ToUpper().Trim());
        }
        while (File.Exists(fileToCopy))
        {
            Console.WriteLine("input the name of file that actually exists to be copied into");
            string fileCopiedInto = Console.ReadLine()!;
            while (!Path.HasExtension(fileCopiedInto))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Error!!--File must have an extension. EG:.txt,.doxc");
                Console.ResetColor();
            }
            if (!File.Exists(fileCopiedInto))
            {
                Console.WriteLine("this file does not exist".ToUpper().Trim());
            }
            while (File.Exists(fileCopiedInto))
            {
                File.Copy(fileToCopy, fileCopiedInto);
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine("File has been copied sccessfully");
                Console.ResetColor();
            }
        }
    }
    public void CopyFileOfExistingFolderIntoNewFolder()
    {

    }
    public void EndOperation()
    {
        Console.WriteLine("Operation has ended sccessfully".Trim());
    }
}
