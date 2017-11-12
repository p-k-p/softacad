using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class Page
    {
        public string Title { get; private set; }

        public string Text { get;private set; }

        public Page()
        {
            this.Title = string.Empty;
            this.Text = string.Empty;
        }
        public Page(string title) : this()
        {
            this.Title = title;
        }
        public Page(string title, string text): this(title)
        {
            this.Text = text;
        }

        public void AddText(string text)
        {
            if (text != string.Empty)
            {
                this.Text = this.Text + "\n" + text;
            }

        }

        public void DeleteText()
        {
            this.Text = string.Empty;
        }

        public string ReadPage()
        {
            return this.Title + "\n" + this.Text + "\n";
        }


    }
}
