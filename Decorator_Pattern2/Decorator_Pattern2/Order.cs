using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Decorator_Pattern2
{
    public class Drink : Item
    {
        public override void show()
        {
            base.show();
            addDrink();
        }

        private void addDrink()
        {
            Console.WriteLine("一份飲料");
        }
    }

    public class Item : Order
    {
        protected Order order;

        public void decorate(Order order)
        {
            this.order = order;
        }

        public override void show()
        {
            if (order != null)
            {
                order.show();
            }
        }
    }

    public class MainMeal : Item
    {
        public override void show()
        {
            base.show();
            addMeal();
        }

        private void addMeal()
        {
            Console.WriteLine("加一份主餐");
        }
    }

    public class Order
    {
        public virtual void show()
        { }
    }

    public class Salad : Item
    {
        public override void show()
        {
            base.show();
            addSalad();
        }

        private void addSalad()
        {
            Console.WriteLine("一份沙拉");
        }
    }

    public class Set : Order
    {
        protected Order order;

        public void decorate(Order order)
        {
            this.order = order;
        }

        public override void show()
        {
            if (order != null)
            {
                order.show();
            }
        }
    }

    public class SimpleSet : Set
    {
        public override void show()
        {
            addSet();
            base.show();
        }

        private void addSet()
        {
            Salad salad = new Salad();
            MainMeal mainMeal = new MainMeal();
            Drink drink = new Drink();
            salad.decorate(order);
            mainMeal.decorate(salad);
            drink.decorate(mainMeal);
            this.order = drink;
        }
    }

    public class Soup : Item
    {
        public override void show()
        {
            base.show();
            addSoup();
        }

        private void addSoup()
        {
            Console.WriteLine("加一份湯品");
        }
    }
}