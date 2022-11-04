public class FileReader
{
    public void OpenFile()
    {
        Open();
        var menu = new Menu();
        menu.RunMenu();
    }

    private void Open()
    {    
        string text = "";

        Console.Clear();
        Console.Write("Enter the file path: ");
        var path = Console.ReadLine();
        
        using(var file = new StreamReader(path))
        {
            text = file.ReadToEnd();
        }
        
        Console.WriteLine(text);
        Console.WriteLine("\nPress any key to go back to menu...");
        Console.ReadLine();
    }
}