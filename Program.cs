using System.IO;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    /// <summary>
    /// Program to take an unsorted list of names and return
    /// a sorted list from surname to given names and output
    /// the result to console and a .txt file in the working
    /// directory.
    /// </summary>
    public class Program
    {
        /// <summary>
        /// Takes .txt file as argument
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            //Creates two instances of classes required for functionality
            SortNames newSortArray = new SortNames();
            PrintNames newPrintArray = new PrintNames();

            //Takes unsorted names text file from argument and adds them to list
            List<string> newUnsorted = File.ReadAllLines(args[0]).ToList();

            //Sets SortArray list to list of unsorted names
            newSortArray.setnamesForSorting(newUnsorted);

            //Calls main SortArray method to sort list
            newSortArray.performSort();

            //Sets PrintArray list to list of sorted names
            newPrintArray.setSortedNames(newSortArray.getnamesSorted());

            //Calls main PrintArray method, printing to console and .txt in working directory
            newPrintArray.printSortedArray();
        }
    }
}