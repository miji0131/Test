using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp009
{
    public class Student<T>
    {
        public T hakBeon { get; set; }
        public string name { get; set; }
        public int age { get; set; }

    }
}
