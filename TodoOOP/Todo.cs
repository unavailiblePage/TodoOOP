using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    public class Todo
    {
        public int Index { get; set; }
        public int Priority { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //konstruktor, jmenuje se stejně jako třída
        public Todo(int index, int priority, string title, string description)
        {
            Index = index;
            Priority = priority;
            Title = title;
            Description = description;
        }
        public Todo()
        {
            Index = 0;
            Priority = 0;
            Title = string.Empty;
            Description = string.Empty;
        }
        public void FromString(string readedString)
        { 
            string[] splitedString = readedString.Split(";");
            Index = Int32.Parse(splitedString[0]);
            Priority = Int32.Parse(splitedString[1]);
            Title = splitedString[2];
            Description = splitedString[3];
        }
        public string ToCsvString()
        {
            //1;neco;neco
            return Index + ";"+ Priority + ";" + Title + ";" + Description;
        }
        public string ToString()
        {
           return Index + ": Title: " + Title + " Description: " + Description + " Priority: " + Priority;
        }
        public string ToStringByPriority()
        {
            return "\n"+ "priority: " + Priority + "\n" + " title: " + Title + "\n" + " description: " + Description;
        }
        
        /*private int _numberAtribut;
        public int NumberAtribut
        {
            get
            {
                return _numberAtribut;
            }
            set
            {
                _numberAtribut = value;
            }
        }
        */
    }
}