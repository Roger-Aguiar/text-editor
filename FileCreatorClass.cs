public class FileCreator
{
    public string? Text { get; set; }
    Menu menu = new Menu();

    public void CreateFile()
    {        
        Console.WriteLine("Enter your text and press ESC to save the file.\n");

        do
        {
            Text += Console.ReadLine();
            Text += Environment.NewLine;//It allows the user types multiple lines.
        } while (Console.ReadKey().Key != ConsoleKey.Escape);
        //ConsoleKey.Escape = "ESC" key
        Save();
        menu.RunMenu();
    }
    
    private void Save()
    {    
        Console.Clear();

        Console.Write("Enter the path that you want to save this file: ");
        var path = Console.ReadLine();

        using(var file = new StreamWriter(path))
        {
            file.Write(Text);
        }

        Console.WriteLine($"The file {path} was saved successfully!");
        Console.WriteLine("Press any key to go back to menu...");
        Console.ReadLine();
    }
}