
class Run : ImplementingMethods
{
    public void Running()
    {
        Console.WriteLine("===WELCOME TO OUR WORKING WITH FILES APP BY OUR OUSTANDING COHORT 4===");
        Console.WriteLine("Feel free to explore and share observations".ToUpper());
        Console.WriteLine("Press any key to coninue");
        Console.ReadLine();
        Console.WriteLine($"{mGQSFolder} has successfully been created. Hurray!!!".ToUpper());
        bool closeOperation = true;
        while (closeOperation)
        {
            Console.WriteLine("choose an option below that tallies with what you are to do");
            Console.WriteLine("1.create a file /n2.delete a folder/n3.create a folder /n4.delete a folder /n0.end operation".ToUpper());
            var optionParse = int.TryParse(Console.ReadLine(), out int option);
            bool validate = true;
            while (validate)
            {
                if (!optionParse)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("input a valid number nothing else silly");
                    Console.ResetColor();
                    option = int.Parse(Console.ReadLine()!);
                }
                else if (optionParse)
                {
                    validate = false;
                }
            }
            try
            {
                switch (option)
                {
                    case 1:
                        CreateFile();
                        break;
                    case 2:
                        DeleteFile();
                        break;
                    case 3:
                        CreateFolder();
                        break;
                    case 4:
                        DeleteFolder();
                        break;
                    case 5:
                        WriteTextIntoFile();
                        break;
                    case 6:
                        CopyExistingFileIntoAnotherOfSameFolder();

                        break;
                    case 0:
                        closeOperation = false;
                       
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.DarkMagenta;
                        Console.WriteLine($"invalid option please choose an appropriate number");
                        Console.ForegroundColor = ConsoleColor.Green;
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"an exception was detected  {ex} ");
            }
            Console.WriteLine("click any button to continue");
            Console.ReadLine();
            Console.Clear();
        }

        Console.WriteLine("End of app! make sure to come back for more experiences");
    }
}