namespace TodoOOP;

public class Editor
{
    public void EditTodo(List<Todo> Todos, Writer ConsoleOutput, Reader ConsoleInput, string fullPath)
    {
        ConsoleOutput.Write(Todos);
        Console.WriteLine();

        int lineToEdit = ConsoleInput.ReadTodoIndex();
        Todo todoToEdit = Todos[lineToEdit - 1];

        Console.Clear();
        ConsoleOutput.Write(Todos);
        Console.WriteLine();

        Console.Write("Write a new title: ");
        todoToEdit.Index = lineToEdit;
        todoToEdit.Title = Console.ReadLine();

        Console.Write("Write a new description: ");
        todoToEdit.Description = Console.ReadLine();

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

