using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Three_Design_Pattern
{
    public class DrinkOrder
    {
        //放飲料的list
        private List<Drink> drinkList = new List<Drink>();

        //加入飲料
        public void addDrink(Drink drink)
        {
            drinkList.Add(drink);
        }

        //訂單總價錢
        public double getTotalPrice(IDiscountStrategy discountStrategy)
        {
            double totalPrice = this.totalPrice();
            return discountStrategy.getValue(totalPrice);
        }

        //移除飲料
        public void removeDrink(Drink drink)
        {
            drinkList.Remove(drink);
        }

        //飲料總價錢（私有方法）
        private double totalPrice()
        {
            double totalPrice = 0;
            foreach (Drink d in drinkList)
            {
                totalPrice += d.getValue();
            }
            return totalPrice;
        }
    }
}