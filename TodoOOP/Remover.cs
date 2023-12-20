namespace TodoOOP;

public class Remover
{
    public void Remove(List<Todo> Todos, Writer ConsoleOutput, Reader ConsoleInput, string fullPath)
    {
        ConsoleOutput.Write(Todos);
        Console.WriteLine();

        int lineToRemove = ConsoleInput.ReadTodoIndex();
        
        Todos.RemoveAt(lineToRemove - 1);
        Console.Clear();
        Console.WriteLine("Yours TODOs: ");
        ConsoleOutput.Write(Todos);
        Console.WriteLine();
        
        Console.WriteLine("The todo has been removed. Press any key to continue...");
        Console.ReadKey();

        ConsoleOutput.WriteToFile(Todos, fullPath);

        

    }
}