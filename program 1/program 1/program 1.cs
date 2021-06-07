using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpFundamentals
{
   public class Person
    { 
public string FirstName;
public string LastName;
         
public void Introduce()
{
    Console.WriteLine("Hello ! , My name is" + FirstName + " " + LastName);
            Console.ReadLine();
}
};
class Program
{ 
        static void Main(string[] args)
        {
        var Thomas = new Person();
        Thomas.FirstName = "Thomas";
        Thomas.LastName = "newt";
        Thomas.Introduce();
        }
    }
}
