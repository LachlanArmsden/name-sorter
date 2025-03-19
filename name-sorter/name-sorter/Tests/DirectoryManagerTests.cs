#if UNIT_TEST

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace name_sorter.Tests
{
    [TestClass]
    public class DirectoryManagerTests
    {
        // Ensures that setDirectory has changed to the correct location (SUCCESSFUL IF: TRUE)
        [TestMethod]
        public void DirectoryManager_SetDirectory()
        {
            IDirectoryManager directoryManager = new DirectoryManager();

            directoryManager.setDirectory();

            string currentDirectory = Directory.GetCurrentDirectory();
            string workingDirectory = AppContext.BaseDirectory.ToString();

            Assert.AreNotEqual(currentDirectory, workingDirectory);
        }
    }
}

#endif