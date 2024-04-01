namespace TodoOOP;

public class Editor
{
    public void EditTodo(List<Todo> Todos, Writer ConsoleOutput, Reader ConsoleInput, string fullPath)
    {
        while (true)
        {
            ConsoleOutput.Write(Todos);
            Console.WriteLine();
            int lineToEdit = ConsoleInput.ReadTodoIndex();
            Todo todoToEdit = Todos[lineToEdit - 1];
            todoToEdit.Index = lineToEdit;
            int priority;

            Console.WriteLine();
            Console.WriteLine("For edit title press t");
            Console.WriteLine("For edit description press d");
            Console.WriteLine("For edit priority press p");
            string choice = Console.ReadLine();
            switch (choice)
            {
                case "t":
                    while (true)
                    {
                        Console.WriteLine("Write a TODO title: ");
                        todoToEdit.Title = Console.ReadLine();
                        if (!string.IsNullOrEmpty(todoToEdit.Title))
                        {
                            Console.Clear();
                            todoToEdit.ToCsvString();
                            ConsoleOutput.WriteToFile(Todos, fullPath);

                            Console.Clear();
                            ConsoleOutput.Write(Todos);
                            Console.WriteLine();
                            Console.Write("The todo has been edited. Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Title cannot be empty. Please enter a valid title.");
                    }
                    break;
                case "d":
                    while (true)
                    {
                        Console.WriteLine("Write a TODO description: ");
                        todoToEdit.Description = Console.ReadLine();
                        if (!string.IsNullOrEmpty(todoToEdit.Description))
                        {
                            Console.Clear();
                            todoToEdit.ToCsvString();
                            ConsoleOutput.WriteToFile(Todos, fullPath);

                            Console.Clear();
                            ConsoleOutput.Write(Todos);
                            Console.WriteLine();
                            Console.Write("The todo has been edited. Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Description cannot be empty. Please enter a valid description.");
                    }

                    break;
                case "p":
                    while (true)
                    {
                        Console.WriteLine("Write a TODO priority (1-5): ");
                        if (int.TryParse(Console.ReadLine(), out priority) && priority >= 1 && priority <= 5)
                        {
                            todoToEdit.Priority = priority;
                            Console.Clear();
                            todoToEdit.ToCsvString();
                            ConsoleOutput.WriteToFile(Todos, fullPath);
                            
                            Console.Clear();
                            ConsoleOutput.Write(Todos);
                            Console.WriteLine();
                            Console.Write("The todo has been edited. Press any key to continue...");
                            Console.ReadKey();
                            break;
                        }
                        Console.WriteLine("Invalid priority. Please enter a number between 1 and 5.");
                    }
                    break;
                default:
                        Console.WriteLine("Invalid choice. Press any key to continue...");
                        break;
            }
            Console.WriteLine("Do you want to edit more? Press y/n");
            string answer = Console.ReadLine();
            if (string.Equals(answer, "n", StringComparison.OrdinalIgnoreCase))
            {
                break;
            }
        }
    }
}

