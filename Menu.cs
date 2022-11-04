public class Menu
{
    public void RunMenu()
    {
        FileReader fileReader = new FileReader();
        FileCreator fileCreator = new FileCreator();

        Console.Title = "Text Editor";
        Console.Clear();
        Console.WriteLine("==============================================Options==============================================");
        Console.WriteLine("1 - Open File");
        Console.WriteLine("2 - Create File");
        Console.WriteLine("3 - Exit");
        Console.WriteLine("===================================================================================================");

        Console.Write("Choose an option: ");
        int option = Convert.ToInt32(Console.ReadLine());

        switch (option)
        {
            case 1: SetWindow("File Reader"); fileReader.OpenFile(); break;
            case 2: SetWindow("File Creator"); fileCreator.CreateFile();  break;
            default: Environment.Exit(0); break;
        }
    }

    private void SetWindow(string windowTitle)
    {
        Console.Clear();
        Console.Title = windowTitle;
    }
}