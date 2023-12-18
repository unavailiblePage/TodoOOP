using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoOOP
{
    /// <summary>
    /// Represents a todo item.
    /// </summary>
    public class Todo
    {
        /// <summary>
        /// Gets or sets the index property.
        /// </summary>
        /// <value>
        /// The index value.
        /// </value>
        public int Index { get; set; }

        /// <summary>
        /// Gets or sets the title of the object.
        /// </summary>
        /// <value>
        /// A <see cref="System.String"/> representing the title of the object.
        /// </value>
        public string Title { get; set; }

        /// <summary>
        /// Gets or sets the description of the property.
        /// </summary>
        /// <value>
        /// A string representing the description of the property.
        /// </value>
        public string Description { get; set; }

        //konstruktor, jmenuje se stejně jako třída
        /// <summary>
        /// Represents a todo item.
        /// </summary>
        public Todo(int index, string title, string description)
        {
            Index = index;
            Title = title;
            Description = description;
        }

        /// <summary>
        /// Represents a todo item.
        /// </summary>
        public Todo()
        {
            Index = 0;
            Title = string.Empty;
            Description = string.Empty;
        }

        /// <summary>
        /// Parses a string and populates the properties Index, Title, and Description with the values obtained from the split string.
        /// </summary>
        /// <param name="readedString">The string to be parsed.</param>
        public void FromString(string readedString)
        { 
            string[] splitedString = readedString.Split(";");
            Index = Int32.Parse(splitedString[0]);
            Title = splitedString[1];
            Description = splitedString[2];
        }

        /// <summary>
        /// Converts the object properties to a CSV formatted string.
        /// </summary>
        /// <returns>A string representing the object properties in a CSV format.</returns>
        public string ToCsvString()
        {
            //1;neco;neco
            return Index + ";"+ Title + ";" + Description;
        }

        /// <summary>
        /// Returns a string representation of the object.
        /// </summary>
        /// <returns>A string that represents the current object.</returns>
        public string ToString()
        {
           return Index + ": Title: " + Title + " Description: " + Description;
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