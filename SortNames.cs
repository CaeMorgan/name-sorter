using System;
using System.Collections.Generic;
using System.Linq;

namespace name_sorter
{
    /// <summary>
    /// SortArray accepts an unsorted list and sorts,
    /// saving results to class variable
    /// </summary>

    public class SortNames
    {
        private List<string> namesForSorting = new List<string>();
        private List<string> namesSorted = new List<string>();

        /// <summary>
        /// Constructor for SortArray Class
        /// </summary>
        public SortNames()
        {
        }

        /// <summary>
        /// Takes namesForSorting, splits each line into seperate strings,
        /// performs sort by last name then by given names in reverse,
        /// adds sorted names to namesSorted
        /// </summary>
        public void performSort()
        {
            {
                var sorted = namesForSorting
                                .Select(s => s.Split(' '))
                                .OrderBy(a => a[a.Length - 1])
                                .ThenBy(a => a.Length > 2 ? a[1] : a[0])
                                .ThenBy(a => a[0])
                                .Select(a => String.Join(" ", a));

                foreach (var s in sorted)
                {
                    namesSorted.Add(s);
                }
            }
        }

        /// <summary>
        /// Setter for unSortedNames variable
        /// </summary>
        /// <param name="unsorted"></param>
        public void setnamesForSorting(List<String> unsorted)
        {
            namesForSorting = unsorted;
        }

        /// <summary>
        /// Setter for unortedNames variable
        /// </summary>
        public List<string> getnamesSorted()
        {
            return namesSorted;
        }
    }
}