﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloCSharp009_02
{
    public class Rowlet : Animal, IFly, IPlant
    {
        public override void eat()
        {
            throw new NotImplementedException();
        }

        public void fly()
        {
            throw new NotImplementedException();
        }

        public void grow()
        {
            throw new NotImplementedException();
        }

        public void photosynthesize()
        {
            throw new NotImplementedException();
        }

        public override void sleep()
        {
            throw new NotImplementedException();
        }
    }
}
