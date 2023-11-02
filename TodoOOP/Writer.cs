using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    internal class Writer
    {
        public string filePath_OSx = "/Users/mib/RiderProjects/TodoOOP/TodoOOP";
        public string filePath_Win = "C:\\Users\\kolovratnik\\Desktop\\programs\\programovani\\TodoOOP\\TodoOOP";

        public void Write(List<Todo> todoToWrite)
        {
            for (int i = 0; i < todoToWrite.Count; i++)
            {
                Console.WriteLine(todoToWrite[i].ToString());
            }
        }
        public void WriteToFile(List<Todo> todoToWriteToFile)
        {
            StreamWriter outputFile = new StreamWriter(Path.Combine(filePath_Win, "Todos.txt"));
            {
                foreach (Todo line in todoToWriteToFile)
                {
                    outputFile.WriteLine(line.ToString());
                }
                outputFile.Close();
            }
        }
    }
}
