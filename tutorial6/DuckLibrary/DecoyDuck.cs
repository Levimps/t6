using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckLibrary
{
    public class DecoyDuck : Duck
    {
        public DecoyDuck()
        {
            FlyBehavior = new FlyNoWay();
            
            QuackBehavior = new MuteQuack(); 
        }

        public override string Display()
        {
            return "I am a deoy duck.";
        }
    }
}