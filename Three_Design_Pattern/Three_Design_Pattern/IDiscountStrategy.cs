using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Design_Pattern
{
    //折價策略的介面
    public abstract class IDiscountStrategy
    {
        public double discount; //待確認

        public IDiscountStrategy(double discount)
        {
            this.discount = discount;
        }

        private IDiscountStrategy()
        { }

        public abstract double getValue(double value);
    }

    //減價策略
    public class MinusDiscount : IDiscountStrategy
    {
        public MinusDiscount(double discount) : base(discount)
        {
        }

        public override double getValue(double value)
        {
            return value - discount;
        }
    }

    //打折策略
    public class MultiplyStrategy : IDiscountStrategy
    {
        public MultiplyStrategy(double discount) : base(discount)
        {
        }

        public override double getValue(double value)
        {
            return value * discount;
        }
    }

    //不折價
    public class NoneDiscount : IDiscountStrategy
    {
        public NoneDiscount(double discount) : base(discount)
        {
        }

        public override double getValue(double value)
        {
            return value;
        }
    }
}