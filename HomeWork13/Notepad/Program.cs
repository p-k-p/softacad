using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notepad
{
    class Program
    {
        static void Main(string[] args)
        {
            Page page1 = new Page("Page1 Title", "Page1 text is here ... :)");
            Page page2 = new Page("Page2 Title", "Page2 text is here ... :)");
            Page page3 = new Page("Page3 Title", "Page3 text is here ... :)");

            SimpleNotepad simple = new SimpleNotepad(5);
            simple.Pages[0] = page1;
            simple.Pages[1] = page2;
            simple.Pages[2] = page3;
            //Print this notepad
            simple.PrintNotepad();

            SecureNotepad secure = new SecureNotepad(3,"word");
            Console.WriteLine("Secure Notepad: ");
            secure.AddTextToPage(1, "Secure " + simple.Pages[0].ReadPage());
            secure.AddTextToPage(2, "Secure " + simple.Pages[1].ReadPage());
            //secure.AddTextToPage(3, "Secure " + simple.Pages[2].ReadPage());
            Console.WriteLine("Print Secure Notepad: ");

            secure.PrintNotepad();

            ElectronicSecureNotepad electronic = new ElectronicSecureNotepad(2,"pass");

            electronic.Start();

            Console.WriteLine("Electronic secure notepad: ");
            electronic.AddTextToPage(1, "Electronic Page 1");

            electronic.Stop();

            electronic.AddTextToPage(2, "Electronic Page 2");

            electronic.Start();

            Console.WriteLine("Electronic Secure Notepad Print: ");
            electronic.PrintNotepad();

            Console.WriteLine("Electronic Secure Notepad page contains digits: ");

            Console.WriteLine(electronic.Pages[0].ContainsDigits());

            Console.ReadKey();
        }
    }
}
