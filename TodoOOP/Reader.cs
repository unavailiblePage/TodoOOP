namespace TodoOOP
{
    public class Reader
    {
        public void CheckSourceFile(string directory)
        {
            string fullPath = Path.Combine(directory);
            if (!File.Exists(fullPath))
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("TODO list file does not exist. Creating new file...");
                Console.WriteLine();
                Console.ReadKey();
                Console.Clear();
                File.Create(directory).Close();
            }
        }
        public List<Todo> ReadTodosFromFile(string pathToFile)
        {
            string? line;
            List<Todo> todosFromFile = new List<Todo>(); // list of objects
            using StreamReader reader = new StreamReader(Path.Combine(pathToFile));
            Todo todo; // defining space for a new object
            line = reader.ReadLine();
            while (line != null)
            {
                todo = new Todo(); //creating new object todo
                todo.FromString(line);
                todosFromFile.Add(todo); //object is added into list of objects
                line = reader.ReadLine();
            }
            return todosFromFile;
        }
        public int ReadTodoIndex()
        {
            int index;
            Console.Write("Write a number of todo, you want to choose: ");
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Its not a number...");
                Console.Write("Write a number of todo, you want to choose: ");
            }
            return index;
        }
        public List<Todo> GetTodos(List<Todo> existingTodos)
        {
            while (true)
            {
                string title = string.Empty;
                while (true)
                {
                    Console.WriteLine("Write a TODO title: ");
                    title = Console.ReadLine();
                    if (!string.IsNullOrEmpty(title))
                    {
                        break;
                    }
                    Console.WriteLine("Title cannot be empty. Please enter a valid title.");
                }

                string description = string.Empty;
                while (true)
                {
                    Console.WriteLine("Write a TODO description: ");
                    description = Console.ReadLine();
                    if (!string.IsNullOrEmpty(description))
                    {
                        break;
                    }
                    Console.WriteLine("Description cannot be empty. Please enter a valid description.");
                }

                int priority = 0;
                while (true)
                {
                    Console.WriteLine("Write a TODO priority (1-5): ");
                    if (int.TryParse(Console.ReadLine(), out priority) && priority >= 1 && priority <= 5)
                    {
                        break;
                    }
                    Console.WriteLine("Invalid priority. Please enter a number between 1 and 5.");
                }

                existingTodos.Add(new Todo(GetUniqueIndex(existingTodos), priority, title, description));

                Console.WriteLine("Want to add another TODO? Y/N ");
                string answer = Console.ReadLine();
                if (string.Equals(answer, "n", StringComparison.OrdinalIgnoreCase))
                {
                    break;
                }
            }
            return existingTodos.OrderBy(todoItem => todoItem.Index).ToList();
        }

        private int GetUniqueIndex(List<Todo> existingTodos)
        {
            for (int index = 1; ; index++)
            {
                if (!existingTodos.Exists(todoItem => todoItem.Index == index))
                {
                    return index;
                } 
            }
        }
    }
}
    