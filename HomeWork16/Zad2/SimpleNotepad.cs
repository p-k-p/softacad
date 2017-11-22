using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class SimpleNotepad : INotepad
    {
        public List<Page> Pages { get; private set; }

        public SimpleNotepad(int numberOfPages)
        {
            this.Pages = new List<Page>(numberOfPages);

            for (int i = 0; i < this.Pages.Capacity; i++)
            {
                this.Pages[i] = new Page("Page " + (i + 1));
            }
        }

        public SimpleNotepad()
        {
            this.Pages = new List<Page>();
        }

        public void AddPage(Page page)
        {
            this.Pages.Add(page);   
        }

        public bool IsValidPage(int pageNumber, string text)
        {
            if (text != string.Empty)
            {
                if (pageNumber > 0 && pageNumber <= this.Pages.Capacity)
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
            for (int i = 0; i < this.Pages.Capacity; i++)
            {
                
                    Console.Write(this.Pages[i].ReadPage());
                
            }
        }

        public virtual bool SearchWord(string word)
        {

            foreach (Page page in this.Pages)
            {
                if (page != null)
                {
                    if (page.SearchWord(word) == true)
                    {
                        return true;
                    }
                }
            }

            return false;

        }

        public virtual void PrintAllPagesWithDigits()
        {

            for (int i = 0; i < this.Pages.Capacity; i++)
            {
                if (this.Pages[i].ContainsDigits() == true)
                {
                    Console.Write(this.Pages[i].ReadPage());
                }
            }
        }


    }
}
