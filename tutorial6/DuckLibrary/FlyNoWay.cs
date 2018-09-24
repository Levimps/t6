using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckLibrary
{
    public class FlyNoWay : IFlyBehavior
    {
        public string Fly()
        {
            return "I can not fly.";
        }
    }
}