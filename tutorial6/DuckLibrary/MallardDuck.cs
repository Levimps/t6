using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckLibrary
{
    public class MallardDuck : Duck
    {
        public MallardDuck()
        {
            FlyBehavior = new FlyWithWings();   
            QuackBehavior = new Quacker();  //public IQuackBehavior QuackBehavior
        }

        public override string Display()
        {
            return "I am a Mallard duck";
        }
    }
}