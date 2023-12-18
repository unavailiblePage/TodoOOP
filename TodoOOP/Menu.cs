namespace TodoOOP;

public class Menu
{
    public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
    public string fileName = "Todos.txt";
    public string fullPath;

    public List<Todo> Todos;

    public Writer ConsoleOutput;
    public Reader ConsoleInput;
    
    public Menu()
    {
        fullPath = Path.Combine(projectDirectory, fileName);
        ConsoleInput = new Reader();
        ConsoleOutput = new Writer();
        Todos = ConsoleInput.ReadTodosFromFile(this.fullPath);
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
                    ConsoleOutput.WriteToFile(Todos, fullPath); 
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
