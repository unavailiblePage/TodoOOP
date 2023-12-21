namespace TodoOOP;

public class Remover
{
    public void RemoveTodo(List<Todo> Todos, Writer ConsoleOutput, Reader ConsoleInput, string fullPath)
    {
        ConsoleOutput.Write(Todos);
        Console.WriteLine();

        int lineToRemove = ConsoleInput.ReadTodoIndex();
        
        Todos.RemoveAt(lineToRemove - 1);
        Console.Clear();
        ConsoleOutput.WriteToFile(Todos, fullPath);
        Console.WriteLine("Yours TODOs: ");
        ConsoleOutput.Write(Todos);
        Console.WriteLine();
        
        Console.Write("The todo has been removed. Press any key to continue...");
        Console.ReadKey();
        
    }
}