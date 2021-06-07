using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program_4
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstname = "jazz";
            var lastname = "mosh";
            var fullname = firstname + " " + lastname;
            var myfullname = string.Format("my name is {0}{1}", firstname, lastname);
            var names = new string[3] { "john", "jack", "marry" };
            var formattednames = string.Join(" ", names);
            var text = "hi john\nlook into the following path\n c:\\folder\\folder 1";
            Console.WriteLine(text);
            Console.ReadLine();
        }
    }
}
