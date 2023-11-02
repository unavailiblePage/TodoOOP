using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    internal class Todo
    {
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
        public int Index { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }

        //konstruktor, jmenuje se stejně jako třída
        public Todo(int index, string title, string description)
        {
            Index = index;
            Title = title;
            Description = description;
        }
        public string ToString()
        {
           return Index + ": Title: " + Title + "\n"+ "     Description: " + Description;
        }
    }
}