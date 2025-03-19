using System;

namespace name_sorter
{
    public interface ITextFunction
    {
        string[] TextReader(string filename);
        void TextWriter(string filename, string[] textArray);
    }
}
