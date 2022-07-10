using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Facade_Pattern
{
    public class Facade
    {
        private ClassOne four;
        private SubClassOne one;
        private SubClassThree three;
        private SubClassTwo two;

        public Facade()
        {
            one = new SubClassOne();
            two = new SubClassTwo();
            three = new SubClassThree();
            four = new ClassOne();
        }

        public void MethodA()
        {
            four.MethodFour();
            one.MethodOne();
        }

        public void MethodB()
        {
            two.MethodTwo();
            three.MethodThree();
        }
    }
}