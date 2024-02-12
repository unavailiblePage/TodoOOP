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
        public void SortedWrite(List<Todo> todoToWrite)
        {
            todoToWrite = todoToWrite.OrderBy(todoItem => todoItem.Priority).ToList();
            for (int i = 0; i < todoToWrite.Count; i++)
            {
                Console.WriteLine(todoToWrite[i].ToStringByPriority());
            }
        }
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
