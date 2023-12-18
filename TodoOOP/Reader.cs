namespace TodoOOP
{
    /// The Reader class provides functionality for reading and manipulating Todo data.
    /// /
    public class Reader
    {
        /// <summary>
        /// Reads todo items from a file and returns them as a list.
        /// </summary>
        /// <param name="pathToFile">The path to the file that contains the todo items.</param>
        /// <returns>A list of Todo objects read from the file.</returns>
        public List<Todo> ReadTodosFromFile(string pathToFile)
        {
            string? line;
            List<Todo> todosFromFile = new List<Todo>(); // list objektů
            using StreamReader reader = new StreamReader(Path.Combine(pathToFile));
            Todo todo; // definice prostoru pro nový objekt
            line = reader.ReadLine();
            while (line != null)
            {
                todo = new Todo(); //vytvoření nového objektu todo
                todo.FromString(line);
                todosFromFile.Add(todo); //objekt dávám do listu objektů
                line = reader.ReadLine();
            }
            return todosFromFile;
        }

        /// <summary>
        /// Reads the index of the todo item that the user wants to choose.
        /// </summary>
        /// <returns>The index of the todo item.</returns>
        public int ReadTodoIndex()
        {
            int index;
            Console.WriteLine("Write a number of todo, you want to choose: ");
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Its not a number...");
                Console.WriteLine("Write a todo number again...");
            }
            return index;
        }

        /// <summary>
        /// Adds new TODO items to an existing list of TODOs.
        /// </summary>
        /// <param name="existingTodos">The list of existing Todo objects.</param>
        /// <returns>The updated list of Todo objects with the newly added items.</returns>
        public List<Todo> GetTodos(List<Todo> existingTodos) //Todo je datovy typ adresy
        {
            string title;
            string description;
            
            while (true)
            {
                Console.WriteLine("Write a TODO title: ");
                title = Console.ReadLine();
                Console.WriteLine("Write a TODO description: ");
                description = Console.ReadLine();
                
                existingTodos.Add(new Todo(GetUniqueIndex(existingTodos), title, description));
                Console.WriteLine("Want you add another TODO? Y x N ");
                string answer = Console.ReadLine().ToLower();
                if (answer == "n")
                {
                    break;
                }
            }
            existingTodos = existingTodos.OrderBy(todoItem => todoItem.Index).ToList();
            return existingTodos;
        }

        /// <summary>
        /// Returns a unique index for a new Todo item based on existing Todo items. </summary> <param name="existingTodos">The list of existing Todo items.</param> <returns>A unique index for a new Todo item.</returns>
        /// /
        public int GetUniqueIndex(List<Todo> existingTodos)
        {
            int index = 0;
            while (true)
            {
                index++;
                if (!existingTodos.Exists(todoItem => todoItem.Index == index))
                {
                    break;
                }
            }
            return index;
            /*int index = 0;

            bool flag = false;
            while (true)
            {
                index++;
                for (int i = 0; i < existingTodos.Count; i++)
                {
                    if (existingTodos[i].Index == index)
                    {
                        flag = true;
                        break;
                    }
                }
                if (!flag)
                {
                    break;
                }
                else
                {
                    flag = false;
                }
            }
            return index; */
        }
    }
}
    