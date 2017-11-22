using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class SecureNotepad : SimpleNotepad
    {

        private string Password {get; set; }

        public SecureNotepad(int numberOfPages, string password) : base(numberOfPages)
        {
            this.Password = password;
        }

        public bool CheckPassword()
        {
            Console.WriteLine("Please, enter password: ");
            if (Console.ReadLine() == this.Password)
            {
                return true;
            }
            
            return false;
        }

        public override void AppendTextToPage(int pageNumber, string text)
        {
            if (this.CheckPassword() == true)
            {
                base.AppendTextToPage(pageNumber, text);
            }
        }

        public override void AddTextToPage(int pageNumber, string text)
        {
            if (this.CheckPassword() == true)
            {
                base.AddTextToPage(pageNumber, text);
            }
        }

        public override void DeletePage(int pageNumber)
        {
            if (this.CheckPassword() == true)
            {
                base.DeletePage(pageNumber);
            }
        }

        public override void PrintNotepad()
        {
            if (this.CheckPassword() == true)
            {
                base.PrintNotepad();
            }
        }

    }
}
