using System;

namespace name_sorter
{
    public class NameSorter : INameSorter
    {
        // Sorts the nameArray alphabetically according to their last name.
        public string[] Sort(string[] nameArray)
        {
            Array.Sort(nameArray, (a, b) =>
            {
                int compareResult = LastName(a).CompareTo(LastName(b));

                // Ensures that the name is sorted alphabetically even when two peoples last names are the same.
                return compareResult != 0 ? compareResult : a.CompareTo(b);
            });

            // Prints each of the names in the array.
            foreach(var name in nameArray)
            {
                Console.WriteLine(name);
            }

            return nameArray;
        }

        // Helper Function that finds the persons last name.
        private static string LastName(string name)
        {
            string[] nameSplit = name.Split(" ");
            int lastNameIndex = nameSplit.Length - 1;

            return nameSplit[lastNameIndex];
        }
    }
}
