namespace TodoOOP;

public class Menu
{
    public string filePath_OSx = "/Users/mib/RiderProjects/TodoOOP/TodoOOP";
    public string filePath_Win = "C:\\Users\\kolovratnik\\Desktop\\programs\\programovani\\TodoOOP\\TodoOOP";
    public string filePath_Lin = "/home/mib/RiderProjects/TodoOOP/TodoOOP/";
    public List<Todo> Todos;

    public Writer ConsoleOutput;
    public Reader ConsoleInput;
    
    public Menu()
    {
        ConsoleInput = new Reader();
        ConsoleOutput = new Writer();
        Todos = ConsoleInput.ReadTodosFromFile(filePath_Lin);
    }

public void ShowMenuSelection()
{
    int choice;
        do
        {
            Console.WriteLine("__MENU__");
            Console.WriteLine("1) ADD TODO");
            Console.WriteLine("2) SHOW TODOS");
            Console.WriteLine("3) EDIT TODO");
            Console.WriteLine("4) DELETE TODO");
            Console.WriteLine("5) SAVE & EXIT");

            Console.WriteLine("Choose what you want to do: ");
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Add valid choice!");
            }
            switch (choice)
            {
                case 1:
                    Console.Clear();
                    Todos = ConsoleInput.GetTodos(Todos);
                    ConsoleOutput.WriteToFile(Todos, filePath_Lin); 
                    break;
                case 2:
                    Console.Clear();
                    Console.WriteLine("Yours TODOs: ");
                    ConsoleOutput.Write(Todos);
                    Console.WriteLine("Press key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    break;
                case 4:
                    break;
            }
            Console.Clear();
        } while (choice != 5);
    }
}
