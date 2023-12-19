namespace TodoOOP;

public class Menu
{
    /// <summary>
    /// Represents the project directory path.
    /// </summary>
    /// <remarks>
    /// The project directory is determined by getting the parent directory of the parent directory of the current directory.
    /// </remarks>
    public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;

    /// <summary>
    /// The file name for the Todos file.
    /// </summary>
    /// <remarks>
    /// This variable contains the name of the file where the Todos are stored.
    /// </remarks>
    public string fileName = "Todos.txt";

    /// 
    public string fullPath;

    /// <summary>
    /// The Todos variable is a List of Todo objects. It stores a collection of Todo items.
    /// </summary>
    public List<Todo> Todos;

    /// <summary>
    /// Represents a writer used to output data to the console.
    /// </summary>
    public Writer ConsoleOutput;

    /// <summary>
    /// Represents a reader object for reading input from the console.
    /// </summary>
    public Reader ConsoleInput;
    
    Editor editor = new Editor();

    public Todo TodoOutPut;

    /// <summary>
    /// The Menu class represents the main menu of the program.
    /// </summary>
    public Menu()
    {
        fullPath = Path.Combine(projectDirectory, fileName);
        ConsoleInput = new Reader();
        ConsoleOutput = new Writer();
        Todos = ConsoleInput.ReadTodosFromFile(fullPath);
    }

    /// Shows a menu to the user and allows them to select various actions.
    /// This method does not return any value.
    /// /
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

            Console.WriteLine("Select an option: ");
            while (!int.TryParse(Console.ReadLine(), out choice))
            {
                Console.WriteLine("Please enter a valid choice!");
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
                    Console.WriteLine("Press any key to continue...");
                    Console.ReadKey();
                    break;
                case 3:
                    Console.Clear();
                    Console.WriteLine("Yours TODOs: ");
                    ConsoleOutput.Write(Todos);
                    Console.WriteLine();
                    Console.WriteLine("Do you want to edit your todos? Y/N");
                    string choiceIfEdit = Console.ReadLine();
                    Console.Clear();
                    switch (choiceIfEdit)
                    {
                        case "y":
                            editor.EditTodo(Todos, ConsoleOutput, ConsoleInput, fullPath);
                            break;
                        case "n":
                            break;
                    }
                    break;
                case 4:
                    break;
            }
            Console.Clear();
        } while (choice != 5);
}
}
