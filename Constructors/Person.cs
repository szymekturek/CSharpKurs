using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Person
    {
        private int id;
        private string firstName;
        private string lastName;
        private string address;
        private int age;
        private string gender;

        public Person()
        {
            id = 1;
            firstName = "Szymek";
            lastName = "Turek";
            age = 18;

        }
        // Przeciążenie konstruktorów

        public Person(int id, string firstname, string lastname, string address, int age, string gender)
        {
            this.id = id;
            firstName = firstname;
            lastName = lastname;
            this.address = address;
            this.age = age;
            this.gender = gender;
        }

        public Person(int id, string firstname, string lastname)
        {
            this.id = id;
            firstName = firstname;
            lastName = lastname;
            address = "Ktw";
            age = 20;
        }

        public Person(int id, string firstname)
        {
            this.id = id;
            firstName = firstname;
        }
    }
}
