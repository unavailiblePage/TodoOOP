namespace TodoOOP;

/// <summary>
/// Represents an editor that allows editing todos.
/// </summary>
public class Editor
{
    /// <summary>
    /// Edits a specific todo item in the list of todos
    /// </summary>
    /// <param name="Todos">The list of todos</param>
    /// <param name="ConsoleOutput">The writer object used for console output</param>
    /// <param name="ConsoleInput">The reader object used for console input</param>
    /// <param name="fullPath">The full path of the file to write the updated todos to</param>
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
        Console.WriteLine("The todo has been edited. Press any key to continue...");
        Console.ReadKey();
    }
}

