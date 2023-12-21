namespace TodoOOP;

public class Menu
{
    public string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
    public string fileName = "Todos.txt";
    public string fullPath;
    public List<Todo> Todos;
    public Writer ConsoleOutput;
    public Reader ConsoleInput;
    public Editor Edit;
    public Remover Remove;
    public Menu()
    {
        fullPath = Path.Combine(projectDirectory, fileName);
        ConsoleInput = new Reader();
        ConsoleOutput = new Writer();
        Edit = new Editor();
        Remove = new Remover();
        ConsoleInput.checkSourceFile(fullPath);
        Todos = ConsoleInput.ReadTodosFromFile(fullPath);
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

            Console.Write("Select an option: ");
            while (!int.TryParse(Console.ReadLine(), out choice) || choice > 5)
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
                    Console.WriteLine();
                    Console.Write("Press any key to continue...");
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
                        case "y" or "Y" or "yes" or "Yes" or "YES":
                            Edit.EditTodo(Todos, ConsoleOutput, ConsoleInput, fullPath);
                            break;
                        case "n" or "N" or "no" or "No" or "NO":
                            break;
                    }
                    break;
                case 4:
                    Console.Clear();
                    Console.WriteLine("Yours TODOs: ");
                    Remove.RemoveTodo(Todos, ConsoleOutput, ConsoleInput, fullPath);
                    break;
            }
            Console.Clear();
        } while (choice != 5);
    }
}
