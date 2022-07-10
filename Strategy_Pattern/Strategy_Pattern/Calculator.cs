using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public enum DoType
    {
        ADD, MINUS, DIVIDE, MULTYPLY
    }

    public class Calculator
    {
        private int now = 0;

        private IStrategy strategy;

        //    策略模式
        public int execute(int a, int b)
        {
            return strategy.calculate(a, b);
        }

        public void reset()
        {
            this.now = 0;
        }

        //    簡單工廠模式
        public void setStrategy(DoType doType)
        {
            switch (doType)
            {
                case DoType.ADD:
                    this.strategy = new add();
                    break;

                case DoType.MINUS:
                    this.strategy = new minus();
                    break;

                case DoType.DIVIDE:
                    this.strategy = new divide();
                    break;

                case DoType.MULTYPLY:
                    this.strategy = new multyply();
                    break;
            }
        }
    }
}