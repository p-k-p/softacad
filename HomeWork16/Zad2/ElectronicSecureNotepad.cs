using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    public class ElectronicSecureNotepad : SecureNotepad, IElectronicDevice
    {
        public bool IsStarted { get; private set; }

        public void Start()
        {
            this.IsStarted = true;
        }

        public void Stop()
        {
            this.IsStarted = false;
        }

        public ElectronicSecureNotepad(int numberOfPages, string password) : base(numberOfPages,password)
        {
            this.IsStarted = false;
        }


        public override void AppendTextToPage(int pageNumber, string text)
        {
            if (this.IsStarted == true)
            {
                base.AppendTextToPage(pageNumber, text);
            }
        }

        public override void AddTextToPage(int pageNumber, string text)
        {
            if (this.IsStarted == true)
            {
                base.AddTextToPage(pageNumber, text);
            }
        }

        public override void DeletePage(int pageNumber)
        {
            if (this.IsStarted == true)
            {
                base.DeletePage(pageNumber);
            }
        }

        public override void PrintNotepad()
        {
            if (this.IsStarted == true)
            {
                base.PrintNotepad();
            }
        }
    }
}
