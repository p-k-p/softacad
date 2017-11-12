using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class SimpleNotepad : INotepad
    {
        public Page[] Pages { get; private set; }

        public SimpleNotepad(int numberOfPages)
        {
            this.Pages = new Page[numberOfPages];
            for (int i = 0; i < this.Pages.Length; i++)
            {
                this.Pages[i] = new Page("Page " + (i + 1));
            }
        }

        public bool IsValidPage(int pageNumber, string text)
        {
            if (text != string.Empty)
            {
                if (pageNumber > 0 && pageNumber < this.Pages.Length)
                {
                    return true;
                }
            }

            return false;
                     
        }

        public virtual void AppendTextToPage(int pageNumber, string text)
        {
            if (IsValidPage(pageNumber, text))
            {
                
                this.Pages[pageNumber - 1].AddText(text);
                                   
            }
        }

        public virtual void AddTextToPage(int pageNumber, string text)
        {
            if (IsValidPage(pageNumber, text))
            {
                this.Pages[pageNumber - 1].DeleteText();
                    this.Pages[pageNumber - 1].AddText(text);
                
            }
        }

        public virtual void DeletePage(int pageNumber)
        {
            if (IsValidPage(pageNumber," "))
            {
                this.Pages[pageNumber - 1].DeleteText();
                
            }
        }

        public virtual void PrintNotepad()
        {
            foreach(Page page in this.Pages)
            {
                if (page != null)
                {
                    Console.Write(page.ReadPage());
                }
            }
        }



    }
}
