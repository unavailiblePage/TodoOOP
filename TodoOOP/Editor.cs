namespace TodoOOP;

public class Editor
{
    public void EditTodo(List<Todo> Todos, Writer ConsoleOutput, Reader ConsoleInput, string fullPath)
    {
        ConsoleOutput.Write(Todos);
        Console.WriteLine();

        int lineToEdit = ConsoleInput.ReadTodoIndex();
        Todo todoToEdit = Todos[lineToEdit - 1];
        int priority=0;

        Console.Clear();
        ConsoleOutput.Write(Todos);
        Console.WriteLine();

        Console.Write("Write a new title: ");
        todoToEdit.Index = lineToEdit;
        todoToEdit.Title = Console.ReadLine();

        Console.Write("Write a new description: ");
        todoToEdit.Description = Console.ReadLine();
        
        Console.Write("Write a new priority (1-5: when 1 is the most important and 5 is the least important): ");
        while (!int.TryParse(Console.ReadLine(), out priority) || priority < 1 || priority > 5)
        {
            Console.WriteLine("Its not a number or not in range 1-5...");
            Console.WriteLine("Write a priority again...");
        }
        todoToEdit.Priority = priority;
        
        Console.Clear();
        todoToEdit.ToCsvString();
        ConsoleOutput.WriteToFile(Todos, fullPath);

        Console.Clear();
        ConsoleOutput.Write(Todos);
        Console.WriteLine();
        Console.Write("The todo has been edited. Press any key to continue...");
        Console.ReadKey();

    }
}

