using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorPhoneBook
{
    public class Person
    {
        public int Age { get ; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public string Address { get; set; }
       
        public Person()
        {

        }
        public Person(string name, string phone)
        {
            Name = name;
            Phone = phone;
        }

        public override string ToString()
        {
            return $"Name :{Name} Age:{Age} Phone:{Phone} Address:{Address}";
        }

    }
}
