using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp008_02
{
    public class Cow : Animal
    {
        public string farmer { get; set; }

        public void moo()
        {
            Console.WriteLine("음메~");
        }
    }
}