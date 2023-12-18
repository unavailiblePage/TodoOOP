using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    /// <summary>
    /// The Writer class is responsible for writing Todo objects to the console or to a file.
    /// </summary>
    public class Writer
    {
        /// <summary>
        /// Writes the given list of Todo items to the console.
        /// </summary>
        /// <param name="todoToWrite">The list of Todo items to write.</param>
        public void Write(List<Todo> todoToWrite)
        {
            for (int i = 0; i < todoToWrite.Count; i++)
            {
                Console.WriteLine(todoToWrite[i].ToString());
            }
        }

        /// Write a list of Todo objects to a file in CSV format.
        /// </summary>
        /// <param name="todoToWriteToFile">The list of Todo objects to write to the file.</param>
        /// <param name="filePath">The path to the file where the objects will be written.</param>
        /// <exception cref="System.IO.IOException">Thrown when an error occurs while writing to the file.</exception>
        /// <exception cref="System.ArgumentNullException">Thrown when either the todoToWriteToFile list or the filePath parameter is null.</exception>
        /// <seealso cref="Todo"/>
        public void WriteToFile(List<Todo> todoToWriteToFile, string filePath)
        {
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
