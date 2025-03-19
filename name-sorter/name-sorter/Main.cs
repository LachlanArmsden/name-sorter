using System;

namespace name_sorter
{
    class MainClass
    {
        static void Main(string[] args)
        {
            // Ensures that the program requires an input to execute properly.
            if (args.Length == 0)
            {
                Console.WriteLine("Program requires input.");
                return;
            }

            // Takes the user's input (which would be "./unsorted-names-list.txt").
            string userInput = args[0];

            ITextFunction textFunction = new TextFunction();
            INameSorter nameSorter = new NameSorter();

            // Reads the "unsorted-names-list.txt" file and assigns it to an array.
            string[] unsortedNames = textFunction.TextReader(userInput);

            // Sorts the "unsortedNames" array alphabetically according to the persons last name, assigning it to "sortedNames" array.
            string[] sortedNames = nameSorter.Sort(unsortedNames);

            // Writes a new file called "sorted-names-list.txt" containing the sorted names.
            textFunction.TextWriter("sorted-names-list.txt", sortedNames);
        }
    }
}