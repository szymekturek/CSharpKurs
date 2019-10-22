using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            Person person2 = new Person(1, "Jan");
            Person person3 = new Person(2, "Jan", "ŁboRodo");
            Person person4 = new Person(3, "Jan", "ŁboRodo", "Waw", 21, "Man");
        }
    }
}
