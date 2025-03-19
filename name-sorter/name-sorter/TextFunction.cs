using System;

namespace name_sorter
{
    public class TextFunction() : ITextFunction
    {
        // Reads the text file called "unsorted-names-list.txt" and returns it in a string array.
        public string[] TextReader(string filename)
        {
            // Sets the current working directory to where the project file is located.
            IDirectoryManager directoryManager = new DirectoryManager();
            directoryManager.setDirectory();

            try
            {
                string readText = File.ReadAllText(filename);
                string[] textArray = readText.Split('\n');

                return textArray;

            } catch (Exception e)
            {
                Console.WriteLine("Could not find " + filename);
                return Array.Empty<string>();
            }
        }

        // Writes a new text file named "sorted-names-list.txt" containing the sorted names alphabetically according to their last names.
        public void TextWriter(string filename, string[] textArray)
        {
            // Sets the current working directory to where the project file is located.
            IDirectoryManager directoryManager = new DirectoryManager();
            directoryManager.setDirectory();

            File.WriteAllLines(filename, textArray);
        }
    }
}
