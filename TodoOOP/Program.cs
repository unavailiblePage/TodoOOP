using System.Threading.Channels;
using TodoOOP;

Writer writer = new Writer();
Reader reader = new Reader();

List<Todo> todos = reader.ReadTodos();

todos.ToString();

writer.Write(todos);
writer.WriteToFile(todos);