using System.Threading.Channels;
using TodoOOP;

Writer writer = new Writer();
Reader reader = new Reader();
Edit edit = new Edit();
Menu menu = new Menu();

//List<Todo> todos = reader.ReadTodos();
menu.ShowMenuSelection();

//todos.ToString();

//writer.Write(todos);
//writer.WriteToFile(todos);