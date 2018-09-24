using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckLibrary
{
    public class FlyWithWings : IFlyBehavior
    {
        public  string Fly()
        {
            return "I can fly with my wings.";
        }
    }
}