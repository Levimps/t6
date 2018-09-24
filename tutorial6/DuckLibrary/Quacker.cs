using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckLibrary
{
    public class Quacker : IQuackBehavior
    {
        public string Quack()
        {
            return "I can quack.";
        }
    }
}