using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace firstPractice
{
    public class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }

        public void Talk()
        {
            Console.WriteLine(Age);
        }
    }
}
