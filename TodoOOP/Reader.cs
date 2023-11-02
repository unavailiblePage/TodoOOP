using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    internal class Reader
    {
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
        public List<Todo> ReadTodos() //Todo je datovy typ adresy
        {
            List<Todo> todos = new List<Todo>();
            string title;
            string description;
            int index = 0;
            //Todo prepareTodo = new Todo(); //objekt na ktery se pak odkazuji (adresa v paměti)

            while (true)
            {
                Console.WriteLine("Write a TODO title: ");
                title = Console.ReadLine();
                Console.WriteLine("Write a TODO description: ");
                description = Console.ReadLine();
                index++;
                todos.Add(new Todo(index, title, description));
                Console.WriteLine("Want you add another TODO? Y x N ");
                string answer = Console.ReadLine();
                if (answer == "N")
                {
                    break;
                }
            }
            return todos;
        }
    }
}