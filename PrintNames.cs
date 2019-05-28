using System;
using System.IO;
using System.Collections.Generic;

namespace name_sorter
{

    /// <summary>
    /// Class performs printing functions for sorter, outputting SortedNames 
    /// to console and writing its contents to a text file.
    /// </summary>
    public class PrintNames
    {
        /// <summary>
        /// Holds list of sortedNames
        /// </summary>
        public List<string> sortedNames = new List<string>();

        /// <summary>
        /// Constructor for PrintArray class
        /// </summary>
        public PrintNames()
        {
        }

        /// <summary>
        /// Main method for PrintArray. Writes sortedNames to text and
        /// console output
        /// </summary>
        public void printSortedArray()
        {
            //Writes all lines from SortedNames to text file
            File.WriteAllLines(AppDomain.CurrentDomain.BaseDirectory + @"sorted-names-list.txt", sortedNames);

            //Outputs list SortedNames to console
            foreach (string s in sortedNames)
                Console.WriteLine(s);
        }

        /// <summary>
        /// Setter for sortedNames variable
        /// </summary>
        /// <param name="sorted"></param>
        public void setSortedNames(List<String> sorted)
        {
            sortedNames = sorted;
        }
    }
}