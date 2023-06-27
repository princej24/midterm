using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace midterm
{
    public abstract class Food : Product
    {
       public enum FoodTemp { Dairy, heated}
        FoodTemp _Temp;
        public Food(string name, double price, int points,FoodTemp temp) : base(name, price, points)
        {
            _Temp = temp;
        }

        public Food(string name, double price, int points) : base(name, price, points)
        {
        }

        public override string ToString()
        {
            return base.ToString() + $"- the food state - {_Temp}";
        }

    }
}
