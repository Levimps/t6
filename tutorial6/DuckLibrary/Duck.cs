using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DuckLibrary
{
    public abstract class Duck
    {
        protected IFlyBehavior _flyBehavior;
        protected IQuackBehavior _quackBehavior;

        public IFlyBehavior FlyBehavior  //property FlyBehavior
        {

            set
            {
                _flyBehavior = value;   //field _flyBehavior
            }
        }

        public IQuackBehavior QuackBehavior
        {
            set
            {
                _quackBehavior = value;
            }
        }

        public string PerformFly()
        {
            return _flyBehavior.Fly();     //IFlyBehavior.fly()
            
        }

        public string PerformQuack()
        {
            return _quackBehavior.Quack();   
            
        }

        public abstract string Display();

    }
}