using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Design_Pattern
{
    //咖啡
    public class Coffee : Drink
    {
        public Coffee(double value) : base(value)
        {
        }

        public Coffee(double value, IDiscountStrategy discountStrategy) : base(value, discountStrategy)
        {
        }

        public override double getValue()
        {
            return base.getValue();
        }
    }

    //飲料介面
    public abstract class Drink
    {
        private IDiscountStrategy discountStrategy = new NoneDiscount(1);
        private double value;

        public Drink()
        {
        }

        public Drink(double value)
        {
            this.value = value;
        }

        public Drink(double value, IDiscountStrategy discountStrategy)
        {
            this.value = value;
            this.discountStrategy = discountStrategy;
        }

        public virtual double getValue()
        {
            return discountStrategy.getValue(value);
        }
    }

    //奶茶
    public class MilkTea : Drink
    {
        public MilkTea(double value) : base(value)
        {
        }

        public MilkTea(double value, IDiscountStrategy discountStrategy) : base(value, discountStrategy)
        {
        }

        public override double getValue()
        {
            return base.getValue();
        }
    }
}