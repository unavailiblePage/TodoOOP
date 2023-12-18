using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    public class Writer
    {
        public void Write(List<Todo> todoToWrite)
        {
            for (int i = 0; i < todoToWrite.Count; i++)
            {
                Console.WriteLine(todoToWrite[i].ToString());
            }
        }
        public void WriteToFile(List<Todo> todoToWriteToFile, string filePath)
        {
            //StreamWriter outputFile = new StreamWriter(Path.Combine(filePath));
            using (StreamWriter outputFile = new StreamWriter(filePath))
            {
                foreach (Todo line in todoToWriteToFile)
                {
                    outputFile.WriteLine(line.ToCsvString());
                }
                outputFile.Close();
            }
        }
    }
}
