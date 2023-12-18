namespace TodoOOP
{
    public class Reader
    {
        public List<Todo> ReadTodosFromFile(string pathToFile)
        {
            string? line;
            List<Todo> todosFromFile = new List<Todo>(); // list objektů
            //StreamReader reader = new StreamReader(Path.Combine(pathToFile));
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
        public int ReadTodoIndex()
        {
            int index;
            Console.WriteLine("Write a number of todo, you want to delete: ");
            while (!int.TryParse(Console.ReadLine(), out index))
            {
                Console.WriteLine("Its not a number...");
                Console.WriteLine("Write a todo number again...");
            }
            return index;
        }
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
    