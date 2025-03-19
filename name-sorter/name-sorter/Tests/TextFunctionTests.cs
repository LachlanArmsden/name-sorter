#if UNIT_TEST

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace name_sorter.Tests
{
    [TestClass]
    public class TextFunctionTests
    {
        // Attempts to find the "unsorted-names-list.txt" file (SUCCESSFUL IF: TRUE)
        [TestMethod]
        public void Test_Reader_FindFile()
        {
            ITextFunction textFunction = new TextFunction();
            IDirectoryManager directoryManager = new DirectoryManager();

            directoryManager.setDirectory();

            string filename = "unsorted-names-list.txt";

            string[] unsortedNames = textFunction.TextReader(filename);

            Assert.IsNotEmpty(unsortedNames);
        }

        // Attempts to find the "sorted-names-list.txt" file (SUCCESSFUL IF: TRUE)
        [TestMethod]
        public void Test_Writer_FindFile()
        {
            IDirectoryManager directoryManager = new DirectoryManager();

            directoryManager.setDirectory();

            string filename = "sorted-names-list.txt";
            bool result = File.Exists(filename);
            Assert.IsTrue(result);
        }

        // Ensures that the "sorted-names-list.txt" file has content in it (SUCCESSFUL IF: TRUE)
        [TestMethod]
        public void Test_Writer_IsNotEmpty()
        {
            IDirectoryManager directoryManager = new DirectoryManager();

            directoryManager.setDirectory();

            string filename = "sorted-names-list.txt";
            string readText = File.ReadAllText(filename);

            Assert.IsNotEmpty(readText);
        }
    }
}

#endif