#if UNIT_TEST

using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace name_sorter.Tests
{
    [TestClass]
    public class NameSorterTests
    {
        // Attempts to sort a list of names (SUCCESSFUL IF: correctOrder[i] == sortedNames[i])
        [TestMethod]
        public void NameSorter_IsSorted()
        {
            INameSorter nameSorter = new NameSorter();

            string[] listNames = { "Janet Parsons", "London Lindsey", "Adonis Julius Archer" };
            string[] correctOrder = { "Adonis Julius Archer", "London Lindsey", "Janet Parsons" };

            string[] sortedNames = nameSorter.Sort(listNames);

            for (int i = 0; i < sortedNames.Length; i++)
            {
                Assert.AreEqual(correctOrder[i], sortedNames[i]);
            }
        }

        // Attempts to sort a list of names with the same last name (SUCCESSFUL IF: correctOrder[i] == sortedNames[i])
        [TestMethod]
        public void NameSorter_IsSorted_SameLastName()
        {
            INameSorter nameSorter = new NameSorter();

            string[] listNames = { "Janet Lindsey", "London Lindsey", "Adonis Julius Lindsey" };
            string[] correctOrder = { "Adonis Julius Lindsey", "Janet Lindsey", "London Lindsey" };

            string[] sortedNames = nameSorter.Sort(listNames);

            for (int i = 0; i < sortedNames.Length; i++)
            {
                Assert.AreEqual(correctOrder[i], sortedNames[i]);
            }
        }
    }
}

#endif