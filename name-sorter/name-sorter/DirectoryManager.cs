using System;

namespace name_sorter
{
    public class DirectoryManager : IDirectoryManager
    {
        public void setDirectory()
        {
            // Gets the current directory (which is located in the bin/debug/net8.0 files) and navigates upwards three steps.
            string dir = Path.GetFullPath(Path.Combine(AppContext.BaseDirectory, @"..\..\.."));
            Environment.CurrentDirectory = dir;
        }
    }
}