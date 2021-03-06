﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public interface INotepad
    {
        List<Page> Pages { get; }

        void AppendTextToPage(int pageNumber, string text);

        void AddTextToPage(int pageNumber, string text);

        void DeletePage(int pageNumber);

        void PrintNotepad();

        bool SearchWord(string word);

        void PrintAllPagesWithDigits();
    }
}
